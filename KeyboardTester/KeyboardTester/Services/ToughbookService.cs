namespace KeyboardTester.Services
{
    public class ToughbookService
    {
        private const int _extendedFlag = 0b1;

        public bool HandleFnKey(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            var onlyFnKeys = new Dictionary<Keys, Keys>()
            {
                { Keys.VolumeMute, Keys.F4 },
                { Keys.VolumeDown, Keys.F5 },
                { Keys.VolumeUp, Keys.F6 },
                { Keys.Clear, Keys.L }
            };

            var extendedFlagFnKeys = new Dictionary<Keys, Keys>()
            {
                { Keys.Insert, Keys.M },
                { Keys.End, Keys.J },
                { Keys.Down, Keys.K },
                { Keys.PageDown, Keys.L },
                { Keys.Right, Keys.O },
                { Keys.Left, Keys.U },
                { Keys.PageUp, Keys.D9 },
                { Keys.Up, Keys.D8 },
                { Keys.Home, Keys.D7 },
                { Keys.Delete, Keys.OemPeriod }
            };

            var numLockKeys = new Dictionary<Keys, Keys>()
            {
                { Keys.NumPad0, Keys.M },
                { Keys.NumPad1, Keys.J },
                { Keys.NumPad2, Keys.K },
                { Keys.NumPad3, Keys.L },
                { Keys.NumPad4, Keys.U },
                { Keys.NumPad5, Keys.I },
                { Keys.NumPad6, Keys.O },
                { Keys.NumPad7, Keys.D7 },
                { Keys.NumPad8, Keys.D8 },
                { Keys.NumPad9, Keys.D9 },
                { Keys.Decimal, Keys.OemPeriod },
                { Keys.Divide, Keys.OemMinus },
                { Keys.Add, Keys.Oemtilde },
                { Keys.Subtract, Keys.P },
                { Keys.Multiply, Keys.D0 }
            };

            var numPadKeys = new List<Keys>()
            {
                Keys.Up,
                Keys.Down,
                Keys.Left,
                Keys.Right,
                Keys.Home,
                Keys.PageUp,
                Keys.PageDown,
                Keys.End,
                Keys.Clear,
                Keys.Insert,
                Keys.Delete
            };

            var allFnKeys = onlyFnKeys.Keys.Concat(extendedFlagFnKeys.Keys).Concat(numLockKeys.Keys);

            // Do nothing if the key is not in the layout
            if (!IsKeyInLayout(allFnKeys, keyboardLayout, e))
            {
                return true;
            }

            if (onlyFnKeys.ContainsKey((Keys)e.KeyCode))
            {
                // If any of the onlyFnKeys keys are pressed
                // or if any of the extendedFlagFnKeys keys are pressed and the extended keyflag is not set,
                // the Fn key must have been used
                ChangeKeyColorsOfKey(keyboardLayout, onlyFnKeys[(Keys)e.KeyCode], e.KeyEventType);
                ChangeKeyColorsOfKey(keyboardLayout, Keys.None, e.KeyEventType); // Fn KeyCode = Keys.None
                return true;
            }
            else if (extendedFlagFnKeys.ContainsKey((Keys)e.KeyCode) && !Convert.ToBoolean(e.KeyFlags & _extendedFlag))
            {
                // If any of the extendedFlagFnKeys keys are pressed and the extended flag is not set,
                // the Fn key must have been used
                ChangeKeyColorsOfKey(keyboardLayout, extendedFlagFnKeys[(Keys)e.KeyCode], e.KeyEventType);
                ChangeKeyColorsOfKey(keyboardLayout, Keys.None, e.KeyEventType); // Fn KeyCode = Keys.None
                return true;
            }
            else if (Control.IsKeyLocked(Keys.NumLock) && numLockKeys.ContainsValue((Keys)e.KeyCode))
            {
                // If NumLock is on and any of the numLockKeys values are pressed,
                // the Fn key must have been used
                ChangeKeyColorsOfKey(keyboardLayout, (Keys)e.KeyCode, e.KeyEventType);
                ChangeKeyColorsOfKey(keyboardLayout, Keys.None, e.KeyEventType); // Fn KeyCode = Keys.None
                return true;
            }
            else if (!Control.IsKeyLocked(Keys.NumLock) && numLockKeys.ContainsKey((Keys)e.KeyCode))
            {
                // If NumLock is off and any of the numLockKeys keys are pressed,
                // the Fn key must have been used
                ChangeKeyColorsOfKey(keyboardLayout, numLockKeys[(Keys)e.KeyCode], e.KeyEventType);
                ChangeKeyColorsOfKey(keyboardLayout, Keys.None, e.KeyEventType); // Fn KeyCode = Keys.None
                return true;
            }
            else if (Control.IsKeyLocked(Keys.NumLock) && numLockKeys.ContainsKey((Keys)e.KeyCode))
            {
                // If NumLock is on and any of the numLockKeys keys are pressed,
                // the Fn key was not used
                ChangeKeyColorsOfKey(keyboardLayout, numLockKeys[(Keys)e.KeyCode], e.KeyEventType);
                return true;
            }
            else if (!Control.IsKeyLocked(Keys.NumLock)
                && (numLockKeys.ContainsValue((Keys)e.KeyCode) || numPadKeys.Contains((Keys)e.KeyCode)))
            {
                // If NumLock is off and
                // any of the numLockKeys values are pressed or if any of the numPadKeys are pressed,
                // the Fn key was not used
                ChangeKeyColorsOfKey(keyboardLayout, (Keys)e.KeyCode, e.KeyEventType);
                return true;
            }

            return false;
        }

        private void ChangeKeyColorsOfKey(KeyboardLayout keyboardLayout, Keys keyCode, KeyEventType keyEventType)
        {
            if (keyEventType == KeyEventType.KeyDown)
            {
                // Set the background to purple on the pressed key
                keyboardLayout.LayoutKeys[(int)keyCode].BackColor = Resources.Colors.NincPurple;
                keyboardLayout.LayoutKeys[(int)keyCode].ForeColor = Resources.Colors.White;
            }
            else
            {
                // Set the border to red on the pressed key
                keyboardLayout.LayoutKeys[(int)keyCode].FlatStyle = FlatStyle.Flat;
                keyboardLayout.LayoutKeys[(int)keyCode].FlatAppearance.BorderSize = Convert.ToInt32(KeyboardLayout.BaseKeyWidth / 20);
                keyboardLayout.LayoutKeys[(int)keyCode].FlatAppearance.BorderColor = Resources.Colors.Red;
            }
        }

        private bool IsKeyInLayout(IEnumerable<Keys> fnKeys, KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            if ((!keyboardLayout.LayoutKeys.ContainsKey(e.KeyCode) && !fnKeys.Contains((Keys)e.KeyCode))
                || ((Keys)e.KeyCode == Keys.Return && Convert.ToBoolean(e.KeyFlags & _extendedFlag) && !keyboardLayout.LayoutKeys.ContainsKey(-e.KeyCode)))
            {
                return false;
            }

            return true;
        }
    }
}