namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public static Font? ScaledFont { get; private set; }

        public KeyboardTesterForm()
        {
            var scaleRate = DeviceDpi / 96f * 100;
            ScaledFont = new ("Segoe UI", _baseLength * 0.14f / scaleRate * 100);

            InitiateDropDownMenu();
            CustomInitializeComponent();

            if (Program.KeyboardHook is not null)
            {
                Program.KeyboardHook.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(Kh_KeyIntercepted);
            }
        }

        private void Kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.KeyEventType == KeyboardHook.KeyEventType.KeyDown)
            {
                _keyboardLayout.KeyDownEvent(e);
                _textBoxLayout.SetTextBoxValues(e);
            }
        }

        private void DropDownMenu_SelectedValueChanged(object? sender, EventArgs e)
        {
            foreach (var keyControl in Controls.OfType<Button>().ToList())
            {
                Controls.Remove(keyControl);
            }

            foreach (var textBoxControl in Controls.OfType<TextBox>().ToList())
            {
                Controls.Remove(textBoxControl);
            }

            CustomInitializeComponent((KeyboarLayoutType)_dropDownMenu.SelectedValue);
            ActiveControl = null;
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            _textBoxLayout.KeyValueValue.Text = string.Empty;
            _textBoxLayout.KeyCodeValue.Text = string.Empty;
            _textBoxLayout.KeyDataValue.Text = string.Empty;

            foreach (var key in _keyboardLayout.LayoutKeys.Values)
            {
                key.BackColor = Color.FromArgb(0, 250, 250, 250);
                key.ForeColor = Color.Black;
            }
        }

        private void ExitButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}