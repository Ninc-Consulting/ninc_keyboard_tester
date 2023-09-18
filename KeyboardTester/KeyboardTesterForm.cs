using System.Diagnostics;

namespace KeyboardTester
{
    public partial class KeyboardTesterForm : Form
    {
        public KeyboardTesterForm()
        {
            CustomInitializeComponent();
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form_KeyDown);
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            e.Handled = true;
            _keyboardHandler.KeyPressed(e);
            _textBoxLayout.SetTextBoxValues(e);
        }

        public void ResetButton_Click(object sender, EventArgs e)
        {
            _textBoxLayout.KeyValueValue.Text = "";
            _textBoxLayout.KeyCodeValue.Text = "";
            _textBoxLayout.KeyDataValue.Text = "";

            foreach (var key in _keyboardHandler.KeyboardLayout.Keys.Values)
            {
                key.BackColor = Color.White;
                key.ForeColor = Color.Black;
            }
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}