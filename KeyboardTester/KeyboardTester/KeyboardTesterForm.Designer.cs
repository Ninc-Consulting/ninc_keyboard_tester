namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private static readonly int _baseLength = Screen.FromPoint(Cursor.Position).Bounds.Width / 30;

        public TextLayout TextLayout { get; private set; }
        public KeyboardLayout KeyboardLayout { get; private set; }
        public ComboBox DropDownMenu { get; private set; }

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
            DropDownMenu = new ComboBox();
            Controls.Add(DropDownMenu);

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

            DropDownMenu.Font = ScaledFont;
            DropDownMenu.DataSource = comboBoxItems;
            DropDownMenu.DisplayMember = "KeyboardLayoutText";
            DropDownMenu.ValueMember = "KeyboarLayoutType";
            DropDownMenu.SelectedItem = toughbookItem;
            DropDownMenu.Name = "DropDownMenu";
            DropDownMenu.Location = new Point(_baseLength, _baseLength / 4);
            DropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownMenu.TabStop = false;
            DropDownMenu.Width = GetDropDownWidth();
            DropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;
        }

        private int GetDropDownWidth()
        {
            int maxWidth = 0;
            int temp = 0;

            foreach (ComboBoxKeyboardLayoutItem item in DropDownMenu.Items)
            {
                var text = item.KeyboardLayoutText;
                Size size = TextRenderer.MeasureText(text, DropDownMenu.Font);
                temp = size.Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth + Convert.ToInt32(_baseLength / 2); // Add _baselength divided by 2 to account for the width of the dropdown button
        }

        private void CustomInitializeComponent(KeyboarLayoutType keyboarLayoutEnum)
        {
            SuspendLayout();

            KeyboardLayout = keyboarLayoutEnum switch
            {
                KeyboarLayoutType.Cherry => new CherryKeyboardLayout(_baseLength),
                KeyboarLayoutType.Toughbook => new ToughbookKeyboardLayout(_baseLength),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutEnum}"),
            };

            Controls.AddRange(KeyboardLayout.LayoutKeys.Values.ToArray());

            TextLayout = new(KeyboardLayout.Size, _baseLength);
            TextLayout.ResetButton.Click += ResetButton_Click;
            TextLayout.ExitButton.Click += ExitButton_Click;
            AddTextBoxLayoutToControls();

            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).Bounds;
            ClientSize = GetTotalSize();
            Location = new Point(screen.Left + (screen.Width - Width) / 2, screen.Top + (screen.Height - Height) / 2);
            ResumeLayout(false);
        }

        private void AddTextBoxLayoutToControls()
        {
            Controls.Add(TextLayout.KeyCodeValue);
            Controls.Add(TextLayout.KeyNameValue);
            Controls.Add(TextLayout.KeyFlagValue);
            Controls.Add(TextLayout.KeyCodeText);
            Controls.Add(TextLayout.KeyNameText);
            Controls.Add(TextLayout.KeyFlagText);
            Controls.Add(TextLayout.ResetButton);
            Controls.Add(TextLayout.ExitButton);
        }

        private Size GetTotalSize()
                {
            return new Size(
                Math.Max(KeyboardLayout.Size.Width, TextLayout.Size.Width),
                Math.Max(KeyboardLayout.Size.Height, TextLayout.Size.Height));
        }
    }
}