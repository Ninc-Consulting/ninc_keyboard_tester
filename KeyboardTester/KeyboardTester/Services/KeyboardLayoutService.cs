namespace KeyboardTester.Services
{
    public class KeyboardLayoutService
    {
        private readonly ToughbookService _toughbookService = new();
        private Keys _previousKeyDown;

        public void KeyEvent(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            var altKeyFlag = 0b100000;
            var extendedKeyFlag = 0b1;

            // Check if the Fn key was used in the Toughbook layout and handle separately if true
            if (keyboardLayout.KeyboardLayoutType == KeyboardLayoutType.Toughbook && _toughbookService.HandleFnKey(keyboardLayout, e))
            {
                return;
            }

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

            if (e.KeyEventType == KeyEventType.KeyDown)
            {
                _previousKeyDown = (Keys)e.KeyCode;
            }

            ChangeKeyColors(keyboardLayout, (Keys)keyCode, e.KeyEventType);
        }

        private bool NumPadKeyIsPressedWhileNumLockIsOff(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            var extendedFlag = 0b1;

            var alternativeNumPadKeyCodes = new Dictionary<Keys, Keys>()
            {
                { Keys.PageUp, Keys.NumPad9 },
                { Keys.Up, Keys.NumPad8 },
                { Keys.Down, Keys.NumPad7 },
                { Keys.Left, Keys.NumPad6 },
                { Keys.Right, Keys.NumPad5 },
                { Keys.Home, Keys.NumPad4 },
                { Keys.PageDown, Keys.NumPad3 },
                { Keys.End, Keys.NumPad2 },
                { Keys.Clear, Keys.NumPad1 },
                { Keys.Insert, Keys.NumPad0 },
                { Keys.Delete, Keys.Decimal }
            };

            // If any of the alternativeNumPadKeyCodes keys are pressed and the extended flag is set,
            // change the color of the NumPad key instead
            if (alternativeNumPadKeyCodes.ContainsKey((Keys)e.KeyCode) && !Convert.ToBoolean(e.KeyFlags & extendedFlag))
            {
                ChangeKeyColors(keyboardLayout, alternativeNumPadKeyCodes[(Keys)e.KeyCode], e.KeyEventType);
                return true;
            }

            return false;
        }

        private void ChangeKeyColors(KeyboardLayout keyboardLayout, Keys keyCodeValue, KeyEventType keyEventType)
        {
            if (keyEventType == KeyEventType.KeyDown)
            {
                // Set the background to purple if the key was pressed
                keyboardLayout.LayoutKeys[(int)keyCodeValue].BackColor = Resources.Colors.NincPurple;
                keyboardLayout.LayoutKeys[(int)keyCodeValue].ForeColor = Resources.Colors.White;
            }
            else
            {
                // Set the border to if the key was released
                keyboardLayout.LayoutKeys[(int)keyCodeValue].FlatStyle = FlatStyle.Flat;
                keyboardLayout.LayoutKeys[(int)keyCodeValue].FlatAppearance.BorderSize = Convert.ToInt32(KeyboardLayout.BaseKeyWidth / 20);
                keyboardLayout.LayoutKeys[(int)keyCodeValue].FlatAppearance.BorderColor = Resources.Colors.Red;
            }
        }
    }
}