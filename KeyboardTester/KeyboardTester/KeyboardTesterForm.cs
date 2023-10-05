namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public static Font? ScaledFont { get; private set; }

        public KeyboardTesterForm(KeyboardLayoutType keyboarLayoutEnum = KeyboardLayoutType.ISO_105)
        {
            var scaleRate = DeviceDpi / 96f * 100;
            ScaledFont = new("Segoe UI", _baseKeyWidth * 0.14f / scaleRate * 100);

            InitiateDropDownMenu();
            CustomInitializeComponent(keyboarLayoutEnum);

            if (Program.KeyboardHook is not null)
            {
                Program.KeyboardHook.KeyIntercepted += new KeyboardHookEventHandler(Kh_KeyIntercepted);
            }
        }

        private void Kh_KeyIntercepted(KeyboardHookEventArgs e)
        {
            KeyboardLayout.KeyEvent(e);
            InformationLayout.SetTextBoxValues(e);

            // Write to temporary log file to record the new state of the keyboard layout if the flag indicates that the key stroke was injected, i.e. a UITest.
            // OBS! It is not guaranteed that it's a UITest just because the key is injected, but all key strokes from UITests are injected.
            var injectedFlag = 0b10000;
            if (Convert.ToBoolean(e.KeyFlags & injectedFlag))
            {
                Logger.LogKeyboardLayoutState(KeyboardLayout);
            }
        }

        private void DropDownMenu_SelectedValueChanged(object? sender, EventArgs e)
        {
            InformationLayout.ChangeLayout(this);
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            InformationLayout.ResetLayouts(KeyboardLayout);
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            InformationLayout.Exit(this);
        }
    }
}