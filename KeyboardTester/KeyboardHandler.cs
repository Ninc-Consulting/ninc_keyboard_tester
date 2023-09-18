using KeyboardTester.KeyboardLayouts;
using System.Drawing.Printing;
using static System.Windows.Forms.Control;

namespace KeyboardTester
{
    internal class KeyboardHandler
    {
        public KeyboardHandler(ControlCollection controls, Margins margins, KeyboarLayoutEnum keyboarLayoutEnum = KeyboarLayoutEnum.Cherry)
        {
            KeyboardLayout = keyboarLayoutEnum switch
            {
                KeyboarLayoutEnum.Cherry => KeyboardLayout = new CherryKeyboardLayout(controls, margins),
                KeyboarLayoutEnum.Laptop => KeyboardLayout = new LaptopKeyboardLayout(controls, margins),    // TODO: Create a laptop keyboard layout
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
