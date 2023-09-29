namespace KeyboardTester.KeyboardLayouts
{
    public class KeyboardLayout
    {
        public Dictionary<int, Key> LayoutKeys { get; private set; } = new Dictionary<int, Key>();
        public Size Size { get; private set; }
        public KeyboardLayoutType KeyboardLayoutType { get; protected set; }
        protected static int BaseLength { get; private set; }
        protected KeyResource KeyResource { get; private set; } = new KeyResource();

        public KeyboardLayout(int baseLength)
        {
            BaseLength = baseLength;
        }

        public void KeyDownEvent(KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;

            // Display a message to the user if the layout does not contain the pressed key
            if (!LayoutKeys.ContainsKey(e.KeyCode)
                || (e.KeyCode == (int)Keys.Return
                    && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag)
                    && !LayoutKeys.ContainsKey(-e.KeyCode)))
            {
                var caption = "Key not found!";
                var message = $"'{e.KeyName}' was not found in keyboard layout '{KeyboardLayoutType}'.";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Since we can't intercept the NumLock functionality in the webhook, we have to handle each key manually.
            // Do nothing if NumLock is off but a NumPad key is pressed
            if (NumPadKeyIsPressedWhileNumLockIsOff(e))
            {
                return;
            }

            // The Alt Gr key triggers two key events.
            // First left control with a flag that indicates that an Alt key is pressed and then right menu (Alt Gr).
            // Do nothing when the event for the left control key is triggered
            if (e.KeyCode == (int)Keys.LControlKey && Convert.ToBoolean(e.KeyFlags & altKeyFlag))
            {
                return;
            }

            var keyCode = e.KeyCode;

            // If the Return/Enter key is pressed, check the extended key flag to distinguish between regular Enter and NumPad Enter
            if (e.KeyCode == (int)Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag))
            {
                keyCode *= -1;
            }

            LayoutKeys[keyCode].BackColor = ColorTranslator.FromHtml("#6c3891");
            LayoutKeys[keyCode].ForeColor = Color.White;
        }

        protected void AddKeyToLayout(Key key)
        {
            LayoutKeys.Add(key.KeyCodeValue, key);
        }

        protected void SetCommonAttributes()
        {
            foreach (var key in LayoutKeys.Values)
            {
                key.TabStop = false;
                key.Font = KeyboardTesterForm.ScaledFont;
                key.BackColor = Color.FromArgb(0, 250, 250, 250);
                key.ForeColor = Color.Black;
            }
        }

        protected void SetKeyboardLayoutSize()
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
            Size = new Size(maxX, maxY);
        }

        private static bool NumPadKeyIsPressedWhileNumLockIsOff(KeyboardHookEventArgs e)
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
    }
}