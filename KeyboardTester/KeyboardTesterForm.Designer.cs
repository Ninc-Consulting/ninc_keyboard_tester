namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private TextBoxLayout _textBoxLayout;
        private KeyboardHandler _keyboardHandler;
        private static readonly int _baseLength = Screen.FromPoint(Cursor.Position).Bounds.Width / 30;
        private ComboBox _dropDownMenu;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer _components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (_components != null))
            {
                _components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitiateDropDownMenu()
        {
            _dropDownMenu = new ComboBox();
            Controls.Add(_dropDownMenu);

            var comboBoxItems = new List<ComboBoxKeyboardLayoutItem>();
            var cherryItem = new ComboBoxKeyboardLayoutItem()
            {
                KeyboarLayoutEnum = KeyboarLayoutEnum.Cherry,
                KeyboardLayoutText = "Keyboard layout: 'Cherry'"
            };
            comboBoxItems.Add(cherryItem);
            var laptopItem = new ComboBoxKeyboardLayoutItem()
            {
                KeyboarLayoutEnum = KeyboarLayoutEnum.Toughbook,
                KeyboardLayoutText = "Keyboard layout: 'Toughbook'"
            };
            comboBoxItems.Add(laptopItem);

            _dropDownMenu.Font = new("Segoe UI", Convert.ToInt32(_baseLength * 0.14));
            _dropDownMenu.DataSource = comboBoxItems;
            _dropDownMenu.DisplayMember = "KeyboardLayoutText";
            _dropDownMenu.ValueMember = "KeyboarLayoutEnum";
            _dropDownMenu.SelectedItem = laptopItem;
            _dropDownMenu.Name = "DropDownMenu";
            _dropDownMenu.Location = new Point(_baseLength, _baseLength / 4);
            _dropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            _dropDownMenu.TabStop = false;
            _dropDownMenu.Width = GetDropDownWidth();
            _dropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;
        }

        private int GetDropDownWidth()
        {
            int maxWidth = 0;
            int temp = 0;

            foreach (ComboBoxKeyboardLayoutItem item in _dropDownMenu.Items)
            {
                var text = item.KeyboardLayoutText;
                Size size = TextRenderer.MeasureText(text, _dropDownMenu.Font);
                temp = size.Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth + Convert.ToInt32(_baseLength / 2); // Add _baselength divided by 2 to account for the width of the dropdown button
        }

        private void CustomInitializeComponent(KeyboarLayoutEnum keyboarLayoutEnum = KeyboarLayoutEnum.Toughbook)
        {
            // TODO: Make all controls resize with the form

            SuspendLayout();
            _keyboardHandler = new(_baseLength, keyboarLayoutEnum);
            Controls.AddRange(_keyboardHandler.KeyboardLayout.Keys.Values.ToArray());

            _textBoxLayout = new(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _baseLength);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
            AddTextBoxLayoutToControls();

            Margin = new Padding(2);
            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).Bounds;
            Width = _keyboardHandler.KeyboardLayout.KeyboardLayoutSize.Width;
            Height = _keyboardHandler.KeyboardLayout.KeyboardLayoutSize.Height;
            var clientWidth = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int clientHeight = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - clientWidth) / 2, screen.Top + (screen.Height - clientHeight) / 2);
            ClientSize = GetSize(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            ResumeLayout(false);
        }

        private void AddTextBoxLayoutToControls()
        {
            Controls.Add(_textBoxLayout.KeyValueValue);
            Controls.Add(_textBoxLayout.KeyCodeValue);
            Controls.Add(_textBoxLayout.KeyDataValue);
            Controls.Add(_textBoxLayout.KeyValueText);
            Controls.Add(_textBoxLayout.KeyCodeText);
            Controls.Add(_textBoxLayout.KeyDataText);
            Controls.Add(_textBoxLayout.ResetButton);
            Controls.Add(_textBoxLayout.ExitButton);
        }

        private Size GetSize(Size keyboardLayoutSize, Size textBoxLayoutSize)
        {
            return new Size(
                Math.Max(keyboardLayoutSize.Width, textBoxLayoutSize.Width),
                Math.Max(keyboardLayoutSize.Height, textBoxLayoutSize.Height));
        }
    }
}