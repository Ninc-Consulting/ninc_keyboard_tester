namespace KeyboardTester.Models.KeyboardLayouts
{
    public class ToughbookKeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseKeyWidth * 0.05);

        private static readonly Size _squareSize = new(BaseKeyWidth, BaseKeyWidth);
        private static readonly Size _squareSize0_8 = new(Convert.ToInt32(BaseKeyWidth * 0.8), Convert.ToInt32(BaseKeyWidth * 0.8));
        private static readonly Size _squareSize0_85 = new(Convert.ToInt32(BaseKeyWidth * 0.85), Convert.ToInt32(BaseKeyWidth * 0.85));
        private static readonly Size _rectangleSize0_75 = new(Convert.ToInt32(BaseKeyWidth * 0.75), BaseKeyWidth);
        private static readonly Size _rectangleSize0_9 = new(Convert.ToInt32(BaseKeyWidth * 0.9), BaseKeyWidth);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseKeyWidth * 1.25) + (_offset / 4), BaseKeyWidth);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseKeyWidth * 1.5) + (_offset / 2), BaseKeyWidth);
        private static readonly Size _rectangleSize2 = new((BaseKeyWidth * 2) + _offset, BaseKeyWidth);
        private static readonly Size _spaceBarSize = new(Convert.ToInt32(BaseKeyWidth * 3.5) + Convert.ToInt32(_offset * 2.5), BaseKeyWidth);

        // There is no KeyCodeValue for Fn button since it doesn't trigger any static Key event.
        // Fn only alters the values of other keys when they are pressed. Adding dummy button for the GUI
        public Key Fn { get; set; } = new();

        public ToughbookKeyboardLayout(int baseKeyWidth)
            : base(baseKeyWidth)
        {
            KeyboardLayoutType = KeyboardLayoutType.Toughbook;
            InitiateKeys();
            SetCommonAttributes();
            DoLayout();
            SetKeyboardLayoutSize();
        }

        private void InitiateKeys()
        {
            KeyResource.Escape.Size = _squareSize0_85;
            KeyResource.Escape.Text = "ESC";
            KeyResource.Escape.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Escape);

            KeyResource.F1.Size = _squareSize0_85;
            KeyResource.F1.Text = "F1\n▼☼";
            KeyResource.F1.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F1);

            KeyResource.F2.Size = _squareSize0_85;
            KeyResource.F2.Text = "F2\n▲☼";
            KeyResource.F2.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F2);

            KeyResource.F3.Size = _squareSize0_85;
            KeyResource.F3.Text = "F3\n▢/▣";
            KeyResource.F3.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F3);

            KeyResource.F4.Size = _squareSize0_85;
            KeyResource.F4.Text = "F4\n🔇";
            KeyResource.F4.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F4);

            KeyResource.F5.Size = _squareSize0_85;
            KeyResource.F5.Text = "F5\n▼🔊";
            KeyResource.F5.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F5);

            KeyResource.F6.Size = _squareSize0_85;
            KeyResource.F6.Text = "F6\n▲🔊";
            KeyResource.F6.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F6);

            KeyResource.F7.Size = _squareSize0_85;
            KeyResource.F7.Text = "F7";
            KeyResource.F7.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F7);

            KeyResource.F8.Size = _squareSize0_85;
            KeyResource.F8.Text = "F8";
            KeyResource.F8.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F8);

            KeyResource.F9.Size = _squareSize0_85;
            KeyResource.F9.Text = "F9";
            KeyResource.F9.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F9);

            KeyResource.F10.Size = _squareSize0_85;
            KeyResource.F10.Text = "F10";
            KeyResource.F10.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F10);

            KeyResource.F11.Size = _squareSize0_85;
            KeyResource.F11.Text = "F11";
            KeyResource.F11.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F11);

            KeyResource.F12.Size = _squareSize0_85;
            KeyResource.F12.Text = "F12";
            KeyResource.F12.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.F12);

            KeyResource.NumLock.Size = _squareSize0_85;
            KeyResource.NumLock.Text = "NumLk";
            KeyResource.NumLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.NumLock);

            KeyResource.PrintScreen.Size = _squareSize0_85;
            KeyResource.PrintScreen.Text = "PrtSc\nSysRq";
            KeyResource.PrintScreen.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.PrintScreen);

            KeyResource.ScrollLock.Size = _squareSize0_85;
            KeyResource.ScrollLock.Text = "ScrLk";
            KeyResource.ScrollLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.ScrollLock);

            KeyResource.Pause.Size = _squareSize0_85;
            KeyResource.Pause.Text = "Pause\nBreak";
            KeyResource.Pause.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Pause);

            KeyResource.Oem5.Size = _rectangleSize0_75;
            KeyResource.Oem5.Text = "§½";
            KeyResource.Oem5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Oem5);

            KeyResource.D1.Size = _squareSize;
            KeyResource.D1.Text = "1";
            KeyResource.D1.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D1);

            KeyResource.D2.Size = _squareSize;
            KeyResource.D2.Text = "2";
            KeyResource.D2.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D2);

            KeyResource.D3.Size = _squareSize;
            KeyResource.D3.Text = "3";
            KeyResource.D3.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D3);

            KeyResource.D4.Size = _squareSize;
            KeyResource.D4.Text = "4";
            KeyResource.D4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D4);

            KeyResource.D5.Size = _squareSize;
            KeyResource.D5.Text = "5";
            KeyResource.D5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D5);

            KeyResource.D6.Size = _squareSize;
            KeyResource.D6.Text = "6";
            KeyResource.D6.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D6);

            KeyResource.D7.Size = _squareSize;
            KeyResource.D7.Text = "7";
            KeyResource.D7.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D7);

            KeyResource.D8.Size = _squareSize;
            KeyResource.D8.Text = "8";
            KeyResource.D8.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D8);

            KeyResource.D9.Size = _squareSize;
            KeyResource.D9.Text = "9";
            KeyResource.D9.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D9);

            KeyResource.D0.Size = _squareSize;
            KeyResource.D0.Text = "0";
            KeyResource.D0.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D0);

            KeyResource.OemPlus.Size = _squareSize;
            KeyResource.OemPlus.Text = @"+";
            KeyResource.OemPlus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemPlus);

            KeyResource.Oem4.Size = _squareSize;
            KeyResource.Oem4.Text = @"\";
            KeyResource.Oem4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Oem4);

            KeyResource.Back.Size = _rectangleSize1_25;
            KeyResource.Back.Text = "←";
            KeyResource.Back.TextAlign = ContentAlignment.MiddleLeft;
            AddKeyToLayout(KeyResource.Back);

            KeyResource.Home.Size = _rectangleSize0_9;
            KeyResource.Home.Text = "Home";
            KeyResource.Home.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Home);

            KeyResource.Tab.Size = _rectangleSize1_25;
            KeyResource.Tab.Text = "⭾";
            KeyResource.Tab.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Tab);

            KeyResource.Q.Size = _squareSize;
            KeyResource.Q.Text = "Q";
            KeyResource.Q.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Q);

            KeyResource.W.Size = _squareSize;
            KeyResource.W.Text = "W";
            KeyResource.W.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.W);

            KeyResource.E.Size = _squareSize;
            KeyResource.E.Text = "E";
            KeyResource.E.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.E);

            KeyResource.R.Size = _squareSize;
            KeyResource.R.Text = "R";
            KeyResource.R.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.R);

            KeyResource.T.Size = _squareSize;
            KeyResource.T.Text = "T";
            KeyResource.T.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.T);

            KeyResource.Y.Size = _squareSize;
            KeyResource.Y.Text = "Y";
            KeyResource.Y.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Y);

            KeyResource.U.Size = _squareSize;
            KeyResource.U.Text = "U";
            KeyResource.U.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.U);

            KeyResource.I.Size = _squareSize;
            KeyResource.I.Text = "I";
            KeyResource.I.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.I);

            KeyResource.O.Size = _squareSize;
            KeyResource.O.Text = "O";
            KeyResource.O.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.O);

            KeyResource.P.Size = _squareSize;
            KeyResource.P.Text = "P";
            KeyResource.P.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.P);

            KeyResource.Oem6.Size = _squareSize;
            KeyResource.Oem6.Text = "Å";
            KeyResource.Oem6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem6);

            KeyResource.Oem1.Size = _squareSize;
            KeyResource.Oem1.Text = "^";
            KeyResource.Oem1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem1);

            KeyResource.Oem2.Size = _rectangleSize0_75;
            KeyResource.Oem2.Text = "*";
            KeyResource.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem2);

            KeyResource.PageUp.Size = _rectangleSize0_9;
            KeyResource.PageUp.Text = "PgUp";
            KeyResource.PageUp.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.PageUp);

            KeyResource.CapsLock.Size = _rectangleSize1_5;
            KeyResource.CapsLock.Text = "Caps Lock";
            KeyResource.CapsLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.CapsLock);

            KeyResource.A.Size = _squareSize;
            KeyResource.A.Text = "A";
            KeyResource.A.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.A);

            KeyResource.S.Size = _squareSize;
            KeyResource.S.Text = "S";
            KeyResource.S.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.S);

            KeyResource.D.Size = _squareSize;
            KeyResource.D.Text = "D";
            KeyResource.D.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.D);

            KeyResource.F.Size = _squareSize;
            KeyResource.F.Text = "F";
            KeyResource.F.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F);

            KeyResource.G.Size = _squareSize;
            KeyResource.G.Text = "G";
            KeyResource.G.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.G);

            KeyResource.H.Size = _squareSize;
            KeyResource.H.Text = "H";
            KeyResource.H.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.H);

            KeyResource.J.Size = _squareSize;
            KeyResource.J.Text = "J";
            KeyResource.J.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.J);

            KeyResource.K.Size = _squareSize;
            KeyResource.K.Text = "K";
            KeyResource.K.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.K);

            KeyResource.L.Size = _squareSize;
            KeyResource.L.Text = "L";
            KeyResource.L.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.L);

            KeyResource.OemTilde.Size = _squareSize;
            KeyResource.OemTilde.Text = "Ö";
            KeyResource.OemTilde.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.OemTilde);

            KeyResource.Oem7.Size = _squareSize;
            KeyResource.Oem7.Text = "Ä";
            KeyResource.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem7);

            KeyResource.Return.Size = _rectangleSize1_5;
            KeyResource.Return.Text = "Enter ↩";
            KeyResource.Return.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Return);

            KeyResource.PageDown.Size = _rectangleSize0_9;
            KeyResource.PageDown.Text = "PgDn";
            KeyResource.PageDown.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.PageDown);

            KeyResource.LeftShift.Size = _rectangleSize2;
            KeyResource.LeftShift.Text = "↑ Shift";
            KeyResource.LeftShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LeftShift);

            KeyResource.Z.Size = _squareSize;
            KeyResource.Z.Text = "Z";
            KeyResource.Z.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Z);

            KeyResource.X.Size = _squareSize;
            KeyResource.X.Text = "X";
            KeyResource.X.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.X);

            KeyResource.C.Size = _squareSize;
            KeyResource.C.Text = "C";
            KeyResource.C.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.C);

            KeyResource.V.Size = _squareSize;
            KeyResource.V.Text = "V";
            KeyResource.V.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.V);

            KeyResource.B.Size = _squareSize;
            KeyResource.B.Text = "B";
            KeyResource.B.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.B);

            KeyResource.N.Size = _squareSize;
            KeyResource.N.Text = "N";
            KeyResource.N.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.N);

            KeyResource.M.Size = _squareSize;
            KeyResource.M.Text = "M";
            KeyResource.M.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.M);

            KeyResource.OemComma.Size = _squareSize;
            KeyResource.OemComma.Text = ",";
            KeyResource.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemComma);

            KeyResource.OemPeriod.Size = _squareSize;
            KeyResource.OemPeriod.Text = ".";
            KeyResource.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemPeriod);

            KeyResource.OemMinus.Size = _squareSize;
            KeyResource.OemMinus.Text = "-";
            KeyResource.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemMinus);

            KeyResource.RightShift.Size = _rectangleSize2;
            KeyResource.RightShift.Text = "↑ Shift";
            KeyResource.RightShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.RightShift);

            KeyResource.End.Size = _rectangleSize0_9;
            KeyResource.End.Text = "End";
            KeyResource.End.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.End);

            KeyResource.LeftControl.Size = _squareSize;
            KeyResource.LeftControl.Text = "Ctrl";
            KeyResource.LeftControl.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LeftControl);

            Fn.Size = _squareSize;
            Fn.Name = "Fn";
            Fn.Text = "Fn";
            Fn.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Fn);

            KeyResource.LeftWindows.Size = _squareSize;
            KeyResource.LeftWindows.Text = "⊞";
            KeyResource.LeftWindows.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LeftWindows);

            KeyResource.LeftAlt.Size = _squareSize;
            KeyResource.LeftAlt.Text = "Alt";
            KeyResource.LeftAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LeftAlt);

            KeyResource.Oem102.Size = _squareSize;
            KeyResource.Oem102.Text = ">\n<";
            KeyResource.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem102);

            KeyResource.Spacebar.Size = _spaceBarSize;
            KeyResource.Spacebar.Text = string.Empty;
            AddKeyToLayout(KeyResource.Spacebar);

            KeyResource.RightAlt.Size = _squareSize;
            KeyResource.RightAlt.Text = "Alt Gr";
            KeyResource.RightAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.RightAlt);

            KeyResource.Applications.Size = _squareSize;
            KeyResource.Applications.Text = "≣";
            KeyResource.Applications.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Applications);

            KeyResource.Insert.Size = _squareSize;
            KeyResource.Insert.Text = "Ins";
            KeyResource.Insert.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Insert);

            KeyResource.Delete.Size = _squareSize;
            KeyResource.Delete.Text = "Del";
            KeyResource.Delete.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.Delete);

            KeyResource.UpArrow.Size = _squareSize0_8;
            KeyResource.UpArrow.Text = "↑";
            KeyResource.UpArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.UpArrow);

            KeyResource.LeftArrow.Size = _squareSize0_8;
            KeyResource.LeftArrow.Text = "←";
            KeyResource.LeftArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LeftArrow);

            KeyResource.DownArrow.Size = _squareSize0_8;
            KeyResource.DownArrow.Text = "↓";
            KeyResource.DownArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.DownArrow);

            KeyResource.RightArrow.Size = _squareSize0_8;
            KeyResource.RightArrow.Text = "→";
            KeyResource.RightArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.RightArrow);

            // Hidden keys for detecting when Fn is pressed
            KeyResource.VolumeMute.Hide();
            AddKeyToLayout(KeyResource.VolumeMute);

            KeyResource.VolumeDown.Hide();
            AddKeyToLayout(KeyResource.VolumeDown);

            KeyResource.VolumeUp.Hide();
            AddKeyToLayout(KeyResource.VolumeUp);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth;
            var yCoordinate = BaseKeyWidth;

            foreach (var key in LayoutKeys.Values)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.KeyCode == Keys.Escape)
                {
                    xCoordinate += Convert.ToInt32(key.Width * 0.35);
                }
                else if (key.KeyCode == Keys.Delete)
                {
                    xCoordinate += _squareSize0_8.Width + _offset;
                }

                if (key.KeyCode == Keys.Pause || key.KeyCode == Keys.Home || key.KeyCode == Keys.PageUp || key.KeyCode == Keys.PageDown || key.KeyCode == Keys.End)
                {
                    xCoordinate = BaseKeyWidth;
                    yCoordinate += key.Height + _offset;
                }
                else if (key.KeyCode == Keys.Up)
                {
                    xCoordinate -= (key.Width * 2) + (_offset * 2);
                    yCoordinate += key.Height + _offset;
                }
            }
        }
    }
}