namespace KeyboardTesterApp.Models.KeyboardLayouts
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
            Resources.Keys.Escape.Size = _squareSize0_85;
            Resources.Keys.Escape.Text = "ESC";
            Resources.Keys.Escape.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Escape);

            Resources.Keys.F1.Size = _squareSize0_85;
            Resources.Keys.F1.Text = "F1";
            Resources.Keys.F1.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F1);

            Resources.Keys.F2.Size = _squareSize0_85;
            Resources.Keys.F2.Text = "F2";
            Resources.Keys.F2.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F2);

            Resources.Keys.F3.Size = _squareSize0_85;
            Resources.Keys.F3.Text = "F3";
            Resources.Keys.F3.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F3);

            Resources.Keys.F4.Size = _squareSize0_85;
            Resources.Keys.F4.Text = "F4";
            Resources.Keys.F4.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F4);

            Resources.Keys.F5.Size = _squareSize0_85;
            Resources.Keys.F5.Text = "F5";
            Resources.Keys.F5.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F5);

            Resources.Keys.F6.Size = _squareSize0_85;
            Resources.Keys.F6.Text = "F6";
            Resources.Keys.F6.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F6);

            Resources.Keys.F7.Size = _squareSize0_85;
            Resources.Keys.F7.Text = "F7";
            Resources.Keys.F7.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F7);

            Resources.Keys.F8.Size = _squareSize0_85;
            Resources.Keys.F8.Text = "F8";
            Resources.Keys.F8.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F8);

            Resources.Keys.F9.Size = _squareSize0_85;
            Resources.Keys.F9.Text = "F9";
            Resources.Keys.F9.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F9);

            Resources.Keys.F10.Size = _squareSize0_85;
            Resources.Keys.F10.Text = "F10";
            Resources.Keys.F10.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F10);

            Resources.Keys.F11.Size = _squareSize0_85;
            Resources.Keys.F11.Text = "F11";
            Resources.Keys.F11.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F11);

            Resources.Keys.F12.Size = _squareSize0_85;
            Resources.Keys.F12.Text = "F12";
            Resources.Keys.F12.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.F12);

            Resources.Keys.NumLock.Size = _squareSize0_85;
            Resources.Keys.NumLock.Text = "NumLk";
            Resources.Keys.NumLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.NumLock);

            Resources.Keys.PrintScreen.Size = _squareSize0_85;
            Resources.Keys.PrintScreen.Text = "PrtSc\nSysRq";
            Resources.Keys.PrintScreen.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.PrintScreen);

            Resources.Keys.ScrollLock.Size = _squareSize0_85;
            Resources.Keys.ScrollLock.Text = "ScrLk";
            Resources.Keys.ScrollLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.ScrollLock);

            Resources.Keys.Pause.Size = _squareSize0_85;
            Resources.Keys.Pause.Text = "Pause\nBreak";
            Resources.Keys.Pause.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Pause);

            Resources.Keys.Oem5.Size = _rectangleSize0_75;
            Resources.Keys.Oem5.Text = "§½";
            Resources.Keys.Oem5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Oem5);

            Resources.Keys.D1.Size = _squareSize;
            Resources.Keys.D1.Text = "1";
            Resources.Keys.D1.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D1);

            Resources.Keys.D2.Size = _squareSize;
            Resources.Keys.D2.Text = "2";
            Resources.Keys.D2.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D2);

            Resources.Keys.D3.Size = _squareSize;
            Resources.Keys.D3.Text = "3";
            Resources.Keys.D3.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D3);

            Resources.Keys.D4.Size = _squareSize;
            Resources.Keys.D4.Text = "4";
            Resources.Keys.D4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D4);

            Resources.Keys.D5.Size = _squareSize;
            Resources.Keys.D5.Text = "5";
            Resources.Keys.D5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D5);

            Resources.Keys.D6.Size = _squareSize;
            Resources.Keys.D6.Text = "6";
            Resources.Keys.D6.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D6);

            Resources.Keys.D7.Size = _squareSize;
            Resources.Keys.D7.Text = "7";
            Resources.Keys.D7.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D7);

            Resources.Keys.D8.Size = _squareSize;
            Resources.Keys.D8.Text = "8";
            Resources.Keys.D8.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D8);

            Resources.Keys.D9.Size = _squareSize;
            Resources.Keys.D9.Text = "9";
            Resources.Keys.D9.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D9);

            Resources.Keys.D0.Size = _squareSize;
            Resources.Keys.D0.Text = "0";
            Resources.Keys.D0.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D0);

            Resources.Keys.OemPlus.Size = _squareSize;
            Resources.Keys.OemPlus.Text = @"+";
            Resources.Keys.OemPlus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemPlus);

            Resources.Keys.Oem4.Size = _squareSize;
            Resources.Keys.Oem4.Text = @"\";
            Resources.Keys.Oem4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Oem4);

            Resources.Keys.Back.Size = _rectangleSize1_25;
            Resources.Keys.Back.Text = "←";
            Resources.Keys.Back.TextAlign = ContentAlignment.MiddleLeft;
            AddKeyToLayout(Resources.Keys.Back);

            Resources.Keys.Home.Size = _rectangleSize0_9;
            Resources.Keys.Home.Text = "Home";
            Resources.Keys.Home.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Home);

            Resources.Keys.Tab.Size = _rectangleSize1_25;
            Resources.Keys.Tab.Text = "⭾";
            Resources.Keys.Tab.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Tab);

            Resources.Keys.Q.Size = _squareSize;
            Resources.Keys.Q.Text = "Q";
            Resources.Keys.Q.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Q);

            Resources.Keys.W.Size = _squareSize;
            Resources.Keys.W.Text = "W";
            Resources.Keys.W.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.W);

            Resources.Keys.E.Size = _squareSize;
            Resources.Keys.E.Text = "E";
            Resources.Keys.E.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.E);

            Resources.Keys.R.Size = _squareSize;
            Resources.Keys.R.Text = "R";
            Resources.Keys.R.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.R);

            Resources.Keys.T.Size = _squareSize;
            Resources.Keys.T.Text = "T";
            Resources.Keys.T.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.T);

            Resources.Keys.Y.Size = _squareSize;
            Resources.Keys.Y.Text = "Y";
            Resources.Keys.Y.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Y);

            Resources.Keys.U.Size = _squareSize;
            Resources.Keys.U.Text = "U";
            Resources.Keys.U.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.U);

            Resources.Keys.I.Size = _squareSize;
            Resources.Keys.I.Text = "I";
            Resources.Keys.I.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.I);

            Resources.Keys.O.Size = _squareSize;
            Resources.Keys.O.Text = "O";
            Resources.Keys.O.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.O);

            Resources.Keys.P.Size = _squareSize;
            Resources.Keys.P.Text = "P";
            Resources.Keys.P.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.P);

            Resources.Keys.Oem6.Size = _squareSize;
            Resources.Keys.Oem6.Text = "Å";
            Resources.Keys.Oem6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem6);

            Resources.Keys.Oem1.Size = _squareSize;
            Resources.Keys.Oem1.Text = "^";
            Resources.Keys.Oem1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem1);

            Resources.Keys.Oem2.Size = _rectangleSize0_75;
            Resources.Keys.Oem2.Text = "*";
            Resources.Keys.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem2);

            Resources.Keys.PageUp.Size = _rectangleSize0_9;
            Resources.Keys.PageUp.Text = "PgUp";
            Resources.Keys.PageUp.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.PageUp);

            Resources.Keys.CapsLock.Size = _rectangleSize1_5;
            Resources.Keys.CapsLock.Text = "Caps Lock";
            Resources.Keys.CapsLock.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.CapsLock);

            Resources.Keys.A.Size = _squareSize;
            Resources.Keys.A.Text = "A";
            Resources.Keys.A.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.A);

            Resources.Keys.S.Size = _squareSize;
            Resources.Keys.S.Text = "S";
            Resources.Keys.S.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.S);

            Resources.Keys.D.Size = _squareSize;
            Resources.Keys.D.Text = "D";
            Resources.Keys.D.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.D);

            Resources.Keys.F.Size = _squareSize;
            Resources.Keys.F.Text = "F";
            Resources.Keys.F.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F);

            Resources.Keys.G.Size = _squareSize;
            Resources.Keys.G.Text = "G";
            Resources.Keys.G.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.G);

            Resources.Keys.H.Size = _squareSize;
            Resources.Keys.H.Text = "H";
            Resources.Keys.H.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.H);

            Resources.Keys.J.Size = _squareSize;
            Resources.Keys.J.Text = "J";
            Resources.Keys.J.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.J);

            Resources.Keys.K.Size = _squareSize;
            Resources.Keys.K.Text = "K";
            Resources.Keys.K.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.K);

            Resources.Keys.L.Size = _squareSize;
            Resources.Keys.L.Text = "L";
            Resources.Keys.L.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.L);

            Resources.Keys.OemTilde.Size = _squareSize;
            Resources.Keys.OemTilde.Text = "Ö";
            Resources.Keys.OemTilde.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.OemTilde);

            Resources.Keys.Oem7.Size = _squareSize;
            Resources.Keys.Oem7.Text = "Ä";
            Resources.Keys.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem7);

            Resources.Keys.Return.Size = _rectangleSize1_5;
            Resources.Keys.Return.Text = "Enter ↩";
            Resources.Keys.Return.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Return);

            Resources.Keys.PageDown.Size = _rectangleSize0_9;
            Resources.Keys.PageDown.Text = "PgDn";
            Resources.Keys.PageDown.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.PageDown);

            Resources.Keys.LeftShift.Size = _rectangleSize2;
            Resources.Keys.LeftShift.Text = "↑ Shift";
            Resources.Keys.LeftShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.LeftShift);

            Resources.Keys.Z.Size = _squareSize;
            Resources.Keys.Z.Text = "Z";
            Resources.Keys.Z.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Z);

            Resources.Keys.X.Size = _squareSize;
            Resources.Keys.X.Text = "X";
            Resources.Keys.X.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.X);

            Resources.Keys.C.Size = _squareSize;
            Resources.Keys.C.Text = "C";
            Resources.Keys.C.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.C);

            Resources.Keys.V.Size = _squareSize;
            Resources.Keys.V.Text = "V";
            Resources.Keys.V.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.V);

            Resources.Keys.B.Size = _squareSize;
            Resources.Keys.B.Text = "B";
            Resources.Keys.B.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.B);

            Resources.Keys.N.Size = _squareSize;
            Resources.Keys.N.Text = "N";
            Resources.Keys.N.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.N);

            Resources.Keys.M.Size = _squareSize;
            Resources.Keys.M.Text = "M";
            Resources.Keys.M.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.M);

            Resources.Keys.OemComma.Size = _squareSize;
            Resources.Keys.OemComma.Text = ",";
            Resources.Keys.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemComma);

            Resources.Keys.OemPeriod.Size = _squareSize;
            Resources.Keys.OemPeriod.Text = ".";
            Resources.Keys.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemPeriod);

            Resources.Keys.OemMinus.Size = _squareSize;
            Resources.Keys.OemMinus.Text = "-";
            Resources.Keys.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemMinus);

            Resources.Keys.RightShift.Size = _rectangleSize2;
            Resources.Keys.RightShift.Text = "↑ Shift";
            Resources.Keys.RightShift.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.RightShift);

            Resources.Keys.End.Size = _rectangleSize0_9;
            Resources.Keys.End.Text = "End";
            Resources.Keys.End.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.End);

            Resources.Keys.LeftControl.Size = _squareSize;
            Resources.Keys.LeftControl.Text = "Ctrl";
            Resources.Keys.LeftControl.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.LeftControl);

            Fn.Size = _squareSize;
            Fn.Name = "Fn";
            Fn.Text = "Fn";
            Fn.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Fn);

            Resources.Keys.LeftWindows.Size = _squareSize;
            Resources.Keys.LeftWindows.Text = "⊞";
            Resources.Keys.LeftWindows.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.LeftWindows);

            Resources.Keys.LeftAlt.Size = _squareSize;
            Resources.Keys.LeftAlt.Text = "Alt";
            Resources.Keys.LeftAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.LeftAlt);

            Resources.Keys.Oem102.Size = _squareSize;
            Resources.Keys.Oem102.Text = ">\n<";
            Resources.Keys.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem102);

            Resources.Keys.Spacebar.Size = _spaceBarSize;
            Resources.Keys.Spacebar.Text = string.Empty;
            AddKeyToLayout(Resources.Keys.Spacebar);

            Resources.Keys.RightAlt.Size = _squareSize;
            Resources.Keys.RightAlt.Text = "Alt Gr";
            Resources.Keys.RightAlt.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.RightAlt);

            Resources.Keys.Applications.Size = _squareSize;
            Resources.Keys.Applications.Text = "≣";
            Resources.Keys.Applications.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Applications);

            Resources.Keys.Insert.Size = _squareSize;
            Resources.Keys.Insert.Text = "Ins";
            Resources.Keys.Insert.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Insert);

            Resources.Keys.Delete.Size = _squareSize;
            Resources.Keys.Delete.Text = "Del";
            Resources.Keys.Delete.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.Delete);

            Resources.Keys.UpArrow.Size = _squareSize0_8;
            Resources.Keys.UpArrow.Text = "↑";
            Resources.Keys.UpArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.UpArrow);

            Resources.Keys.LeftArrow.Size = _squareSize0_8;
            Resources.Keys.LeftArrow.Text = "←";
            Resources.Keys.LeftArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.LeftArrow);

            Resources.Keys.DownArrow.Size = _squareSize0_8;
            Resources.Keys.DownArrow.Text = "↓";
            Resources.Keys.DownArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.DownArrow);

            Resources.Keys.RightArrow.Size = _squareSize0_8;
            Resources.Keys.RightArrow.Text = "→";
            Resources.Keys.RightArrow.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(Resources.Keys.RightArrow);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth / 2;
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

                if (key.KeyCode == Keys.Pause || key.KeyCode == Keys.Home || key.KeyCode == Keys.PageUp || key.KeyCode == Keys.PageDown || key.KeyCode == Keys.End || key.KeyCode == Keys.Right || key.KeyCode == Keys.NumPad5)
                {
                    xCoordinate = BaseKeyWidth / 2;
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