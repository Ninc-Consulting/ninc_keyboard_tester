namespace KeyboardTesterApp.Models
{
    public class InformationArea
    {
        public Button KeyDownButtonExample { get; private set; } = new();
        public Button KeyUpButtonExample { get; private set; } = new();
        public TextBox KeyCodeText { get; private set; } = new();
        public TextBox KeyNameText { get; private set; } = new();
        public TextBox KeyFlagsText { get; private set; } = new();
        public TextBox KeyCodeValue { get; private set; } = new();
        public TextBox KeyNameValue { get; private set; } = new();
        public TextBox KeyFlagsValue { get; private set; } = new();
        public Button ResetButton { get; private set; } = new();
        public Button ExitButton { get; private set; } = new();
        public Size Size { get; private set; } = new();

        public Point Location { get; private set; }

        private readonly int _offset;
        private readonly Size _textBoxSize;
        private readonly Size _buttonSize;
        private readonly Font? _font;

        public InformationArea(KeyboardLayout keyboardLayout, int baseKeyWidth)
        {
            _offset = Convert.ToInt32(baseKeyWidth / 2);
            _textBoxSize = new(baseKeyWidth * 3, Convert.ToInt32(baseKeyWidth / 2));
            _buttonSize = new(Convert.ToInt32(baseKeyWidth * 1.5), Convert.ToInt32(baseKeyWidth / 2));
            _font = KeyboardTesterForm.ScaledFont;

            DoLayout(keyboardLayout, baseKeyWidth);
        }

        private void DoLayout(KeyboardLayout keyboardLayout, int baseKeyWidth)
        {
            var startingYPosition = keyboardLayout.Location.Y + keyboardLayout.Size.Height;
            var yCoordinate = startingYPosition + (baseKeyWidth / 2);
            var xCoordinate = baseKeyWidth / 2;

            KeyDownButtonExample.BackColor = Resources.Colors.NincPurple;
            KeyDownButtonExample.ForeColor = Resources.Colors.White;
            KeyDownButtonExample.Location = new Point(xCoordinate, yCoordinate);
            KeyDownButtonExample.Name = "KeyDownButtonExample";
            KeyDownButtonExample.Size = new Size(baseKeyWidth, baseKeyWidth);
            KeyDownButtonExample.Text = "Key Down";
            KeyDownButtonExample.TabStop = false;
            KeyDownButtonExample.Font = _font;

            xCoordinate += KeyDownButtonExample.Width + _offset;
            KeyUpButtonExample.FlatStyle = FlatStyle.Flat;
            KeyUpButtonExample.FlatAppearance.BorderSize = Convert.ToInt32(baseKeyWidth / 20);
            KeyUpButtonExample.FlatAppearance.BorderColor = Resources.Colors.Red;
            KeyUpButtonExample.BackColor = Resources.Colors.DefaultKeyBackground;
            KeyUpButtonExample.Location = new Point(xCoordinate, yCoordinate);
            KeyUpButtonExample.Name = "KeyUpButtonExample";
            KeyUpButtonExample.Size = new Size(baseKeyWidth, baseKeyWidth);
            KeyUpButtonExample.Text = "Key Up";
            KeyUpButtonExample.TabStop = false;
            KeyUpButtonExample.Font = _font;

            xCoordinate = baseKeyWidth / 2;
            yCoordinate += baseKeyWidth + _offset;

            KeyCodeText.BackColor = Resources.Colors.DefaultControlBackground;
            KeyCodeText.BorderStyle = BorderStyle.None;
            KeyCodeText.Location = new Point(xCoordinate, yCoordinate);
            KeyCodeText.Name = "KeyCodeText";
            KeyCodeText.Size = _textBoxSize;
            KeyCodeText.Text = "KeyCode";
            KeyCodeText.TextAlign = HorizontalAlignment.Center;
            KeyCodeText.TabStop = false;
            KeyCodeText.Font = _font;

            xCoordinate += _textBoxSize.Width + _offset;
            KeyNameText.BackColor = Resources.Colors.DefaultControlBackground;
            KeyNameText.BorderStyle = BorderStyle.None;
            KeyNameText.Location = new Point(xCoordinate, yCoordinate);
            KeyNameText.Name = "KeyNameText";
            KeyNameText.Size = _textBoxSize;
            KeyNameText.Text = "KeyName";
            KeyNameText.TextAlign = HorizontalAlignment.Center;
            KeyNameText.TabStop = false;
            KeyNameText.Font = _font;

            KeyFlagsText.BackColor = Resources.Colors.DefaultControlBackground;
            KeyFlagsText.BorderStyle = BorderStyle.None;
            KeyFlagsText.Location = new Point(xCoordinate + _textBoxSize.Width + _offset, yCoordinate);
            KeyFlagsText.Name = "KeyFlagsText";
            KeyFlagsText.Size = _textBoxSize;
            KeyFlagsText.Text = "KeyFlags";
            KeyFlagsText.TextAlign = HorizontalAlignment.Center;
            KeyFlagsText.TabStop = false;
            KeyFlagsText.Font = _font;

            xCoordinate = baseKeyWidth / 2;

            KeyCodeValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyCodeValue.Name = "KeyCodeValue";
            KeyCodeValue.Size = _textBoxSize;
            KeyCodeValue.TextAlign = HorizontalAlignment.Center;
            KeyCodeValue.TabStop = false;
            KeyCodeValue.Font = _font;

            xCoordinate += _textBoxSize.Width + _offset;
            KeyNameValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyNameValue.Name = "KeyNameValue";
            KeyNameValue.Size = _textBoxSize;
            KeyNameValue.TextAlign = HorizontalAlignment.Center;
            KeyNameValue.TabStop = false;
            KeyNameValue.Font = _font;

            KeyFlagsValue.Location = new Point(xCoordinate + _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyFlagsValue.Name = "KeyFlagsValue";
            KeyFlagsValue.Size = _textBoxSize;
            KeyFlagsValue.TextAlign = HorizontalAlignment.Center;
            KeyFlagsValue.TabStop = false;
            KeyFlagsValue.Font = _font;

            xCoordinate = keyboardLayout.Size.Width - (baseKeyWidth / 2);

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

            Size = new Size(xCoordinate + (baseKeyWidth / 2), yCoordinate + _textBoxSize.Height + baseKeyWidth - (keyboardLayout.Location.Y + keyboardLayout.Size.Height));
            Location = new Point(0, startingYPosition);
        }
    }
}