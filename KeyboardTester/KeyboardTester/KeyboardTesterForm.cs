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

            Logger.LogKeyboardLayoutState(KeyboardLayout);
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

        private void KeyboardTesterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Delete KeyboardLayoutState.txt if it has been created, since it is only used for UI tests
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KeyboardTester");
            var file = Path.Combine(folderPath, "KeyboardLayoutState.txt");
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
    }
}