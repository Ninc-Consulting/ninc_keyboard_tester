namespace KeyboardTester.Models.KeyboardLayouts
{
    public class AllKeysLayout : KeyboardLayout
    {
        public AllKeysLayout(int baseKeyWidth)
           : base(baseKeyWidth)
        {
            KeyboardLayoutType = KeyboardLayoutType.AllKeys;
            InitiateKeys();
            SetCommonAttributes();
            DoLayout();
            SetKeyboardLayoutSize();
        }

        private void InitiateKeys()
        {
            AddKeyToLayout(Resources.Keys.Back);
            AddKeyToLayout(Resources.Keys.Tab);
            AddKeyToLayout(Resources.Keys.Clear);
            AddKeyToLayout(Resources.Keys.Return);
            AddKeyToLayout(Resources.Keys.Enter);
            AddKeyToLayout(Resources.Keys.Shift);
            AddKeyToLayout(Resources.Keys.Control);
            AddKeyToLayout(Resources.Keys.Alt);
            AddKeyToLayout(Resources.Keys.Pause);
            AddKeyToLayout(Resources.Keys.CapsLock);
            AddKeyToLayout(Resources.Keys.KanaMode);
            AddKeyToLayout(Resources.Keys.JunjaMode);
            AddKeyToLayout(Resources.Keys.FinalMode);
            AddKeyToLayout(Resources.Keys.HanjaMode);
            AddKeyToLayout(Resources.Keys.Escape);
            AddKeyToLayout(Resources.Keys.ImeConvert);
            AddKeyToLayout(Resources.Keys.ImeNonConvert);
            AddKeyToLayout(Resources.Keys.ImeAccept);
            AddKeyToLayout(Resources.Keys.ImeModeChange);
            Resources.Keys.Spacebar.Text = "Space";
            AddKeyToLayout(Resources.Keys.Spacebar);
            AddKeyToLayout(Resources.Keys.PageUp);
            AddKeyToLayout(Resources.Keys.PageDown);
            AddKeyToLayout(Resources.Keys.End);
            AddKeyToLayout(Resources.Keys.Home);
            AddKeyToLayout(Resources.Keys.LeftArrow);
            AddKeyToLayout(Resources.Keys.UpArrow);
            AddKeyToLayout(Resources.Keys.RightArrow);
            AddKeyToLayout(Resources.Keys.DownArrow);
            AddKeyToLayout(Resources.Keys.Select);
            AddKeyToLayout(Resources.Keys.Print);
            AddKeyToLayout(Resources.Keys.Execute);
            AddKeyToLayout(Resources.Keys.PrintScreen);
            AddKeyToLayout(Resources.Keys.Insert);
            AddKeyToLayout(Resources.Keys.Delete);
            AddKeyToLayout(Resources.Keys.Help);
            AddKeyToLayout(Resources.Keys.D0);
            AddKeyToLayout(Resources.Keys.D1);
            AddKeyToLayout(Resources.Keys.D2);
            AddKeyToLayout(Resources.Keys.D3);
            AddKeyToLayout(Resources.Keys.D4);
            AddKeyToLayout(Resources.Keys.D5);
            AddKeyToLayout(Resources.Keys.D6);
            AddKeyToLayout(Resources.Keys.D7);
            AddKeyToLayout(Resources.Keys.D8);
            AddKeyToLayout(Resources.Keys.D9);
            AddKeyToLayout(Resources.Keys.A);
            AddKeyToLayout(Resources.Keys.B);
            AddKeyToLayout(Resources.Keys.C);
            AddKeyToLayout(Resources.Keys.D);
            AddKeyToLayout(Resources.Keys.E);
            AddKeyToLayout(Resources.Keys.F);
            AddKeyToLayout(Resources.Keys.G);
            AddKeyToLayout(Resources.Keys.H);
            AddKeyToLayout(Resources.Keys.I);
            AddKeyToLayout(Resources.Keys.J);
            AddKeyToLayout(Resources.Keys.K);
            AddKeyToLayout(Resources.Keys.L);
            AddKeyToLayout(Resources.Keys.M);
            AddKeyToLayout(Resources.Keys.N);
            AddKeyToLayout(Resources.Keys.O);
            AddKeyToLayout(Resources.Keys.P);
            AddKeyToLayout(Resources.Keys.Q);
            AddKeyToLayout(Resources.Keys.R);
            AddKeyToLayout(Resources.Keys.S);
            AddKeyToLayout(Resources.Keys.T);
            AddKeyToLayout(Resources.Keys.U);
            AddKeyToLayout(Resources.Keys.V);
            AddKeyToLayout(Resources.Keys.W);
            AddKeyToLayout(Resources.Keys.X);
            AddKeyToLayout(Resources.Keys.Y);
            AddKeyToLayout(Resources.Keys.Z);
            AddKeyToLayout(Resources.Keys.LeftWindows);
            AddKeyToLayout(Resources.Keys.RightWindows);
            AddKeyToLayout(Resources.Keys.Applications);
            AddKeyToLayout(Resources.Keys.Sleep);
            AddKeyToLayout(Resources.Keys.NumPad0);
            AddKeyToLayout(Resources.Keys.NumPad1);
            AddKeyToLayout(Resources.Keys.NumPad2);
            AddKeyToLayout(Resources.Keys.NumPad3);
            AddKeyToLayout(Resources.Keys.NumPad4);
            AddKeyToLayout(Resources.Keys.NumPad5);
            AddKeyToLayout(Resources.Keys.NumPad6);
            AddKeyToLayout(Resources.Keys.NumPad7);
            AddKeyToLayout(Resources.Keys.NumPad8);
            AddKeyToLayout(Resources.Keys.NumPad9);
            AddKeyToLayout(Resources.Keys.Multiply);
            AddKeyToLayout(Resources.Keys.Add);
            AddKeyToLayout(Resources.Keys.Separator);
            AddKeyToLayout(Resources.Keys.Subtract);
            AddKeyToLayout(Resources.Keys.Decimal);
            AddKeyToLayout(Resources.Keys.Divide);
            AddKeyToLayout(Resources.Keys.F1);
            AddKeyToLayout(Resources.Keys.F2);
            AddKeyToLayout(Resources.Keys.F3);
            AddKeyToLayout(Resources.Keys.F4);
            AddKeyToLayout(Resources.Keys.F5);
            AddKeyToLayout(Resources.Keys.F6);
            AddKeyToLayout(Resources.Keys.F7);
            AddKeyToLayout(Resources.Keys.F8);
            AddKeyToLayout(Resources.Keys.F9);
            AddKeyToLayout(Resources.Keys.F10);
            AddKeyToLayout(Resources.Keys.F11);
            AddKeyToLayout(Resources.Keys.F12);
            AddKeyToLayout(Resources.Keys.F13);
            AddKeyToLayout(Resources.Keys.F14);
            AddKeyToLayout(Resources.Keys.F15);
            AddKeyToLayout(Resources.Keys.F16);
            AddKeyToLayout(Resources.Keys.F17);
            AddKeyToLayout(Resources.Keys.F18);
            AddKeyToLayout(Resources.Keys.F19);
            AddKeyToLayout(Resources.Keys.F20);
            AddKeyToLayout(Resources.Keys.F21);
            AddKeyToLayout(Resources.Keys.F22);
            AddKeyToLayout(Resources.Keys.F23);
            AddKeyToLayout(Resources.Keys.F24);
            AddKeyToLayout(Resources.Keys.NumLock);
            AddKeyToLayout(Resources.Keys.ScrollLock);
            AddKeyToLayout(Resources.Keys.LeftShift);
            AddKeyToLayout(Resources.Keys.RightShift);
            AddKeyToLayout(Resources.Keys.LeftControl);
            AddKeyToLayout(Resources.Keys.RightControl);
            AddKeyToLayout(Resources.Keys.LeftAlt);
            AddKeyToLayout(Resources.Keys.RightAlt);
            AddKeyToLayout(Resources.Keys.BrowserBack);
            AddKeyToLayout(Resources.Keys.BrowserForward);
            AddKeyToLayout(Resources.Keys.BrowserRefresh);
            AddKeyToLayout(Resources.Keys.BrowserStop);
            AddKeyToLayout(Resources.Keys.BrowserSearch);
            AddKeyToLayout(Resources.Keys.BrowserFavorites);
            AddKeyToLayout(Resources.Keys.BrowserHome);
            AddKeyToLayout(Resources.Keys.VolumeMute);
            AddKeyToLayout(Resources.Keys.VolumeDown);
            AddKeyToLayout(Resources.Keys.VolumeUp);
            AddKeyToLayout(Resources.Keys.MediaNextTrack);
            AddKeyToLayout(Resources.Keys.MediaPreviousTrack);
            AddKeyToLayout(Resources.Keys.MediaStop);
            AddKeyToLayout(Resources.Keys.MediaPlayPause);
            AddKeyToLayout(Resources.Keys.LaunchMail);
            AddKeyToLayout(Resources.Keys.SelectMedia);
            AddKeyToLayout(Resources.Keys.LaunchApplication1);
            AddKeyToLayout(Resources.Keys.LaunchApplication2);
            AddKeyToLayout(Resources.Keys.OemPlus);
            AddKeyToLayout(Resources.Keys.OemComma);
            AddKeyToLayout(Resources.Keys.OemMinus);
            AddKeyToLayout(Resources.Keys.OemPeriod);
            AddKeyToLayout(Resources.Keys.Oem2);
            AddKeyToLayout(Resources.Keys.OemTilde);
            AddKeyToLayout(Resources.Keys.Oem4);
            AddKeyToLayout(Resources.Keys.Oem5);
            AddKeyToLayout(Resources.Keys.Oem6);
            AddKeyToLayout(Resources.Keys.Oem7);
            AddKeyToLayout(Resources.Keys.Oem8);
            AddKeyToLayout(Resources.Keys.Oem102);
            AddKeyToLayout(Resources.Keys.ProcessKey);
            AddKeyToLayout(Resources.Keys.Packet);
            AddKeyToLayout(Resources.Keys.Attn);
            AddKeyToLayout(Resources.Keys.Crsel);
            AddKeyToLayout(Resources.Keys.Exsel);
            AddKeyToLayout(Resources.Keys.EraseEof);
            AddKeyToLayout(Resources.Keys.Play);
            AddKeyToLayout(Resources.Keys.Zoom);
            AddKeyToLayout(Resources.Keys.Pa1);
            AddKeyToLayout(Resources.Keys.OemClear);

            foreach (var key in LayoutKeys.Values.ToList())
            {
                key.Size = new Size(BaseKeyWidth, BaseKeyWidth);
                key.TextAlign = ContentAlignment.MiddleCenter;
                key.Show();
            }
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth / 2;
            var yCoordinate = BaseKeyWidth;
            var offset = Convert.ToInt32(BaseKeyWidth * 0.05);
            var columnCounter = 0;

            foreach (var key in LayoutKeys.Values.ToList())
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + offset;
                columnCounter++;

                // Disable rule since sonar incorrectly thinks that the statement is always false https://github.com/SonarSource/sonar-dotnet/issues/8108
#pragma warning disable S2583 // Conditionally executed code should be reachable
                if (columnCounter % 22 == 0)
                {
                    yCoordinate += key.Height + offset;
                    xCoordinate = BaseKeyWidth / 2;
                }
#pragma warning restore S2583 // Conditionally executed code should be reachable
            }
        }
    }
}