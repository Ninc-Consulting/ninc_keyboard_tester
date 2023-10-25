namespace KeyboardTesterApp
{
    partial class KeyboardTesterForm
    {
        private static readonly int _baseKeyWidth = Screen.FromPoint(Cursor.Position).Bounds.Width / 25;

        public DropDownArea DropDownArea { get; private set; }
        public KeyboardLayout KeyboardLayout { get; private set; }
        public InformationArea InformationArea { get; private set; }

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
            DropDownArea = new DropDownArea(_baseKeyWidth, ScaledFont);
            DropDownArea.DropDownMenu.SelectedValueChanged += DropDownMenu_SelectedValueChanged;

            Controls.Add(DropDownArea.DropDownMenu);
            Controls.Add(DropDownArea.DropDownLabel);
        }

        private void CustomInitializeComponent(KeyboardLayoutType keyboarLayoutType)
        {
            SuspendLayout();

            KeyboardLayout = keyboarLayoutType switch
            {
                KeyboardLayoutType.ISO_105_SE => new Iso105KeyboardLayout(_baseKeyWidth, DropDownArea),
                KeyboardLayoutType.Toughbook => new ToughbookKeyboardLayout(_baseKeyWidth, DropDownArea),
                KeyboardLayoutType.AllKeys => new AllKeysLayout(_baseKeyWidth, DropDownArea),
                _ => throw new ArgumentException($"Unknown keyboard layout: {keyboarLayoutType}"),
            };

            InformationArea = new(KeyboardLayout, _baseKeyWidth);
            InformationArea.ResetButton.Click += ResetButton_Click;
            InformationArea.ExitButton.Click += ExitButton_Click;

            AddLayoutsToControls();

            Name = "KeyboardTesterForm";
            Text = "NINC Keyboard Tester";
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).Bounds;
            ClientSize = GetTotalSize();
            Location = new Point(screen.Left + (screen.Width - Width) / 2, screen.Top + (screen.Height - Height) / 2);
            FormClosing += KeyboardTesterForm_FormClosing;

            ResumeLayout(false);
        }

        private void AddLayoutsToControls()
        {
            Controls.AddRange(KeyboardLayout.LayoutKeys.Values.ToArray());

            Controls.Add(InformationArea.KeyDownButtonExample);
            Controls.Add(InformationArea.KeyUpButtonExample);
            Controls.Add(InformationArea.KeyCodeValue);
            Controls.Add(InformationArea.KeyNameValue);
            Controls.Add(InformationArea.KeyFlagsValue);
            Controls.Add(InformationArea.KeyCodeText);
            Controls.Add(InformationArea.KeyNameText);
            Controls.Add(InformationArea.KeyFlagsText);
            Controls.Add(InformationArea.ResetButton);
            Controls.Add(InformationArea.ExitButton);
        }

        private Size GetTotalSize()
        {
            return new Size(Math.Max(KeyboardLayout.Size.Width, InformationArea.Size.Width), InformationArea.Location.Y + InformationArea.Size.Height);
        }
    }
}