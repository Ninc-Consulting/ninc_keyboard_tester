namespace KeyboardTesterApp
{
    public partial class KeyboardTesterForm : Form
    {
        private readonly InformationAreaService _informationAreaService;
        private readonly KeyboardLayoutService _keyboardLayoutService;
        private readonly DropDownAreaService _dropDownMenuService;

        public static Font? ScaledFont { get; private set; }
        public const string Version = "1.0";

        public KeyboardTesterForm(KeyboardLayoutType keyboarLayoutEnum = KeyboardLayoutType.Toughbook)
        {
            _informationAreaService = new InformationAreaService();
            _keyboardLayoutService = new KeyboardLayoutService();
            _dropDownMenuService = new DropDownAreaService();

            var scaleRate = DeviceDpi / 96f * 100;
            ScaledFont = new("Segoe UI", _baseKeyWidth * 0.14f / scaleRate * 100);

            InitiateDropDownMenu();
            CustomInitializeComponent(keyboarLayoutEnum);

            if (Program.KeyboardHook is not null)
            {
                Program.KeyboardHook.KeyIntercepted += new KeyboardHookEventHandler(Kh_KeyIntercepted);
            }

            Logger.LogKeyboardLayoutState(KeyboardLayout);
        }

        private void Kh_KeyIntercepted(KeyboardHookEventArgs e)
        {
            _keyboardLayoutService.KeyEvent(KeyboardLayout, e);
            _informationAreaService.SetTextBoxValues(InformationArea, e);

            Logger.LogKeyboardLayoutState(KeyboardLayout);
        }

        private void DropDownMenu_SelectedValueChanged(object? sender, EventArgs e)
        {
            _dropDownMenuService.ChangeLayout(this);

            Logger.LogKeyboardLayoutState(KeyboardLayout);
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            _informationAreaService.ResetLayout(this);

            Logger.LogKeyboardLayoutState(KeyboardLayout);
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            _informationAreaService.Exit(this);
        }

        private void AboutButton_Click(object? sender, EventArgs e)
        {
            _informationAreaService.ShowAboutMessageBox();
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