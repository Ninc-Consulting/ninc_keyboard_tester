// (c) 2006 by Emma Burrows
// Original code: https://www.codeproject.com/Articles/14485/Low-level-Windows-API-hooks-from-C-to-stop-unwante

namespace KeyboardTesterApp
{
    /// <summary>
    /// Low-level keyboard intercept class to trap and suppress system keys.
    /// </summary>
    public class KeyboardHook : IDisposable
    {
        private readonly IntPtr _hookID = IntPtr.Zero;
        private delegate IntPtr HookHandlerDelegate(int nCode, IntPtr wParam, ref KbDllHookStruct lParam);

        // Disable warning becuase the handler has to be static so it can survive the duration of the application
#pragma warning disable S1450 // Private fields only used as local variables in methods should become local variables
        private static HookHandlerDelegate _hookHandler = default!;
#pragma warning restore S1450 // Private fields only used as local variables in methods should become local variables

        /// <summary>
        /// Event triggered when a keystroke is intercepted by the
        /// low-level hook.
        /// </summary>
        public event KeyboardHookEventHandler? KeyIntercepted;

        // Structure returned by the hook whenever a key is pressed
        internal struct KbDllHookStruct
        {
            public int VkCode;
            public int ScanCode;
            public int Flags;
            public int Time;
            public int DwExtraInfo;
        }

        /// <summary>
        /// Sets up a keyboard hook to trap all keystrokes without passing any to other applications.
        /// </summary>
        public KeyboardHook()
        {
            // Keyboard API constant
            var whKeyboardLl = 13;

            // Disable warning because we can't initialize it statically
#pragma warning disable S3010 // Static fields should not be updated in constructors
            _hookHandler = new HookHandlerDelegate(HookCallback);
#pragma warning restore S3010 // Static fields should not be updated in constructors

            using Process curProcess = Process.GetCurrentProcess();
            if (curProcess.MainModule is not null)
            {
                using ProcessModule curModule = curProcess.MainModule;
                if (curModule.ModuleName is not null)
                {
                    _hookID = NativeMethods.SetWindowsHookEx(whKeyboardLl, _hookHandler, NativeMethods.GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        /// <summary>
        /// Raises the KeyIntercepted event.
        /// </summary>
        /// <param name="e">An instance of KeyboardHookEventArgs.</param>
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
        /// Indicates whether a KeyEvent is a KeyUpEvent, KeyDownEvent or other event.
        /// </summary>
        public enum KeyEventType
        {
            KeyUp,
            KeyDown
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
            /// Gets the name of the key that was pressed.
            /// </summary>
            public string KeyName
            {
                get { return _keyName; }
            }

            /// <summary>
            /// Gets the virtual key code of the key that was pressed.
            /// </summary>
            public int KeyCode
            {
                get { return _keyCode; }
            }

            /// <summary>
            /// Gets the flags of the key that was pressed.
            /// </summary>
            public int KeyFlags
            {
                get { return _keyFlags; }
            }

            /// <summary>
            /// Gets the KeyEventType which indicates whether it was a KeyUp, KeyDown or other event.
            /// </summary>
            public KeyEventType KeyEventType
            {
                get { return _keyEventType; }
            }

            public KeyboardHookEventArgs(int wParam, int vkCode, int vkFlags)
            {
                var wmKeyDown = 0x0100;
                var wmKeyUp = 0x0101;
                var wmSysKeyDown = 0x0104;
                var wmSysKeyUp = 0x0105;

                _keyName = ((Keys)vkCode).ToString();
                _keyCode = vkCode;
                _keyFlags = vkFlags;

                if (wParam == wmKeyUp || wParam == wmSysKeyUp)
                {
                    _keyEventType = KeyEventType.KeyUp;
                }
                else if (wParam == wmKeyDown || wParam == wmSysKeyDown)
                {
                    _keyEventType = KeyEventType.KeyDown;
                }
            }
        }

        /// <summary>
        /// Releases the keyboard hook.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            NativeMethods.UnhookWindowsHookEx(_hookID);
        }

        /// <summary>
        /// Processes the key event captured by the hook.
        /// </summary>
        private IntPtr HookCallback(int nCode, IntPtr wParam, ref KbDllHookStruct lParam)
        {
            if (nCode >= 0)
            {
                OnKeyIntercepted(new KeyboardHookEventArgs((int)wParam, lParam.VkCode, lParam.Flags));

                // We can't trap the fucktion of NumLock only the indication on the keyboard
                // better to let it through than make it appear like it's blocked.
                if (lParam.VkCode == (int)Keys.NumLock)
                {
                    // Pass key to next application
                    return NativeMethods.CallNextHookEx(_hookID, nCode, wParam, ref lParam);
                }

                // Return a dummy value to trap key
                return (IntPtr)1;
            }

            // Pass key to next application
            return NativeMethods.CallNextHookEx(_hookID, nCode, wParam, ref lParam);
        }

        private static class NativeMethods
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr GetModuleHandle(string lpModuleName);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr SetWindowsHookEx(int idHook, HookHandlerDelegate lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, ref KbDllHookStruct lParam);
        }
    }
}