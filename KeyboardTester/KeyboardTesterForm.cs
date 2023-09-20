using System.Diagnostics;

namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public KeyboardTesterForm()
        {
            InitiateDropDownMenu();
            CustomInitializeComponent();
            InitializeComponent();
            PreviewKeyDown += new PreviewKeyDownEventHandler(Form_PreviewKeyDown);
            KeyDown += new KeyEventHandler(Form_KeyDown);
            KeyUp += new KeyEventHandler(Form_KeyUp);
            Program.kh.KeyIntercepted += new KeyboardHook.KeyboardHookEventHandler(kh_KeyIntercepted);
        }

        private void kh_KeyIntercepted(KeyboardHook.KeyboardHookEventArgs e)
        {
            if (e.PassThrough)
            {
                this.TopMost = false;
            }
            Debug.WriteLine(e.KeyName);
            Debug.WriteLine(e.KeyCode);
            Debug.WriteLine("====================");
        }

        private void Form_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }

        // The KeyUp event is captured since the print screen key is never fired during the KeyDown event
        private void Form_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PrintScreen)
            {
                _keyboardHandler.KeyPressed(e);
                _textBoxLayout.SetTextBoxValues(e);
            }
            e.Handled = true;
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            _keyboardHandler.KeyPressed(e);
            _textBoxLayout.SetTextBoxValues(e);
            e.Handled = true;
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
            InitializeComponent();
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