namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
        private static readonly int _baseKeyWidth = Screen.FromPoint(Cursor.Position).Bounds.Width / 30;

        public InformationLayout InformationLayout { get; private set; }
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

        public void ReInitializeComponent(KeyboardLayoutType keyboarLayoutType)
        {
            CustomInitializeComponent(keyboarLayoutType);
        }

        private void InitiateDropDownMenu()
        {
            DropDownMenu = new ComboBox();
            Controls.Add(DropDownMenu);

            var comboBoxItems = new List<ComboBoxKeyboardLayoutItem>();
            var iso105Item = new ComboBoxKeyboardLayoutItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.ISO_105,
                KeyboardLayoutText = "Keyboard layout: 'ISO 105'"
            };
            comboBoxItems.Add(iso105Item);
            var toughbookItem = new ComboBoxKeyboardLayoutItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.Toughbook,
                KeyboardLayoutText = "Keyboard layout: 'Toughbook'"
            };
            comboBoxItems.Add(toughbookItem);

            DropDownMenu.Font = ScaledFont;
            DropDownMenu.DataSource = comboBoxItems;
            DropDownMenu.DisplayMember = "KeyboardLayoutText";
            DropDownMenu.ValueMember = "KeyboardLayoutType";
            DropDownMenu.SelectedItem = iso105Item;
            DropDownMenu.Name = "DropDownMenu";
            DropDownMenu.Location = new Point(_baseKeyWidth, _baseKeyWidth / 4);
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
            return maxWidth + Convert.ToInt32(_baseKeyWidth / 2); // Add _baseKeyWidth divided by 2 to account for the width of the dropdown button
        }

        private void CustomInitializeComponent(KeyboardLayoutType keyboarLayoutType)
        {
            SuspendLayout();

            KeyboardLayout = keyboarLayoutType switch
            {
                KeyboardLayoutType.ISO_105 => new Iso105KeyboardLayout(_baseKeyWidth),
                KeyboardLayoutType.Toughbook => new ToughbookKeyboardLayout(_baseKeyWidth),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutType}"),
            };
            InformationLayout = new(KeyboardLayout.Size, _baseKeyWidth);

            InformationLayout.ResetButton.Click += ResetButton_Click;
            InformationLayout.ExitButton.Click += ExitButton_Click;

            AddLayoutsToControls();

            Name = "KeyboardTesterForm";
            Text = "NINC Keyboard Tester";
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).Bounds;
            ClientSize = GetTotalSize();
            Location = new Point(screen.Left + (screen.Width - Width) / 2, screen.Top + (screen.Height - Height) / 2);

            ResumeLayout(false);
        }

        private void AddLayoutsToControls()
        {
            Controls.AddRange(KeyboardLayout.LayoutKeys.Values.ToArray());

            Controls.Add(InformationLayout.KeyCodeValue);
            Controls.Add(InformationLayout.KeyNameValue);
            Controls.Add(InformationLayout.KeyFlagsValue);
            Controls.Add(InformationLayout.KeyCodeText);
            Controls.Add(InformationLayout.KeyNameText);
            Controls.Add(InformationLayout.KeyFlagsText);
            Controls.Add(InformationLayout.ResetButton);
            Controls.Add(InformationLayout.ExitButton);
        }

        private Size GetTotalSize()
                {
            return new Size(
                Math.Max(KeyboardLayout.Size.Width, InformationLayout.Size.Width),
                Math.Max(KeyboardLayout.Size.Height, InformationLayout.Size.Height));
        }
    }
}