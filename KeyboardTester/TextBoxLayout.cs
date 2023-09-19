using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Printing;
using static System.Windows.Forms.Control;

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
        private static int _offset;// = Convert.ToInt32(_baseLength / 2);
        private static Size _textBoxSize;// = new(_baseLength * 3, Convert.ToInt32(_baseLength / 2));
        private static Size _buttonSize;// = new(Convert.ToInt32(_baseLength * 1.5), Convert.ToInt32(_baseLength / 2));
        private static Font? _font;// = new("Segoe UI", Convert.ToInt32(_baseLength * 0.10));

        public TextBoxLayout(ControlCollection controls, Size keboardLayoutSize, int baseLength)
        {
            _baseLength = baseLength;
            _offset = Convert.ToInt32(_baseLength / 2);
            _textBoxSize = new(_baseLength * 3, Convert.ToInt32(_baseLength / 2));
            _buttonSize = new(Convert.ToInt32(_baseLength * 1.5), Convert.ToInt32(_baseLength / 2));
            _font = new("Segoe UI", Convert.ToInt32(_baseLength * 0.10));

            DoLayout(keboardLayoutSize, baseLength);
            AddControls(controls);
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
            KeyCodeText.Name = "KeyCodeText";
            KeyCodeText.Size = _textBoxSize;
            KeyCodeText.TabIndex = 13;
            KeyCodeText.Text = "KeyCode";
            KeyCodeText.TextAlign = HorizontalAlignment.Center;
            KeyCodeText.TabStop = false;
            KeyCodeText.Font = _font;

            KeyDataText.BackColor = SystemColors.Control;
            KeyDataText.BorderStyle = BorderStyle.None;
            KeyDataText.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate);
            KeyDataText.Name = "KeyDataText";
            KeyDataText.Size = _textBoxSize;
            KeyDataText.TabIndex = 14;
            KeyDataText.Text = "KeyData";
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
            KeyCodeValue.Name = "KeyCodeValue";
            KeyCodeValue.Size = _textBoxSize;
            KeyCodeValue.TabIndex = 10;
            KeyCodeValue.TextAlign = HorizontalAlignment.Center;
            KeyCodeValue.TabStop = false;
            KeyCodeValue.Font = _font;

            KeyDataValue.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyDataValue.Name = "KeyDataValue";
            KeyDataValue.Size = _textBoxSize;
            KeyDataValue.TabIndex = 11;
            KeyDataValue.TextAlign = HorizontalAlignment.Center;
            KeyDataValue.TabStop = false;
            KeyDataValue.Font = _font;

            xCoordinate = keboardLayoutSize.Width - baseLength;

            ExitButton.Location = new Point(xCoordinate -= _buttonSize.Width, yCoordinate + _textBoxSize.Height);
            ExitButton.Name = "exitButton";
            ExitButton.Size = _buttonSize;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.TabStop = false;
            ExitButton.Font = _font;

            ResetButton.Location = new Point(xCoordinate -= _buttonSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            ResetButton.Name = "resetButton";
            ResetButton.Size = _buttonSize;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.TabStop = false;
            ResetButton.Font = _font;

            TextBoxLayoutSize = new Size(xCoordinate + baseLength, yCoordinate + _textBoxSize.Height + baseLength);
        }

        private void AddControls(ControlCollection controls)
        {
            controls.Add(KeyValueValue);
            controls.Add(KeyCodeValue);
            controls.Add(KeyDataValue);
            controls.Add(KeyValueText);
            controls.Add(KeyCodeText);
            controls.Add(KeyDataText);
            controls.Add(ResetButton);
            controls.Add(ExitButton);
        }

        public void SetTextBoxValues(KeyEventArgs e)
        {
            KeyValueValue.Text = e.KeyValue.ToString();
            KeyCodeValue.Text = e.KeyCode.ToString();
            KeyDataValue.Text = e.KeyData.ToString();
        }
    }
}
