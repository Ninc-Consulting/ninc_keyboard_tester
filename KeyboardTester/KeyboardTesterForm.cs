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
        }

        private void Form_KeyDown(object? sender, KeyEventArgs e)
        {
            _keyboardHandler.KeyPressed(e);
            _textBoxLayout.SetTextBoxValues(e);
        }

        public void DropDownMenu_SelectedValueChanged(object? sender, EventArgs e)
        {
            var selectedValue = (KeyboarLayoutEnum)_dropDownMenu.SelectedValue;
            //var selectedText = ;
            Controls.Clear();
            Controls.Add(_dropDownMenu);
            _dropDownMenu.SelectedValueChanged -= DropDownMenu_SelectedValueChanged;
            _dropDownMenu.SelectedValue = selectedValue;
            _dropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;
            CustomInitializeComponent(selectedValue);
            InitializeComponent();
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