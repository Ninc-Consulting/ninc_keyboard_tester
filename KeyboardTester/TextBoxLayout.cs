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

        private static readonly Size _textBoxSize = new(300, 50);
        private static readonly Size _buttonSize = new(150, 50);
        private static readonly int _offset = 50;

        public TextBoxLayout(ControlCollection controls, Size keboardLayoutSize, Margins margins)
        {
            DoLayout(keboardLayoutSize, margins);
            AddControls(controls);
        }

        private void DoLayout(Size keboardLayoutSize, Margins margins)
        {
            var yCoordinate = keboardLayoutSize.Height + 200;
            var xCoordinate = margins.Left;

            KeyValueText.BackColor = SystemColors.Control;
            KeyValueText.BorderStyle = BorderStyle.None;
            KeyValueText.Location = new Point(xCoordinate, yCoordinate);
            KeyValueText.Name = "KeyValueText";
            KeyValueText.Size = _textBoxSize;
            KeyValueText.TabIndex = 12;
            KeyValueText.Text = "KeyValue";
            KeyValueText.TextAlign = HorizontalAlignment.Center;
            KeyValueText.TabStop = false;

            KeyCodeText.BackColor = SystemColors.Control;
            KeyCodeText.BorderStyle = BorderStyle.None;
            KeyCodeText.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate);
            KeyCodeText.Name = "KeyCodeText";
            KeyCodeText.Size = _textBoxSize;
            KeyCodeText.TabIndex = 13;
            KeyCodeText.Text = "KeyCode";
            KeyCodeText.TextAlign = HorizontalAlignment.Center;
            KeyCodeText.TabStop = false;

            KeyDataText.BackColor = SystemColors.Control;
            KeyDataText.BorderStyle = BorderStyle.None;
            KeyDataText.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate);
            KeyDataText.Name = "KeyDataText";
            KeyDataText.Size = _textBoxSize;
            KeyDataText.TabIndex = 14;
            KeyDataText.Text = "KeyData";
            KeyDataText.TextAlign = HorizontalAlignment.Center;
            KeyDataText.TabStop = false;

            xCoordinate = margins.Left;

            KeyValueValue.Location = new Point(xCoordinate, yCoordinate + _textBoxSize.Height);
            KeyValueValue.Name = "KeyValueValue";
            KeyValueValue.Size = _textBoxSize;
            KeyValueValue.TabIndex = 9;
            KeyValueValue.TextAlign = HorizontalAlignment.Center;
            KeyValueValue.TabStop = false;

            KeyCodeValue.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyCodeValue.Name = "KeyCodeValue";
            KeyCodeValue.Size = _textBoxSize;
            KeyCodeValue.TabIndex = 10;
            KeyCodeValue.TextAlign = HorizontalAlignment.Center;
            KeyCodeValue.TabStop = false;

            KeyDataValue.Location = new Point(xCoordinate += _textBoxSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            KeyDataValue.Name = "KeyDataValue";
            KeyDataValue.Size = _textBoxSize;
            KeyDataValue.TabIndex = 11;
            KeyDataValue.TextAlign = HorizontalAlignment.Center;
            KeyDataValue.TabStop = false;

            xCoordinate = keboardLayoutSize.Width - margins.Right;

            ExitButton.Location = new Point(xCoordinate -= _buttonSize.Width, yCoordinate + _textBoxSize.Height);
            ExitButton.Name = "exitButton";
            ExitButton.Size = _buttonSize;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.TabStop = false;

            ResetButton.Location = new Point(xCoordinate -= _buttonSize.Width + _offset, yCoordinate + _textBoxSize.Height);
            ResetButton.Name = "resetButton";
            ResetButton.Size = _buttonSize;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.TabStop = false;

            TextBoxLayoutSize = new Size(xCoordinate + margins.Right, yCoordinate + _textBoxSize.Height + margins.Bottom);
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
