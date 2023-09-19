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

            // TODO: Set the size of the layouts based on the Screen.PrimaryScreen.Bounds

            _keyboardHandler = new(Controls, _margins, KeyboarLayoutEnum.Cherry);
            _textBoxLayout = new(Controls, _keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _margins);
            _textBoxLayout.ResetButton.Click += ResetButton_Click;
            _textBoxLayout.ExitButton.Click += ExitButton_Click;
            ClientSize = GetSize(_keyboardHandler.KeyboardLayout.KeyboardLayoutSize, _textBoxLayout.TextBoxLayoutSize);
            StartPosition = FormStartPosition.Manual;
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - ClientSize.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - ClientSize.Height) / 2);
        }

        private Size GetSize(Size keyboardLayoutSize, Size textBoxLayoutSize)
        {
            return new Size(
                Math.Max(keyboardLayoutSize.Width, textBoxLayoutSize.Width),
                Math.Max(keyboardLayoutSize.Height, textBoxLayoutSize.Height));
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
            KeyPreview = true;
            Name = "KeyboardTesterForm";
            Text = "KeyboardTester";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBoxLayout _textBoxLayout;
        private KeyboardHandler _keyboardHandler;
        private static readonly Margins _margins = new Margins(100, 100, 100, 100);
    }
}