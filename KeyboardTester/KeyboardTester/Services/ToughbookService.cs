namespace KeyboardTester.Services
{
    public class ToughbookService
    {
        public bool FnKeyIsPressed(KeyboardLayout keyboardLayout, KeyboardHookEventArgs e)
        {
            var volumeKeys = new Dictionary<Keys, Keys>()
            {
                { Keys.VolumeMute, Keys.F4 },
                { Keys.VolumeDown, Keys.F5 },
                { Keys.VolumeUp, Keys.F6 }
            };

            var numLockOffKeys = new Dictionary<Keys, Keys>()
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

            var numLockOnKeys = new Dictionary<Keys, Keys>()
            {
                { Keys.M, Keys.NumPad0 },
                { Keys.J, Keys.NumPad1 },
                { Keys.K, Keys.NumPad2 },
                { Keys.L, Keys.NumPad3 },
                { Keys.U, Keys.NumPad4 },
                { Keys.I, Keys.NumPad5 },
                { Keys.O, Keys.NumPad6 },
                { Keys.D7, Keys.NumPad7 },
                { Keys.D8, Keys.NumPad8 },
                { Keys.D9, Keys.NumPad9 },
                { Keys.OemPeriod, Keys.Decimal },
                { Keys.OemMinus, Keys.Divide },
                { Keys.Oemtilde, Keys.Add },
                { Keys.P, Keys.Subtract },
                { Keys.D0, Keys.Multiply }
            };

            // If any of the volume keys are pressed the Fn key must have been used
            // If any of the numlockOffKeys are pressed when NumLock is on the Fn key must have been used
            // If any of the numlockOnKeys are pressed when NumLock is off the Fn key must have been used
            if (volumeKeys.ContainsKey((Keys)e.KeyCode))
            {
                ChangeKeyColors(keyboardLayout, volumeKeys[(Keys)e.KeyCode], e.KeyEventType);
                return true;
            }
            else if (Control.IsKeyLocked(Keys.NumLock) && numLockOffKeys.ContainsKey((Keys)e.KeyCode))
            {
                ChangeKeyColors(keyboardLayout, numLockOffKeys[(Keys)e.KeyCode], e.KeyEventType);
                return true;
            }
            else if (!Control.IsKeyLocked(Keys.NumLock) && numLockOnKeys.ContainsKey((Keys)e.KeyCode))
            {
                ChangeKeyColors(keyboardLayout, numLockOnKeys[(Keys)e.KeyCode], e.KeyEventType);
                return true;
            }

            return false;
        }

        private void ChangeKeyColors(KeyboardLayout keyboardLayout, Keys keyCode, KeyEventType keyEventType)
        {
            if (keyEventType == KeyEventType.KeyDown)
            {
                // Set the background to purple on the pressed key
                keyboardLayout.LayoutKeys[(int)keyCode].BackColor = ColorTranslator.FromHtml("#6c3891");
                keyboardLayout.LayoutKeys[(int)keyCode].ForeColor = Color.White;

                // Set the background to purple on Fn. Fn has KeyCodeValue = Keys.None = 0
                keyboardLayout.LayoutKeys[0].BackColor = ColorTranslator.FromHtml("#6c3891");
                keyboardLayout.LayoutKeys[0].ForeColor = Color.White;
            }
            else
            {
                // Set the border to red on the pressed key
                keyboardLayout.LayoutKeys[(int)keyCode].FlatStyle = FlatStyle.Flat;
                keyboardLayout.LayoutKeys[(int)keyCode].FlatAppearance.BorderSize = Convert.ToInt32(KeyboardLayout.BaseKeyWidth / 20);
                keyboardLayout.LayoutKeys[(int)keyCode].FlatAppearance.BorderColor = Color.Red;

                // Set the border to red on Fn
                keyboardLayout.LayoutKeys[0].FlatStyle = FlatStyle.Flat;
                keyboardLayout.LayoutKeys[0].FlatAppearance.BorderSize = Convert.ToInt32(KeyboardLayout.BaseKeyWidth / 20);
                keyboardLayout.LayoutKeys[0].FlatAppearance.BorderColor = Color.Red;
            }
        }
    }
}