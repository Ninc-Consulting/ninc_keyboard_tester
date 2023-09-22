namespace KeyboardTester
{
    internal class TextBoxLayout
    {
        public TextBox KeyValueText = new();
        public TextBox KeyCodeText = new();
        public TextBox KeyDataText = new();
        public TextBox KeyValueValue = new();
        public TextBox KeyCodeValue = new();
        public TextBox KeyDataValue = new();
        public Button ResetButton = new();
        public Button ExitButton = new();

        public Size TextBoxLayoutSize;

        private static int _baseLength;
        private static int _offset;
        private static Size _textBoxSize;
        private static Size _buttonSize;
        private static Font? _font;

        public TextBoxLayout(Size keboardLayoutSize, int baseLength)
        {
            _baseLength = baseLength;
            _offset = Convert.ToInt32(_baseLength / 2);
            _textBoxSize = new(_baseLength * 3, Convert.ToInt32(_baseLength / 2));
            _buttonSize = new(Convert.ToInt32(_baseLength * 1.5), Convert.ToInt32(_baseLength / 2));
            _font = new("Segoe UI", Convert.ToInt32(_baseLength * 0.14));

            DoLayout(keboardLayoutSize, baseLength);
        }

        private void DoLayout(Size keboardLayoutSize, int baseLength)
        {
            var yCoordinate = keboardLayoutSize.Height + baseLength;
            var xCoordinate = baseLength;

            KeyValueText.BackColor = SystemColors.Control;
            KeyValueText.BorderStyle = BorderStyle.None;
            KeyValueText.Location = new Point(xCoordinate, yCoordinate);
            KeyValueText.Name = "KeyValueText";
            KeyValueText.Size = _textBoxSize;
            KeyValueText.TabIndex = 12;
            KeyValueText.Text = "KeyValue";
            KeyValueText.TextAlign = HorizontalAlignment.Center;
            KeyValueText.TabStop = false;
            KeyValueText.Font = _font;

            KeyCodeText.BackColor = SystemColors.Control;
            KeyCodeText.BorderStyle = BorderStyle.None;
            KeyCodeText.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate);
            KeyCodeText.Name = "KeyNameText";
            KeyCodeText.Size = _textBoxSize;
            KeyCodeText.TabIndex = 13;
            KeyCodeText.Text = "KeyName";
            KeyCodeText.TextAlign = HorizontalAlignment.Center;
            KeyCodeText.TabStop = false;
            KeyCodeText.Font = _font;

            KeyDataText.BackColor = SystemColors.Control;
            KeyDataText.BorderStyle = BorderStyle.None;
            KeyDataText.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate);
            KeyDataText.Name = "KeyFlagsText";
            KeyDataText.Size = _textBoxSize;
            KeyDataText.TabIndex = 14;
            KeyDataText.Text = "KeyFlags";
            KeyDataText.TextAlign = HorizontalAlignment.Center;
            KeyDataText.TabStop = false;
            KeyDataText.Font = _font;

            xCoordinate = baseLength;

            KeyValueValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyValueValue.Name = "KeyValueValue";
            KeyValueValue.Size = _textBoxSize;
            KeyValueValue.TabIndex = 9;
            KeyValueValue.TextAlign = HorizontalAlignment.Center;
            KeyValueValue.TabStop = false;
            KeyValueValue.Font = _font;

            KeyCodeValue.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyCodeValue.Name = "KeyNameValue";
            KeyCodeValue.Size = _textBoxSize;
            KeyCodeValue.TabIndex = 10;
            KeyCodeValue.TextAlign = HorizontalAlignment.Center;
            KeyCodeValue.TabStop = false;
            KeyCodeValue.Font = _font;

            KeyDataValue.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyDataValue.Name = "KeyFlagsValue";
            KeyDataValue.Size = _textBoxSize;
            KeyDataValue.TabIndex = 11;
            KeyDataValue.TextAlign = HorizontalAlignment.Center;
            KeyDataValue.TabStop = false;
            KeyDataValue.Font = _font;

            xCoordinate = keboardLayoutSize.Width - baseLength;

            ExitButton.Location = new Point(xCoordinate -= _buttonSize.Width, yCoordinate + _textBoxSize.Height);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = _buttonSize;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.TabStop = false;
            ExitButton.Font = _font;

            ResetButton.Location = new Point(xCoordinate -= _buttonSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = _buttonSize;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.TabStop = false;
            ResetButton.Font = _font;

            TextBoxLayoutSize = new Size(xCoordinate + baseLength, yCoordinate + _textBoxSize.Height + baseLength);
        }

        public void SetTextBoxValues(KeyboardHook.KeyboardHookEventArgs e)
        {
            KeyValueValue.Text = e.KeyCode.ToString();
            KeyCodeValue.Text = e.KeyName.ToString();
            KeyDataValue.Text = Convert.ToString(e.KeyFlags, 2).PadLeft(8, '0');
        }
    }
}
