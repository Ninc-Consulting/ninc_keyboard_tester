namespace KeyboardTester.Layouts
{
    public class TextLayout
    {
        public TextBox KeyCodeText { get; private set; } = new();
        public TextBox KeyNameText { get; private set; } = new();
        public TextBox KeyFlagText { get; private set; } = new();
        public TextBox KeyCodeValue { get; private set; } = new();
        public TextBox KeyNameValue { get; private set; } = new();
        public TextBox KeyFlagValue { get; private set; } = new();
        public Button ResetButton { get; private set; } = new();
        public Button ExitButton { get; private set; } = new();

        public Size Size { get; private set; }

        private readonly int _offset;
        private readonly Size _textBoxSize;
        private readonly Size _buttonSize;
        private readonly Font? _font;

        public TextLayout(Size keboardLayoutSize, int baseLength)
        {
            _offset = Convert.ToInt32(baseLength / 2);
            _textBoxSize = new(baseLength * 3, Convert.ToInt32(baseLength / 2));
            _buttonSize = new(Convert.ToInt32(baseLength * 1.5), Convert.ToInt32(baseLength / 2));
            _font = KeyboardTesterForm.ScaledFont;

            DoLayout(keboardLayoutSize, baseLength);
        }

        public void SetTextBoxValues(KeyboardHookEventArgs e)
        {
            KeyCodeValue.Text = "0x" + Convert.ToString(e.KeyCode, 16).PadLeft(2, '0').ToUpper();
            KeyNameValue.Text = e.KeyName;
            KeyFlagValue.Text = Convert.ToString(e.KeyFlags, 2).PadLeft(8, '0');
        }

        private void DoLayout(Size keboardLayoutSize, int baseLength)
        {
            var yCoordinate = keboardLayoutSize.Height + baseLength;
            var xCoordinate = baseLength;

            KeyCodeText.BackColor = SystemColors.Control;
            KeyCodeText.BorderStyle = BorderStyle.None;
            KeyCodeText.Location = new Point(xCoordinate, yCoordinate);
            KeyCodeText.Name = "KeyCodeText";
            KeyCodeText.Size = _textBoxSize;
            KeyCodeText.TabIndex = 12;
            KeyCodeText.Text = "KeyCode";
            KeyCodeText.TextAlign = HorizontalAlignment.Center;
            KeyCodeText.TabStop = false;
            KeyCodeText.Font = _font;

            xCoordinate += _textBoxSize.Width + _offset;
            KeyNameText.BackColor = SystemColors.Control;
            KeyNameText.BorderStyle = BorderStyle.None;
            KeyNameText.Location = new Point(xCoordinate, yCoordinate);
            KeyNameText.Name = "KeyNameText";
            KeyNameText.Size = _textBoxSize;
            KeyNameText.TabIndex = 13;
            KeyNameText.Text = "KeyName";
            KeyNameText.TextAlign = HorizontalAlignment.Center;
            KeyNameText.TabStop = false;
            KeyNameText.Font = _font;

            KeyFlagText.BackColor = SystemColors.Control;
            KeyFlagText.BorderStyle = BorderStyle.None;
            KeyFlagText.Location = new Point(xCoordinate + _textBoxSize.Width + _offset, yCoordinate);
            KeyFlagText.Name = "KeyFlagsText";
            KeyFlagText.Size = _textBoxSize;
            KeyFlagText.TabIndex = 14;
            KeyFlagText.Text = "KeyFlags";
            KeyFlagText.TextAlign = HorizontalAlignment.Center;
            KeyFlagText.TabStop = false;
            KeyFlagText.Font = _font;

            xCoordinate = baseLength;

            KeyCodeValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyCodeValue.Name = "KeyCodeValue";
            KeyCodeValue.Size = _textBoxSize;
            KeyCodeValue.TabIndex = 9;
            KeyCodeValue.TextAlign = HorizontalAlignment.Center;
            KeyCodeValue.TabStop = false;
            KeyCodeValue.Font = _font;

            xCoordinate += _textBoxSize.Width + _offset;
            KeyNameValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyNameValue.Name = "KeyNameValue";
            KeyNameValue.Size = _textBoxSize;
            KeyNameValue.TabIndex = 10;
            KeyNameValue.TextAlign = HorizontalAlignment.Center;
            KeyNameValue.TabStop = false;
            KeyNameValue.Font = _font;

            KeyFlagValue.Location = new Point(xCoordinate + _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyFlagValue.Name = "KeyFlagsValue";
            KeyFlagValue.Size = _textBoxSize;
            KeyFlagValue.TabIndex = 11;
            KeyFlagValue.TextAlign = HorizontalAlignment.Center;
            KeyFlagValue.TabStop = false;
            KeyFlagValue.Font = _font;

            xCoordinate = keboardLayoutSize.Width - baseLength;

            xCoordinate -= _buttonSize.Width;
            ExitButton.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = _buttonSize;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.TabStop = false;
            ExitButton.Font = _font;

            xCoordinate -= _buttonSize.Width + _offset;
            ResetButton.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = _buttonSize;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.TabStop = false;
            ResetButton.Font = _font;

            Size = new Size(xCoordinate + baseLength, yCoordinate + _textBoxSize.Height + baseLength);
        }
    }
}