using System.Windows.Forms;

namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private TextBoxLayout _textBoxLayout;
        private KeyboardHandler _keyboardHandler;
        private static readonly int _baseLength = CalculateBaseLength();
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
                KeyboarLayoutEnum = KeyboarLayoutEnum.Laptop,
                KeyboardLayoutText = "Keyboard layout: 'Laptop'"
            };
            comboBoxItems.Add(laptopItem);

            _dropDownMenu.DataSource = comboBoxItems;
            _dropDownMenu.DisplayMember = "KeyboardLayoutText";
            _dropDownMenu.ValueMember = "KeyboarLayoutEnum";
            _dropDownMenu.SelectedItem = cherryItem;
            _dropDownMenu.Name = "DropDownMenu";
            _dropDownMenu.Location = new Point(_baseLength, 0);
            _dropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            _dropDownMenu.Font = new("Segoe UI", Convert.ToInt32(_baseLength * 0.10));
            _dropDownMenu.TabStop = false;
            _dropDownMenu.Width = DropDownWidth();
            _dropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;

        }

        private int DropDownWidth()
        {
            int maxWidth = 0;
            int temp = 0;
            Label label = new Label();

            foreach (ComboBoxKeyboardLayoutItem item in _dropDownMenu.Items)
            {
                label.Text = item.KeyboardLayoutText;
                temp = label.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label.Dispose();
            return maxWidth + Convert.ToInt32(_baseLength / 2); // Add _baselength divided by 2 to account for the dropdown button
        }

        private void CustomInitializeComponent(KeyboarLayoutEnum keyboarLayoutEnum = KeyboarLayoutEnum.Cherry)
        {
            SuspendLayout();
            _keyboardHandler = new(_baseLength, keyboarLayoutEnum);
            Controls.AddRange(_keyboardHandler.KeyboardLayout.Keys.Values.ToArray());

            _textBoxLayout = new(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _baseLength);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
            AddTextBoxLayoutToControls();

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = GetSize(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - ClientSize.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ClientSize.Height) / 2);
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
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

        private static int CalculateBaseLength()
        {
            var baseLegth = Screen.PrimaryScreen.Bounds.Height / 20;
            if (baseLegth < 50)
            {
                baseLegth = 50;
            }
            return ((int)Math.Round(baseLegth / 100.0)) * 100;
        }
    }
}