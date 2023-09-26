namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private static readonly int _baseLength = Screen.FromPoint(Cursor.Position).Bounds.Width / 30;

        private TextBoxLayout _textBoxLayout;
        private KeyboardLayout _keyboardLayout;
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
                KeyboarLayoutType = KeyboarLayoutType.Cherry,
                KeyboardLayoutText = "Keyboard layout: 'Cherry'"
            };
            comboBoxItems.Add(cherryItem);
            var toughbookItem = new ComboBoxKeyboardLayoutItem()
            {
                KeyboarLayoutType = KeyboarLayoutType.Toughbook,
                KeyboardLayoutText = "Keyboard layout: 'Toughbook'"
            };
            comboBoxItems.Add(toughbookItem);

            _dropDownMenu.Font = ScaledFont;
            _dropDownMenu.DataSource = comboBoxItems;
            _dropDownMenu.DisplayMember = "KeyboardLayoutText";
            _dropDownMenu.ValueMember = "KeyboarLayoutEnum";
            _dropDownMenu.SelectedItem = toughbookItem;
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

        private void CustomInitializeComponent(KeyboarLayoutType keyboarLayoutEnum = KeyboarLayoutType.Toughbook)
        {
            // TODO: Make all controls resize with the form

            SuspendLayout();

            _keyboardLayout = keyboarLayoutEnum switch
            {
                KeyboarLayoutType.Cherry => new CherryKeyboardLayout(_baseLength),
                KeyboarLayoutType.Toughbook => new ToughbookKeyboardLayout(_baseLength),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutEnum}"),
            };

            Controls.AddRange(_keyboardLayout.LayoutKeys.Values.ToArray());

            _textBoxLayout = new(_keyboardLayout.KeyboardLayoutSize, _baseLength);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
            AddTextBoxLayoutToControls();

            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).Bounds;
            ClientSize = GetSize(_keyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            Location = new Point(screen.Left + (screen.Width - Width) / 2, screen.Top + (screen.Height - Height) / 2);
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