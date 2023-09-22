namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public KeyboardTesterForm()
        {
            InitiateDropDownMenu();
            CustomInitializeComponent();
            if (Program.kh is not null)
            {
                Program.kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(Kh_KeyIntercepted);
            }
        }

        private void Kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.KeyEventType == KeyboardHook.KeyEventType.KeyDown)
            {
                _keyboardHandler.KeyPressed(e);
                _textBoxLayout.SetTextBoxValues(e);
            }
        }

        public void DropDownMenu_SelectedValueChanged(object? sender, EventArgs e)
        {
            foreach (var keyControl in Controls.OfType<Button>().ToList())
            {
                Controls.Remove(keyControl);
            }
            foreach (var textBoxControl in Controls.OfType<TextBox>().ToList())
            {
                Controls.Remove(textBoxControl);
            }
            CustomInitializeComponent((KeyboarLayoutEnum)_dropDownMenu.SelectedValue);
            ActiveControl = null;
        }

        public void ResetButton_Click(object? sender, EventArgs e)
        {
            _textBoxLayout.KeyValueValue.Text = "";
            _textBoxLayout.KeyCodeValue.Text = "";
            _textBoxLayout.KeyDataValue.Text = "";

            foreach (var key in _keyboardHandler.KeyboardLayout.Keys.Values)
            {
                key.BackColor = Color.FromArgb(0, 250, 250, 250);
                key.ForeColor = Color.Black;
            }
        }

        public void ExitButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}