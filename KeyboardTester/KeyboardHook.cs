/// KEYBOARD.CS
/// (c) 2006 by Emma Burrows
/// This file contains the following items:
///  - KeyboardHook: class to enable low-level keyboard hook using
///    the Windows API.
///  - KeyboardHookEventHandler: delegate to handle the KeyIntercepted
///    event raised by the KeyboardHook class.
///  - KeyboardHookEventArgs: EventArgs class to contain the information
///    returned by the KeyIntercepted event.
///    
/// Change history:
/// 17/06/06: 1.0 - First version.
/// 18/06/06: 1.1 - Modified proc assignment in constructor to make class backward 
///                 compatible with 2003.
/// 10/07/06: 1.2 - Added support for modifier keys:
///                 -Changed filter in HookCallback to WM_KEYUP instead of WM_KEYDOWN
///                 -Imported GetKeyState from user32.dll
///                 -Moved native DLL imports to a separate internal class as this 
///                  is a Good Idea according to Microsoft's guidelines
/// 13/02/07: 1.3 - Improved modifier key support:
///                 -Added CheckModifiers() method
///                 -Deleted LoWord/HiWord methods as they weren't necessary
///                 -Implemented Barry Dorman's suggestion to AND GetKeyState
///                  values with 0x8000 to get their result
/// 23/03/07: 1.4 - Fixed bug which made the Alt key appear stuck
///                 - Changed the line
///                     if (nCode >= 0 && (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP))
///                   to
///                     if (nCode >= 0)
///                     {
///                        if (wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP)
///                        ...
///                   Many thanks to "Scottie Numbnuts" for the solution.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KeyboardTester
{
    /// <summary>
    /// Low-level keyboard intercept class to trap and suppress system keys.
    /// </summary>
    public class KeyboardHook : IDisposable
    {
        //Keyboard API constants
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYUP = 0x0101;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_SYSKEYDOWN = 0x0104;

        //Variables used in the call to SetWindowsHookEx
        private readonly HookHandlerDelegate _proc;
        private readonly IntPtr _hookID = IntPtr.Zero;
        internal delegate IntPtr HookHandlerDelegate(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);

        /// <summary>
        /// Event triggered when a keystroke is intercepted by the 
        /// low-level hook.
        /// </summary>
        public event KeyboardHookEventHandler? KeyIntercepted;

        // Structure returned by the hook whenever a key is pressed
        internal struct KBDLLHOOKSTRUCT
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        /// <summary>
        /// Sets up a keyboard hook to trap all keystrokes without 
        /// passing any to other applications.
        /// </summary>
        public KeyboardHook()
        {
            _proc = new HookHandlerDelegate(HookCallback);
            using Process curProcess = Process.GetCurrentProcess();
            if (curProcess.MainModule is not null)
            {
                using ProcessModule curModule = curProcess.MainModule;
                if (curModule.ModuleName is not null)
                {
                    _hookID = NativeMethods.SetWindowsHookEx(WH_KEYBOARD_LL, _proc, NativeMethods.GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        /// <summary>
        /// Processes the key event captured by the hook.
        /// </summary>
        private IntPtr HookCallback(int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam)
        {
            if (nCode >= 0)
            {
                OnKeyIntercepted(new KeyboardHookEventArgs((int)wParam, lParam.vkCode, lParam.flags));

                // We can't trap the fucktion of NumLock only the indication on the keyboard
                // better to let it through than make it appear like it's blocked
                if (lParam.vkCode == (int)Keys.NumLock) 
                {
                    //Pass key to next application
                    return NativeMethods.CallNextHookEx(_hookID, nCode, wParam, ref lParam);
                }

                // Return a dummy value to trap key
                return (IntPtr)1;
            }
            //Pass key to next application
            return NativeMethods.CallNextHookEx(_hookID, nCode, wParam, ref lParam);
        }

        #region Event Handling
        /// <summary>
        /// Raises the KeyIntercepted event.
        /// </summary>
        /// <param name="e">An instance of KeyboardHookEventArgs</param>
        public void OnKeyIntercepted(KeyboardHookEventArgs e)
        {
            KeyIntercepted?.Invoke(e);
        }

        /// <summary>
        /// Delegate for KeyboardHook event handling.
        /// </summary>
        /// <param name="e">An instance of InterceptKeysEventArgs.</param>
        public delegate void KeyboardHookEventHandler(KeyboardHookEventArgs e);

        /// <summary>
        /// Indicates whether a KeyEvent is a KeyUpEvent, KeyDownEvent or other event
        /// </summary>
        public enum KeyEventType
        {
            KeyUp,
            KeyDown,
            Other
        }

        /// <summary>
        /// Event arguments for the KeyboardHook class's KeyIntercepted event.
        /// </summary>
        public class KeyboardHookEventArgs : EventArgs
        {

            private readonly string _keyName;
            private readonly int _keyCode;
            private readonly int _keyFlags;
            private readonly KeyEventType _keyEventType;

            /// <summary>
            /// The name of the key that was pressed.
            /// </summary>
            public string KeyName
            {
                get { return _keyName; }
            }

            /// <summary>
            /// The virtual key code of the key that was pressed.
            /// </summary>
            public int KeyCode
            {
                get { return _keyCode; }
            }

            /// <summary>
            /// The flags of the key that was pressed.
            /// </summary>
            public int KeyFlags
            {
                get { return _keyFlags; }
            }

            /// <summary>
            /// Indicates whether it was a KeyUp, KeyDown or other event.
            /// </summary>
            public KeyEventType KeyEventType
            {
                get { return _keyEventType; }
            }

            public KeyboardHookEventArgs(int wParam, int vkCode, int vkFlags)
            {
                _keyName = ((Keys)vkCode).ToString();
                _keyCode = vkCode;
                _keyFlags = vkFlags;
                _keyEventType = wParam switch
                {
                    WM_KEYUP => KeyEventType.KeyUp,
                    WM_KEYDOWN => KeyEventType.KeyDown,
                    WM_SYSKEYDOWN => KeyEventType.KeyDown,
                    _ => KeyEventType.Other,
                };
            }

        }
        #endregion

        /// <summary>
        /// Releases the keyboard hook.
        /// </summary>
        public void Dispose()
        {
            NativeMethods.UnhookWindowsHookEx(_hookID);
            GC.SuppressFinalize(this);
        }

        [ComVisible(false)]
        internal class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr SetWindowsHookEx(int idHook, HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, ref KBDLLHOOKSTRUCT lParam);
        }
    }
}

