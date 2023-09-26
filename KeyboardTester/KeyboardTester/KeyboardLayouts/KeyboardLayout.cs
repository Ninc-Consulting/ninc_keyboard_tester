namespace KeyboardTester.KeyboardLayouts
{
    public class KeyboardLayout
    {
        public Dictionary<int, Key> LayoutKeys { get; } = new Dictionary<int, Key>();

        public Size KeyboardLayoutSize { get; private set; }

        protected static int BaseLength { get; private set; }

        public KeyboardLayout(int baseLength)
        {
            BaseLength = baseLength;
        }

        /// <summary>
        /// Handles the KeyDownEvent and sets the background of the key pressed to purple.
        /// Returns true if the keystroke was handled correctly or false if it was ignored.
        /// </summary>
        /// <param name="e"></param>
        /// <returns>Bool.</returns>
        public bool KeyDownEvent(KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;

            // Display a message to the user if the layout does not contain the pressed key
            if (!LayoutKeys.ContainsKey(e.KeyCode))
            {
                var caption = "Key not found!";
                var message = $"'{e.KeyName} - {e.KeyCode}' was not found in '{GetType().ToString().Split('.')[^1]}'";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // Since we can't intercept the NumLock functionality in the webhook, we have to handle each key manually.
            // Do nothing if NumLock is activated but a NumPad key is pressed
            if (NumPadKeyIsPressedWhileNumLockIsActivated(e))
            {
                return false;
            }

            // The Alt Gr key triggers two key events
            // First left control with a flag that indicates that an Alt key is pressed and then right menu (Alt Gr).
            // Do nothing when the event for the left control key is triggered.
            if (e.KeyCode == (int)Keys.LControlKey && Convert.ToBoolean(e.KeyFlags & altKeyFlag))
            {
                return false;
            }

            var keyCode = e.KeyCode;

            // If the Return/Enter key is pressed, check the extended key flag to distinguish between regular Enter and NumPad Enter
            if (e.KeyCode == (int)Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag))
            {
                keyCode *= -1;
            }

            LayoutKeys[keyCode].BackColor = ColorTranslator.FromHtml("#6c3891");
            LayoutKeys[keyCode].ForeColor = Color.White;
            return true;
        }

        protected void AddKeysToBaseClass(List<Key> keys)
        {
            foreach (var key in keys)
            {
                LayoutKeys.Add(key.KeyValue, key);
            }

            SetCommonAttributes();
            SetKeyboardLayoutSize();
        }

        private static bool NumPadKeyIsPressedWhileNumLockIsActivated(KeyboardHookEventArgs e)
        {
            var extendedKeyFlag = 0b1;
            var alternativeNumPadKeyCodes = new List<int>()
            {
                (int)Keys.Up,
                (int)Keys.Down,
                (int)Keys.Left,
                (int)Keys.Right,
                (int)Keys.Home,
                (int)Keys.PageUp,
                (int)Keys.PageDown,
                (int)Keys.End,
                (int)Keys.Clear,
                (int)Keys.Insert,
                (int)Keys.Delete
            };

            if (!alternativeNumPadKeyCodes.Contains(e.KeyCode))
            {
                // The pressed key is not an alternative NumPad key
                return false;
            }
            else if (Convert.ToBoolean(e.KeyFlags & extendedKeyFlag))
            {
                // The pressed key is an alternative NumPad key but the extended flag indicates that the actual key was pressed
                return false;
            }

            // The pressed key is an alternative NumPad key and the extended flag indicates that the NumPad key was pressed
            return true;
        }

        private void SetCommonAttributes()
        {
            foreach (var key in LayoutKeys.Values)
            {
                key.TabStop = false;
                key.Font = KeyboardTesterForm.ScaledFont;
                key.BackColor = Color.FromArgb(0, 250, 250, 250);
                key.ForeColor = Color.Black;
            }
        }

        private void SetKeyboardLayoutSize()
        {
            var maxX = 0;
            var maxY = 0;

            foreach (var key in LayoutKeys.Values)
            {
                maxX = Math.Max(maxX, key.Location.X + key.Width);
                maxY = Math.Max(maxY, key.Location.Y + key.Height);
            }

            maxX += BaseLength;
            maxY += BaseLength;
            KeyboardLayoutSize = new Size(maxX, maxY);
        }
    }
}
