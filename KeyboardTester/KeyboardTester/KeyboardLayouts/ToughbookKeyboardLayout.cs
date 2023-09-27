namespace KeyboardTester.KeyboardLayouts
{
    public class ToughbookKeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new(BaseLength, BaseLength);
        private static readonly Size _squareSize0_8 = new(Convert.ToInt32(BaseLength * 0.8), Convert.ToInt32(BaseLength * 0.8));
        private static readonly Size _squareSize0_85 = new(Convert.ToInt32(BaseLength * 0.85), Convert.ToInt32(BaseLength * 0.85));
        private static readonly Size _rectangleSize0_75 = new(Convert.ToInt32(BaseLength * 0.75), BaseLength);
        private static readonly Size _rectangleSize0_9 = new(Convert.ToInt32(BaseLength * 0.9), BaseLength);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseLength * 1.25) + (_offset / 4), BaseLength);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseLength * 1.5) + (_offset / 2), BaseLength);
        private static readonly Size _rectangleSize2 = new((BaseLength * 2) + _offset, BaseLength);
        private static readonly Size _spaceBarSize = new(Convert.ToInt32(BaseLength * 3.5) + Convert.ToInt32(_offset * 2.5), BaseLength);

        public ToughbookKeyboardLayout(int baseLength)
            : base(baseLength)
        {
            InitiateKeys();
            SetCommonAttributes();
            DoLayout();
            SetKeyboardLayoutSize();
        }

        private void InitiateKeys()
        {
            KeyboardKeys.Escape.Size = _squareSize0_85;
            KeyboardKeys.Escape.Text = "ESC";
            KeyboardKeys.Escape.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Escape);

            KeyboardKeys.F1.Size = _squareSize0_85;
            KeyboardKeys.F1.Text = "F1\n▼☼";
            KeyboardKeys.F1.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F1);

            KeyboardKeys.F2.Size = _squareSize0_85;
            KeyboardKeys.F2.Text = "F2\n▲☼";
            KeyboardKeys.F2.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F2);

            KeyboardKeys.F3.Size = _squareSize0_85;
            KeyboardKeys.F3.Text = "F3\n▢/▣";
            KeyboardKeys.F3.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F3);

            KeyboardKeys.F4.Size = _squareSize0_85;
            KeyboardKeys.F4.Text = "F4\n🔇";
            KeyboardKeys.F4.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F4);

            KeyboardKeys.F5.Size = _squareSize0_85;
            KeyboardKeys.F5.Text = "F5\n▼🔊";
            KeyboardKeys.F5.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F5);

            KeyboardKeys.F6.Size = _squareSize0_85;
            KeyboardKeys.F6.Text = "F6\n▲🔊";
            KeyboardKeys.F6.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F6);

            KeyboardKeys.F7.Size = _squareSize0_85;
            KeyboardKeys.F7.Text = "F7";
            KeyboardKeys.F7.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F7);

            KeyboardKeys.F8.Size = _squareSize0_85;
            KeyboardKeys.F8.Text = "F8";
            KeyboardKeys.F8.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F8);

            KeyboardKeys.F9.Size = _squareSize0_85;
            KeyboardKeys.F9.Text = "F9";
            KeyboardKeys.F9.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F9);

            KeyboardKeys.F10.Size = _squareSize0_85;
            KeyboardKeys.F10.Text = "F10";
            KeyboardKeys.F10.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F10);

            KeyboardKeys.F11.Size = _squareSize0_85;
            KeyboardKeys.F11.Text = "F11";
            KeyboardKeys.F11.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F11);

            KeyboardKeys.F12.Size = _squareSize0_85;
            KeyboardKeys.F12.Text = "F12";
            KeyboardKeys.F12.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.F12);

            KeyboardKeys.NumLock.Size = _squareSize0_85;
            KeyboardKeys.NumLock.Text = "NumLk";
            KeyboardKeys.NumLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.NumLock);

            KeyboardKeys.PrintScreen.Size = _squareSize0_85;
            KeyboardKeys.PrintScreen.Text = "PrtSc\nSysRq";
            KeyboardKeys.PrintScreen.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.PrintScreen);

            KeyboardKeys.ScrollLock.Size = _squareSize0_85;
            KeyboardKeys.ScrollLock.Text = "ScrLk";
            KeyboardKeys.ScrollLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.ScrollLock);

            KeyboardKeys.Pause.Size = _squareSize0_85;
            KeyboardKeys.Pause.Text = "Pause\nBreak";
            KeyboardKeys.Pause.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Pause);

            KeyboardKeys.Oem5.Size = _rectangleSize0_75;
            KeyboardKeys.Oem5.Text = "§½";
            KeyboardKeys.Oem5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.Oem5);

            KeyboardKeys.D1.Size = _squareSize;
            KeyboardKeys.D1.Text = "1";
            KeyboardKeys.D1.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D1);

            KeyboardKeys.D2.Size = _squareSize;
            KeyboardKeys.D2.Text = "2";
            KeyboardKeys.D2.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D2);

            KeyboardKeys.D3.Size = _squareSize;
            KeyboardKeys.D3.Text = "3";
            KeyboardKeys.D3.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D3);

            KeyboardKeys.D4.Size = _squareSize;
            KeyboardKeys.D4.Text = "4";
            KeyboardKeys.D4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D4);

            KeyboardKeys.D5.Size = _squareSize;
            KeyboardKeys.D5.Text = "5";
            KeyboardKeys.D5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D5);

            KeyboardKeys.D6.Size = _squareSize;
            KeyboardKeys.D6.Text = "6";
            KeyboardKeys.D6.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D6);

            KeyboardKeys.D7.Size = _squareSize;
            KeyboardKeys.D7.Text = "7";
            KeyboardKeys.D7.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D7);

            KeyboardKeys.D8.Size = _squareSize;
            KeyboardKeys.D8.Text = "8";
            KeyboardKeys.D8.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D8);

            KeyboardKeys.D9.Size = _squareSize;
            KeyboardKeys.D9.Text = "9";
            KeyboardKeys.D9.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D9);

            KeyboardKeys.D0.Size = _squareSize;
            KeyboardKeys.D0.Text = "0";
            KeyboardKeys.D0.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.D0);

            KeyboardKeys.OemPlus.Size = _squareSize;
            KeyboardKeys.OemPlus.Text = @"+";
            KeyboardKeys.OemPlus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemPlus);

            KeyboardKeys.Oem4.Size = _squareSize;
            KeyboardKeys.Oem4.Text = @"\";
            KeyboardKeys.Oem4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.Oem4);

            KeyboardKeys.Back.Size = _rectangleSize1_25;
            KeyboardKeys.Back.Text = "←";
            KeyboardKeys.Back.TextAlign = ContentAlignment.MiddleLeft;
            AddKeyToLayout(KeyboardKeys.Back);

            KeyboardKeys.Home.Size = _rectangleSize0_9;
            KeyboardKeys.Home.Text = "Home";
            KeyboardKeys.Home.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Home);

            KeyboardKeys.Tab.Size = _rectangleSize1_25;
            KeyboardKeys.Tab.Text = "⭾";
            KeyboardKeys.Tab.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Tab);

            KeyboardKeys.Q.Size = _squareSize;
            KeyboardKeys.Q.Text = "Q";
            KeyboardKeys.Q.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Q);

            KeyboardKeys.W.Size = _squareSize;
            KeyboardKeys.W.Text = "W";
            KeyboardKeys.W.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.W);

            KeyboardKeys.E.Size = _squareSize;
            KeyboardKeys.E.Text = "E";
            KeyboardKeys.E.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.E);

            KeyboardKeys.R.Size = _squareSize;
            KeyboardKeys.R.Text = "R";
            KeyboardKeys.R.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.R);

            KeyboardKeys.T.Size = _squareSize;
            KeyboardKeys.T.Text = "T";
            KeyboardKeys.T.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.T);

            KeyboardKeys.Y.Size = _squareSize;
            KeyboardKeys.Y.Text = "Y";
            KeyboardKeys.Y.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Y);

            KeyboardKeys.U.Size = _squareSize;
            KeyboardKeys.U.Text = "U";
            KeyboardKeys.U.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.U);

            KeyboardKeys.I.Size = _squareSize;
            KeyboardKeys.I.Text = "I";
            KeyboardKeys.I.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.I);

            KeyboardKeys.O.Size = _squareSize;
            KeyboardKeys.O.Text = "O";
            KeyboardKeys.O.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.O);

            KeyboardKeys.P.Size = _squareSize;
            KeyboardKeys.P.Text = "P";
            KeyboardKeys.P.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.P);

            KeyboardKeys.Oem6.Size = _squareSize;
            KeyboardKeys.Oem6.Text = "Å";
            KeyboardKeys.Oem6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem6);

            KeyboardKeys.Oem1.Size = _squareSize;
            KeyboardKeys.Oem1.Text = "^";
            KeyboardKeys.Oem1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem1);

            KeyboardKeys.Oem2.Size = _rectangleSize0_75;
            KeyboardKeys.Oem2.Text = "*";
            KeyboardKeys.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem2);

            KeyboardKeys.PageUp.Size = _rectangleSize0_9;
            KeyboardKeys.PageUp.Text = "PgUp";
            KeyboardKeys.PageUp.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.PageUp);

            KeyboardKeys.CapsLock.Size = _rectangleSize1_5;
            KeyboardKeys.CapsLock.Text = "Caps Lock";
            KeyboardKeys.CapsLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.CapsLock);

            KeyboardKeys.A.Size = _squareSize;
            KeyboardKeys.A.Text = "A";
            KeyboardKeys.A.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.A);

            KeyboardKeys.S.Size = _squareSize;
            KeyboardKeys.S.Text = "S";
            KeyboardKeys.S.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.S);

            KeyboardKeys.D.Size = _squareSize;
            KeyboardKeys.D.Text = "D";
            KeyboardKeys.D.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.D);

            KeyboardKeys.F.Size = _squareSize;
            KeyboardKeys.F.Text = "F";
            KeyboardKeys.F.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F);

            KeyboardKeys.G.Size = _squareSize;
            KeyboardKeys.G.Text = "G";
            KeyboardKeys.G.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.G);

            KeyboardKeys.H.Size = _squareSize;
            KeyboardKeys.H.Text = "H";
            KeyboardKeys.H.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.H);

            KeyboardKeys.J.Size = _squareSize;
            KeyboardKeys.J.Text = "J";
            KeyboardKeys.J.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.J);

            KeyboardKeys.K.Size = _squareSize;
            KeyboardKeys.K.Text = "K";
            KeyboardKeys.K.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.K);

            KeyboardKeys.L.Size = _squareSize;
            KeyboardKeys.L.Text = "L";
            KeyboardKeys.L.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.L);

            KeyboardKeys.Oem3.Size = _squareSize;
            KeyboardKeys.Oem3.Text = "Ö";
            KeyboardKeys.Oem3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem3);

            KeyboardKeys.Oem7.Size = _squareSize;
            KeyboardKeys.Oem7.Text = "Ä";
            KeyboardKeys.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem7);

            KeyboardKeys.Return.Size = _rectangleSize1_5;
            KeyboardKeys.Return.Text = "Enter ↩";
            KeyboardKeys.Return.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Return);

            KeyboardKeys.PageDown.Size = _rectangleSize0_9;
            KeyboardKeys.PageDown.Text = "PgDn";
            KeyboardKeys.PageDown.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.PageDown);

            KeyboardKeys.LeftShift.Size = _rectangleSize2;
            KeyboardKeys.LeftShift.Text = "↑ Shift";
            KeyboardKeys.LeftShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LeftShift);

            KeyboardKeys.Z.Size = _squareSize;
            KeyboardKeys.Z.Text = "Z";
            KeyboardKeys.Z.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Z);

            KeyboardKeys.X.Size = _squareSize;
            KeyboardKeys.X.Text = "X";
            KeyboardKeys.X.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.X);

            KeyboardKeys.C.Size = _squareSize;
            KeyboardKeys.C.Text = "C";
            KeyboardKeys.C.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.C);

            KeyboardKeys.V.Size = _squareSize;
            KeyboardKeys.V.Text = "V";
            KeyboardKeys.V.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.V);

            KeyboardKeys.B.Size = _squareSize;
            KeyboardKeys.B.Text = "B";
            KeyboardKeys.B.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.B);

            KeyboardKeys.N.Size = _squareSize;
            KeyboardKeys.N.Text = "N";
            KeyboardKeys.N.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.N);

            KeyboardKeys.M.Size = _squareSize;
            KeyboardKeys.M.Text = "M";
            KeyboardKeys.M.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.M);

            KeyboardKeys.OemComma.Size = _squareSize;
            KeyboardKeys.OemComma.Text = ",";
            KeyboardKeys.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemComma);

            KeyboardKeys.OemPeriod.Size = _squareSize;
            KeyboardKeys.OemPeriod.Text = ".";
            KeyboardKeys.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemPeriod);

            KeyboardKeys.OemMinus.Size = _squareSize;
            KeyboardKeys.OemMinus.Text = "-";
            KeyboardKeys.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemMinus);

            KeyboardKeys.RightShift.Size = _rectangleSize2;
            KeyboardKeys.RightShift.Text = "↑ Shift";
            KeyboardKeys.RightShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.RightShift);

            KeyboardKeys.End.Size = _rectangleSize0_9;
            KeyboardKeys.End.Text = "End";
            KeyboardKeys.End.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.End);

            KeyboardKeys.LeftControl.Size = _squareSize;
            KeyboardKeys.LeftControl.Text = "Ctrl";
            KeyboardKeys.LeftControl.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LeftControl);

            KeyboardKeys.Fn.Size = _squareSize;
            KeyboardKeys.Fn.Text = "Fn";
            KeyboardKeys.Fn.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Fn);

            KeyboardKeys.LeftWindows.Size = _squareSize;
            KeyboardKeys.LeftWindows.Text = "⊞";
            KeyboardKeys.LeftWindows.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LeftWindows);

            KeyboardKeys.LeftAlt.Size = _squareSize;
            KeyboardKeys.LeftAlt.Text = "Alt";
            KeyboardKeys.LeftAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LeftAlt);

            KeyboardKeys.Oem102.Size = _squareSize;
            KeyboardKeys.Oem102.Text = ">\n<";
            KeyboardKeys.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem102);

            KeyboardKeys.Spacebar.Size = _spaceBarSize;
            KeyboardKeys.Spacebar.Text = string.Empty;
            AddKeyToLayout(KeyboardKeys.Spacebar);

            KeyboardKeys.RightAlt.Size = _squareSize;
            KeyboardKeys.RightAlt.Text = "Alt Gr";
            KeyboardKeys.RightAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.RightAlt);

            KeyboardKeys.Applications.Size = _squareSize;
            KeyboardKeys.Applications.Text = "≣";
            KeyboardKeys.Applications.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Applications);

            KeyboardKeys.Insert.Size = _squareSize;
            KeyboardKeys.Insert.Text = "Ins";
            KeyboardKeys.Insert.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Insert);

            KeyboardKeys.Delete.Size = _squareSize;
            KeyboardKeys.Delete.Text = "Del";
            KeyboardKeys.Delete.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.Delete);

            KeyboardKeys.UpArrow.Size = _squareSize0_8;
            KeyboardKeys.UpArrow.Text = "↑";
            KeyboardKeys.UpArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.UpArrow);

            KeyboardKeys.LeftArrow.Size = _squareSize0_8;
            KeyboardKeys.LeftArrow.Text = "←";
            KeyboardKeys.LeftArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LeftArrow);

            KeyboardKeys.DownArrow.Size = _squareSize0_8;
            KeyboardKeys.DownArrow.Text = "↓";
            KeyboardKeys.DownArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.DownArrow);

            KeyboardKeys.RightArrow.Size = _squareSize0_8;
            KeyboardKeys.RightArrow.Text = "→";
            KeyboardKeys.RightArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.RightArrow);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseLength;
            var yCoordinate = BaseLength;

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
                    xCoordinate = BaseLength;
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