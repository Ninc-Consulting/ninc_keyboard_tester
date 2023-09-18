using System.Drawing.Printing;
using static System.Windows.Forms.Control;

namespace KeyboardTester.KeyboardLayouts
{
    public class LaptopKeyboardLayout : KeyboardLayout
    {
        public LaptopKeyboardLayout(ControlCollection controls, Margins margins)
        { 
            AddControls(controls);
        }
    }
}
