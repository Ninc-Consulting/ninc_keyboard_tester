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
            AddKeyToLayout(KeyResource.Back);
            AddKeyToLayout(KeyResource.Tab);
            AddKeyToLayout(KeyResource.Clear);
            AddKeyToLayout(KeyResource.Return);
            AddKeyToLayout(KeyResource.Enter);
            AddKeyToLayout(KeyResource.Shift);
            AddKeyToLayout(KeyResource.Control);
            AddKeyToLayout(KeyResource.Alt);
            AddKeyToLayout(KeyResource.Pause);
            AddKeyToLayout(KeyResource.CapsLock);
            AddKeyToLayout(KeyResource.KanaMode);
            AddKeyToLayout(KeyResource.JunjaMode);
            AddKeyToLayout(KeyResource.FinalMode);
            AddKeyToLayout(KeyResource.HanjaMode);
            AddKeyToLayout(KeyResource.Escape);
            AddKeyToLayout(KeyResource.ImeConvert);
            AddKeyToLayout(KeyResource.ImeNonConvert);
            AddKeyToLayout(KeyResource.ImeAccept);
            AddKeyToLayout(KeyResource.ImeModeChange);
            KeyResource.Spacebar.Text = "Space";
            AddKeyToLayout(KeyResource.Spacebar);
            AddKeyToLayout(KeyResource.PageUp);
            AddKeyToLayout(KeyResource.PageDown);
            AddKeyToLayout(KeyResource.End);
            AddKeyToLayout(KeyResource.Home);
            AddKeyToLayout(KeyResource.LeftArrow);
            AddKeyToLayout(KeyResource.UpArrow);
            AddKeyToLayout(KeyResource.RightArrow);
            AddKeyToLayout(KeyResource.DownArrow);
            AddKeyToLayout(KeyResource.Select);
            AddKeyToLayout(KeyResource.Print);
            AddKeyToLayout(KeyResource.Execute);
            AddKeyToLayout(KeyResource.PrintScreen);
            AddKeyToLayout(KeyResource.Insert);
            AddKeyToLayout(KeyResource.Delete);
            AddKeyToLayout(KeyResource.Help);
            AddKeyToLayout(KeyResource.D0);
            AddKeyToLayout(KeyResource.D1);
            AddKeyToLayout(KeyResource.D2);
            AddKeyToLayout(KeyResource.D3);
            AddKeyToLayout(KeyResource.D4);
            AddKeyToLayout(KeyResource.D5);
            AddKeyToLayout(KeyResource.D6);
            AddKeyToLayout(KeyResource.D7);
            AddKeyToLayout(KeyResource.D8);
            AddKeyToLayout(KeyResource.D9);
            AddKeyToLayout(KeyResource.A);
            AddKeyToLayout(KeyResource.B);
            AddKeyToLayout(KeyResource.C);
            AddKeyToLayout(KeyResource.D);
            AddKeyToLayout(KeyResource.E);
            AddKeyToLayout(KeyResource.F);
            AddKeyToLayout(KeyResource.G);
            AddKeyToLayout(KeyResource.H);
            AddKeyToLayout(KeyResource.I);
            AddKeyToLayout(KeyResource.J);
            AddKeyToLayout(KeyResource.K);
            AddKeyToLayout(KeyResource.L);
            AddKeyToLayout(KeyResource.M);
            AddKeyToLayout(KeyResource.N);
            AddKeyToLayout(KeyResource.O);
            AddKeyToLayout(KeyResource.P);
            AddKeyToLayout(KeyResource.Q);
            AddKeyToLayout(KeyResource.R);
            AddKeyToLayout(KeyResource.S);
            AddKeyToLayout(KeyResource.T);
            AddKeyToLayout(KeyResource.U);
            AddKeyToLayout(KeyResource.V);
            AddKeyToLayout(KeyResource.W);
            AddKeyToLayout(KeyResource.X);
            AddKeyToLayout(KeyResource.Y);
            AddKeyToLayout(KeyResource.Z);
            AddKeyToLayout(KeyResource.LeftWindows);
            AddKeyToLayout(KeyResource.RightWindows);
            AddKeyToLayout(KeyResource.Applications);
            AddKeyToLayout(KeyResource.Sleep);
            AddKeyToLayout(KeyResource.NumPad0);
            AddKeyToLayout(KeyResource.NumPad1);
            AddKeyToLayout(KeyResource.NumPad2);
            AddKeyToLayout(KeyResource.NumPad3);
            AddKeyToLayout(KeyResource.NumPad4);
            AddKeyToLayout(KeyResource.NumPad5);
            AddKeyToLayout(KeyResource.NumPad6);
            AddKeyToLayout(KeyResource.NumPad7);
            AddKeyToLayout(KeyResource.NumPad8);
            AddKeyToLayout(KeyResource.NumPad9);
            AddKeyToLayout(KeyResource.Multiply);
            AddKeyToLayout(KeyResource.Add);
            AddKeyToLayout(KeyResource.Separator);
            AddKeyToLayout(KeyResource.Subtract);
            AddKeyToLayout(KeyResource.Decimal);
            AddKeyToLayout(KeyResource.Divide);
            AddKeyToLayout(KeyResource.F1);
            AddKeyToLayout(KeyResource.F2);
            AddKeyToLayout(KeyResource.F3);
            AddKeyToLayout(KeyResource.F4);
            AddKeyToLayout(KeyResource.F5);
            AddKeyToLayout(KeyResource.F6);
            AddKeyToLayout(KeyResource.F7);
            AddKeyToLayout(KeyResource.F8);
            AddKeyToLayout(KeyResource.F9);
            AddKeyToLayout(KeyResource.F10);
            AddKeyToLayout(KeyResource.F11);
            AddKeyToLayout(KeyResource.F12);
            AddKeyToLayout(KeyResource.F13);
            AddKeyToLayout(KeyResource.F14);
            AddKeyToLayout(KeyResource.F15);
            AddKeyToLayout(KeyResource.F16);
            AddKeyToLayout(KeyResource.F17);
            AddKeyToLayout(KeyResource.F18);
            AddKeyToLayout(KeyResource.F19);
            AddKeyToLayout(KeyResource.F20);
            AddKeyToLayout(KeyResource.F21);
            AddKeyToLayout(KeyResource.F22);
            AddKeyToLayout(KeyResource.F23);
            AddKeyToLayout(KeyResource.F24);
            AddKeyToLayout(KeyResource.NumLock);
            AddKeyToLayout(KeyResource.ScrollLock);
            AddKeyToLayout(KeyResource.LeftShift);
            AddKeyToLayout(KeyResource.RightShift);
            AddKeyToLayout(KeyResource.LeftControl);
            AddKeyToLayout(KeyResource.RightControl);
            AddKeyToLayout(KeyResource.LeftAlt);
            AddKeyToLayout(KeyResource.RightAlt);
            AddKeyToLayout(KeyResource.BrowserBack);
            AddKeyToLayout(KeyResource.BrowserForward);
            AddKeyToLayout(KeyResource.BrowserRefresh);
            AddKeyToLayout(KeyResource.BrowserStop);
            AddKeyToLayout(KeyResource.BrowserSearch);
            AddKeyToLayout(KeyResource.BrowserFavorites);
            AddKeyToLayout(KeyResource.BrowserHome);
            AddKeyToLayout(KeyResource.VolumeMute);
            AddKeyToLayout(KeyResource.VolumeDown);
            AddKeyToLayout(KeyResource.VolumeUp);
            AddKeyToLayout(KeyResource.MediaNextTrack);
            AddKeyToLayout(KeyResource.MediaPreviousTrack);
            AddKeyToLayout(KeyResource.MediaStop);
            AddKeyToLayout(KeyResource.MediaPlayPause);
            AddKeyToLayout(KeyResource.LaunchMail);
            AddKeyToLayout(KeyResource.SelectMedia);
            AddKeyToLayout(KeyResource.LaunchApplication1);
            AddKeyToLayout(KeyResource.LaunchApplication2);
            AddKeyToLayout(KeyResource.OemPlus);
            AddKeyToLayout(KeyResource.OemComma);
            AddKeyToLayout(KeyResource.OemMinus);
            AddKeyToLayout(KeyResource.OemPeriod);
            AddKeyToLayout(KeyResource.Oem2);
            AddKeyToLayout(KeyResource.OemTilde);
            AddKeyToLayout(KeyResource.Oem4);
            AddKeyToLayout(KeyResource.Oem5);
            AddKeyToLayout(KeyResource.Oem6);
            AddKeyToLayout(KeyResource.Oem7);
            AddKeyToLayout(KeyResource.Oem8);
            AddKeyToLayout(KeyResource.Oem102);
            AddKeyToLayout(KeyResource.ProcessKey);
            AddKeyToLayout(KeyResource.Packet);
            AddKeyToLayout(KeyResource.Attn);
            AddKeyToLayout(KeyResource.Crsel);
            AddKeyToLayout(KeyResource.Exsel);
            AddKeyToLayout(KeyResource.EraseEof);
            AddKeyToLayout(KeyResource.Play);
            AddKeyToLayout(KeyResource.Zoom);
            AddKeyToLayout(KeyResource.Pa1);
            AddKeyToLayout(KeyResource.OemClear);

            foreach (var key in LayoutKeys.Values.ToList())
            {
                key.Size = new Size(BaseKeyWidth, BaseKeyWidth);
                key.TextAlign = ContentAlignment.MiddleCenter;
                key.Show();
            }
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth;
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
                if (columnCounter % 24 == 0)
                {
                    yCoordinate += key.Height + offset;
                    xCoordinate = BaseKeyWidth;
                }
#pragma warning restore S2583 // Conditionally executed code should be reachable
            }
        }
    }
}