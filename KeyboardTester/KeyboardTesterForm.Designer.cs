namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private TextBoxLayout _textBoxLayout;
        private KeyboardHandler _keyboardHandler;
        private static readonly int _baseLength = CalculateBaseLengthWithScreenResolution();
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
            // TODO: Create drop-down so user can switch keyboard layouts

            _dropDownMenu = new ComboBox();
            _dropDownMenu.Name = "DropDownMenu";
            _dropDownMenu.Location = new Point(_baseLength, 0);
            _dropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
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
            //_dropDownMenu.DataSource = new ComboBoxKeyboardLayoutItem[] {
            //    new ComboBoxKeyboardLayoutItem{ KeyboarLayoutEnum = KeyboarLayoutEnum.Cherry, KeyboardLayoutText = "Keyboard layout: 'Cherry'" },
            //    new ComboBoxKeyboardLayoutItem{ KeyboarLayoutEnum = KeyboarLayoutEnum.Laptop, KeyboardLayoutText = "Keyboard layout: 'Laptop'" }
            //};
            _dropDownMenu.Font = new("Segoe UI", Convert.ToInt32(_baseLength * 0.10));
            _dropDownMenu.Width = DropDownWidth(_dropDownMenu);
            _dropDownMenu.TabStop = false;
            _dropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;
        }
        
        private int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label = new Label();

            foreach (ComboBoxKeyboardLayoutItem item in myCombo.Items)
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
            _keyboardHandler = new(Controls, _baseLength, keyboarLayoutEnum);
            _textBoxLayout = new(Controls, _keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _baseLength);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
        }

        private Size GetSize(Size keyboardLayoutSize, Size textBoxLayoutSize)
        {
            return new Size(
                Math.Max(keyboardLayoutSize.Width, textBoxLayoutSize.Width),
                Math.Max(keyboardLayoutSize.Height, textBoxLayoutSize.Height));
        }

        private static int CalculateBaseLengthWithScreenResolution()
        {
            var baseLegth = Screen.PrimaryScreen.Bounds.Height / 20;
            if (baseLegth < 50)
            {
                baseLegth = 50;
            }
            return ((int)Math.Round(baseLegth / 100.0)) * 100; // Rounded to closest 100 to keep whole numbers when using _baseLength
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // KeyboardTesterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = GetSize(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - ClientSize.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ClientSize.Height) / 2);
            KeyPreview = true;
            Margin = new Padding(2, 2, 2, 2);
            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            ResumeLayout(false);
        }

        #endregion
    }
}