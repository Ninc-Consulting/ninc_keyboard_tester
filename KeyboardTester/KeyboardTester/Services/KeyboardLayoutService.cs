namespace KeyboardTester.Services
{
    public class KeyboardLayoutService
    {
        private readonly ToughbookService _toughbookService = new ToughbookService();
        private Keys _previousKeyDown;

        public void KeyEvent(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;

            // Do nothing if the layout does not contain the key
            // Do nothing if NumPad Enter was pressed and the layout does not contain NumPad Enter
            if (!keyboardLayout.LayoutKeys.ContainsKey(e.KeyCode)
                || ((Keys)e.KeyCode == Keys.Return && Convert.ToBoolean(e.KeyFlags & extendedKeyFlag) && !keyboardLayout.LayoutKeys.ContainsKey(-e.KeyCode)))
            {
                return;
            }

            // Since we can't intercept the NumLock functionality in the webhook, we have to handle each key manually.
            // If all keys are shown, we don't have to handle the key differently
            if (keyboardLayout.KeyboardLayoutType != KeyboardLayoutType.AllKeys && NumPadKeyIsPressedWhileNumLockIsOff(keyboardLayout, e))
            {
                return;
            }

            // The AltGr key triggers two key events,
            // first left control with a flag that indicates that an Alt key is pressed and then right menu (Alt Gr).
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
                // Inverting the KeyCodeValue to distinguish between Return and Enter since they both have the same values in the Keys enumerator
                keyCode *= -1;
            }

            // Check if the Fn key was used in the Toughbook layout
            // Handle separately if true
            if (keyboardLayout.KeyboardLayoutType == KeyboardLayoutType.Toughbook && _toughbookService.FnKeyIsPressed(keyboardLayout, e))
            {
                return;
            }

            if (e.KeyEventType == KeyEventType.KeyDown)
            {
                _previousKeyDown = (Keys)e.KeyCode;
            }

            ChangeKeyColors(keyboardLayout, keyCode, e.KeyEventType);
        }

        private bool NumPadKeyIsPressedWhileNumLockIsOff(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
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
            else if (Control.IsKeyLocked(Keys.NumLock))
            {
                // The pressed key is an alternative NumPad key but NumLock is turned off
                return false;
            }

            // The pressed key is an alternative NumPad key and NumLock is turned on
            // Handle the correct NumPad key
            switch ((Keys)e.KeyCode)
            {
                case Keys.PageUp:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad9, e.KeyEventType);
                    break;
                case Keys.Up:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad8, e.KeyEventType);
                    break;
                case Keys.Home:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad7, e.KeyEventType);
                    break;
                case Keys.Right:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad6, e.KeyEventType);
                    break;
                case Keys.Clear:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad5, e.KeyEventType);
                    break;
                case Keys.Left:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad4, e.KeyEventType);
                    break;
                case Keys.PageDown:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad3, e.KeyEventType);
                    break;
                case Keys.Down:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad2, e.KeyEventType);
                    break;
                case Keys.End:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad1, e.KeyEventType);
                    break;
                case Keys.Insert:
                    ChangeKeyColors(keyboardLayout, (int)Keys.NumPad0, e.KeyEventType);
                    break;
                case Keys.Delete:
                    ChangeKeyColors(keyboardLayout, (int)Keys.Decimal, e.KeyEventType);
                    break;
                default:
                    return false;
            }

            return true;
        }

        private void ChangeKeyColors(KeyboardLayout keyboardLayout, int keyCodeValue, KeyEventType keyEventType)
        {
            if (keyEventType == KeyEventType.KeyDown)
            {
                // Set the background to purple if the key was pressed
                keyboardLayout.LayoutKeys[keyCodeValue].BackColor = ColorTranslator.FromHtml("#6c3891");
                keyboardLayout.LayoutKeys[keyCodeValue].ForeColor = Color.White;
            }
            else
            {
                // Set the border to if the key was released
                keyboardLayout.LayoutKeys[keyCodeValue].FlatStyle = FlatStyle.Flat;
                keyboardLayout.LayoutKeys[keyCodeValue].FlatAppearance.BorderSize = Convert.ToInt32(KeyboardLayout.BaseKeyWidth / 20);
                keyboardLayout.LayoutKeys[keyCodeValue].FlatAppearance.BorderColor = Color.Red;
            }
        }
    }
}