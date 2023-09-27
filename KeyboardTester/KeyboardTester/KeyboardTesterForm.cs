namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public static Font? ScaledFont { get; private set; }

        public KeyboardTesterForm(KeyboarLayoutType keyboarLayoutEnum = KeyboarLayoutType.Toughbook)
        {
            var scaleRate = DeviceDpi / 96f * 100;
            ScaledFont = new("Segoe UI", _baseLength * 0.14f / scaleRate * 100);

            InitiateDropDownMenu();
            CustomInitializeComponent(keyboarLayoutEnum);

            if (Program.KeyboardHook is not null)
            {
                Program.KeyboardHook.KeyIntercepted += new KeyboardHookEventHandler(Kh_KeyIntercepted);
            }
        }

        private void Kh_KeyIntercepted(KeyboardHookEventArgs e)
        {
            if (e.KeyEventType == KeyEventType.KeyDown)
            {
                KeyboardLayout.KeyDownEvent(e);
                TextLayout.SetTextBoxValues(e);
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

            CustomInitializeComponent((KeyboarLayoutType)DropDownMenu.SelectedValue);
            ActiveControl = null;
        }

        private void ResetButton_Click(object? sender, EventArgs e)
        {
            TextLayout.KeyCodeValue.Text = string.Empty;
            TextLayout.KeyNameValue.Text = string.Empty;
            TextLayout.KeyFlagValue.Text = string.Empty;

            foreach (var key in KeyboardLayout.LayoutKeys.Values)
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