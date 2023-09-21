using KeyboardTester.KeyboardLayouts;
using static KeyboardTester.KeyboardHook;

namespace KeyboardTester
{
    internal class KeyboardHandler
    {
        public KeyboardHandler(int baseLength, KeyboarLayoutEnum keyboarLayoutEnum = KeyboarLayoutEnum.Cherry)
        {
            KeyboardLayout = keyboarLayoutEnum switch
            {
                KeyboarLayoutEnum.Cherry => KeyboardLayout = new CherryKeyboardLayout(baseLength),
                KeyboarLayoutEnum.Laptop => KeyboardLayout = new LaptopKeyboardLayout(baseLength),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutEnum}"),
            };
        }

        public KeyboardLayout KeyboardLayout { get; private set; }

        public void KeyPressed(KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;
            var keyValue = e.KeyCode;

            // The Alt Gr key triggers two key events
            // First left control with a flag that indicates that an Alt key is pressed and then right menu.
            // Do nothing when the event for the left control key is triggered.
            if (e.KeyCode == (int)Keys.LControlKey && Convert.ToBoolean(e.KeyFlags & altKeyFlag))
            {
                return;
            }
            
            // If the Return/Enter key is pressed, check the extended key flag to dstinguish between regular Return and NumPad Enter
            if (e.KeyCode == (int)Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag))
            {
                keyValue *= -1;
            }

            KeyboardLayout.Keys[keyValue].BackColor = Color.Purple;
            KeyboardLayout.Keys[keyValue].ForeColor = Color.White;
        }
    }
}
