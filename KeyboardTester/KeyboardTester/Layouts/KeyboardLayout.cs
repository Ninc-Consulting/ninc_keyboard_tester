namespace KeyboardTester.Layouts
{
    public class KeyboardLayout
    {
        private Keys _previousKeyDown;
        public Dictionary<int, Key> LayoutKeys { get; private set; } = new Dictionary<int, Key>();
        public Size Size { get; private set; }
        public KeyboardLayoutType KeyboardLayoutType { get; protected set; }
        protected static int BaseKeyWidth { get; private set; }

        public KeyboardLayout(int baseKeyWidth)
        {
            BaseKeyWidth = baseKeyWidth;
        }

        public void KeyEvent(KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;

            // Do nothing if the layout does not contain the key
            if (!LayoutKeys.ContainsKey(e.KeyCode)
                || ((Keys)e.KeyCode == Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag) && !LayoutKeys.ContainsKey(-e.KeyCode)))
            {
                return;
            }

            // Since we can't intercept the NumLock functionality in the webhook, we have to handle each key manually.
            if (NumPadKeyIsPressedWhileNumLockIsOff(e))
            {
                return;
            }

            // The AltGr key triggers two key events.
            // First left control with a flag that indicates that an Alt key is pressed and then right menu (Alt Gr).
            // Do nothing when the event for the left control key is triggered
            if (((Keys)e.KeyCode == Keys.LControlKey && Convert.ToBoolean(e.KeyFlags & altKeyFlag))
                || (e.KeyEventType == KeyEventType.KeyUp && (Keys)e.KeyCode == Keys.LControlKey && _previousKeyDown == Keys.RMenu))
            {
                return;
            }

            var keyCode = e.KeyCode;

            // If the Return/Enter key is pressed, check the extended key flag to distinguish between regular Enter and NumPad Enter
            if ((Keys)e.KeyCode == Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag))
            {
                keyCode *= -1;
            }

            if (e.KeyEventType == KeyEventType.KeyDown)
            {
                // Set the background to purple if the key was pressed
                LayoutKeys[keyCode].BackColor = ColorTranslator.FromHtml("#6c3891");
                LayoutKeys[keyCode].ForeColor = Color.White;
                _previousKeyDown = (Keys)e.KeyCode;
            }
            else
            {
                // Set the border to if the key was released
                LayoutKeys[keyCode].FlatStyle = FlatStyle.Flat;
                LayoutKeys[keyCode].FlatAppearance.BorderSize = Convert.ToInt32(BaseKeyWidth / 20);
                LayoutKeys[keyCode].FlatAppearance.BorderColor = Color.Red;
            }
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

            maxX += BaseKeyWidth;
            maxY += BaseKeyWidth;
            Size = new Size(maxX, maxY);
        }

        private bool NumPadKeyIsPressedWhileNumLockIsOff(KeyboardHookEventArgs e)
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

            // The pressed key is an alternative NumPad key and the extended flag indicates that the NumPad key was pressed.
            // Handle the correct NumPad key
            switch ((Keys)e.KeyCode)
            {
                case Keys.PageUp:
                    LayoutKeys[(int)Keys.NumPad9].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad9].ForeColor = Color.White;
                    break;
                case Keys.Up:
                    LayoutKeys[(int)Keys.NumPad8].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad8].ForeColor = Color.White;
                    break;
                case Keys.Home:
                    LayoutKeys[(int)Keys.NumPad7].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad7].ForeColor = Color.White;
                    break;
                case Keys.Right:
                    LayoutKeys[(int)Keys.NumPad6].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad6].ForeColor = Color.White;
                    break;
                case Keys.Clear:
                    LayoutKeys[(int)Keys.NumPad5].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad5].ForeColor = Color.White;
                    break;
                case Keys.Left:
                    LayoutKeys[(int)Keys.NumPad4].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad4].ForeColor = Color.White;
                    break;
                case Keys.PageDown:
                    LayoutKeys[(int)Keys.NumPad3].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad3].ForeColor = Color.White;
                    break;
                case Keys.Down:
                    LayoutKeys[(int)Keys.NumPad2].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad2].ForeColor = Color.White;
                    break;
                case Keys.End:
                    LayoutKeys[(int)Keys.NumPad1].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad1].ForeColor = Color.White;
                    break;
                case Keys.Insert:
                    LayoutKeys[(int)Keys.NumPad0].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.NumPad0].ForeColor = Color.White;
                    break;
                case Keys.Delete:
                    LayoutKeys[(int)Keys.Decimal].BackColor = ColorTranslator.FromHtml("#6c3891");
                    LayoutKeys[(int)Keys.Decimal].ForeColor = Color.White;
                    break;
            }

            return true;
        }
    }
}