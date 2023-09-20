using KeyboardTester.KeyboardLayouts;
using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.Control;

namespace KeyboardTester
{
    internal class KeyboardHandler
    {
        public KeyboardHandler(ControlCollection controls, int baseLength, KeyboarLayoutEnum keyboarLayoutEnum = KeyboarLayoutEnum.Cherry)
        {
            KeyboardLayout = keyboarLayoutEnum switch
            {
                KeyboarLayoutEnum.Cherry => KeyboardLayout = new CherryKeyboardLayout(controls, baseLength),
                KeyboarLayoutEnum.Laptop => KeyboardLayout = new LaptopKeyboardLayout(controls, baseLength),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutEnum}"),
            };
        }

        public KeyboardLayout KeyboardLayout { get; private set; }

        public void KeyPressed(KeyEventArgs e)
        {
            if (KeyboardLayout.Keys.ContainsKey(e.KeyValue))
            {
                if (e.KeyCode == Keys.ShiftKey)
                { 
                    if (Convert.ToBoolean(GetAsyncKeyState(Keys.LShiftKey)))
                    {
                        KeyboardLayout.Keys[e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[e.KeyValue].ForeColor = Color.White;
                    }
                    else if (Convert.ToBoolean(GetAsyncKeyState(Keys.RShiftKey)))
                    {
                        KeyboardLayout.Keys[-e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[-e.KeyValue].ForeColor = Color.White;
                    }
                }
                else if (e.KeyCode == Keys.ControlKey)
                {
                    if (Convert.ToBoolean(GetAsyncKeyState(Keys.RMenu)))
                    {
                        // The ALT GR key triggers two key events, first left control and then right menu.
                        // Do nothing when the event for the left control key is triggered.
                        return;
                    }
                    else if (Convert.ToBoolean(GetAsyncKeyState(Keys.LControlKey)))
                    {
                        KeyboardLayout.Keys[e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[e.KeyValue].ForeColor = Color.White;
                    }
                    else if (Convert.ToBoolean(GetAsyncKeyState(Keys.RControlKey)))
                    {
                        KeyboardLayout.Keys[-e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[-e.KeyValue].ForeColor = Color.White;
                    }
                }
                else if (e.KeyCode == Keys.Menu)
                {
                    if (Convert.ToBoolean(GetAsyncKeyState(Keys.LMenu)))
                    {
                        KeyboardLayout.Keys[e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[e.KeyValue].ForeColor = Color.White;
                    }
                    else if (Convert.ToBoolean(GetAsyncKeyState(Keys.RMenu)))
                    {
                        KeyboardLayout.Keys[-e.KeyValue].BackColor = Color.Purple;
                        KeyboardLayout.Keys[-e.KeyValue].ForeColor = Color.White;
                    }
                }
                //else if (e.KeyCode == Keys.Enter)
                //{
                //    KeyboardLayout.Keys[-e.KeyValue].BackColor = Color.Purple;
                //    KeyboardLayout.Keys[-e.KeyValue].ForeColor = Color.White;
                //}
                else
                {
                    KeyboardLayout.Keys[e.KeyValue].BackColor = Color.Purple;
                    KeyboardLayout.Keys[e.KeyValue].ForeColor = Color.White;
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);
    }
}
