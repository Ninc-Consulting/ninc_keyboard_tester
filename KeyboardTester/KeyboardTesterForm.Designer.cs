using System.Drawing.Printing;

namespace KeyboardTester
{
    partial class KeyboardTesterForm
    {
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

        private void CustomInitializeComponent()
        {
            // TODO: Create drop-down so user can switch keyboard layouts
            _keyboardHandler = new(Controls, _margins, KeyboarLayoutEnum.Cherry);
            _textBoxLayout = new(Controls, _keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _margins);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
        }

        private Size GetSize(Size keyboardLayoutSize, Size textBoxLayoutSize)
        {
            var resultWidth = 0;
            var resultHeight = 0;

            if (keyboardLayoutSize.Width > textBoxLayoutSize.Width)
            {
                resultWidth = keyboardLayoutSize.Width;
            }
            else
            {
                resultWidth = textBoxLayoutSize.Width;
            }

            if (keyboardLayoutSize.Height > textBoxLayoutSize.Height)
            {
                resultHeight = keyboardLayoutSize.Height;
            }
            else
            {
                resultHeight = textBoxLayoutSize.Height;
            }

            return new Size(resultWidth, resultHeight);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = GetSize(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            KeyPreview = true;
            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - ClientSize.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ClientSize.Height) / 3);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBoxLayout _textBoxLayout;
        private KeyboardHandler _keyboardHandler;
        private static readonly Margins _margins = new Margins(100, 100, 100, 100);
    }
}