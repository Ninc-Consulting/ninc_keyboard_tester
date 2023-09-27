using System.Diagnostics.Metrics;

namespace KeyboardTester.KeyboardLayouts
{
    public class CherryKeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new (BaseLength, BaseLength);
        private static readonly Size _squareSizeHalfHeight = new (BaseLength, BaseLength / 2);
        private static readonly Size _rectangleSize1_25 = new (Convert.ToInt32(BaseLength * 1.25) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_5 = new (Convert.ToInt32(BaseLength * 1.5) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_7 = new (Convert.ToInt32(BaseLength * 1.7) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_75 = new (Convert.ToInt32(BaseLength * 1.75) + _offset, BaseLength);
        private static readonly Size _rectangleSize2 = new ((BaseLength * 2) + _offset, BaseLength);
        private static readonly Size _rectangleSize2_75 = new (Convert.ToInt32(BaseLength * 2.75) + _offset, BaseLength);
        private static readonly Size _reverseRectangleSize2 = new (BaseLength, (BaseLength * 2) + _offset);
        private static readonly Size _spacebarSize = new (Convert.ToInt32(BaseLength * 5) + _offset, BaseLength);
        private static readonly Size _returnSize = new (Convert.ToInt32(BaseLength * 1.25), (BaseLength * 2) + _offset);

        // Dummy button
        private readonly Key _lockScreen = new ();

        public CherryKeyboardLayout(int baseLength)
            : base(baseLength)
        {
            InitiateKeys();
            SetCommonAttributes();
            DoLayout();
            SetKeyboardLayoutSize();
        }

        private void InitiateKeys()
        {
            KeyboardKeys.Escape.Size = _squareSizeHalfHeight;
            KeyboardKeys.Escape.Text = "ESC";
            KeyboardKeys.Escape.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Escape);

            KeyboardKeys.F1.Size = _squareSizeHalfHeight;
            KeyboardKeys.F1.Text = "F1";
            KeyboardKeys.F1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F1);

            KeyboardKeys.F2.Size = _squareSizeHalfHeight;
            KeyboardKeys.F2.Text = "F2";
            KeyboardKeys.F2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F2);

            KeyboardKeys.F3.Size = _squareSizeHalfHeight;
            KeyboardKeys.F3.Text = "F3";
            KeyboardKeys.F3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F3);

            KeyboardKeys.F4.Size = _squareSizeHalfHeight;
            KeyboardKeys.F4.Text = "F4";
            KeyboardKeys.F4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F4);

            KeyboardKeys.F5.Size = _squareSizeHalfHeight;
            KeyboardKeys.F5.Text = "F5";
            KeyboardKeys.F5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F5);

            KeyboardKeys.F6.Size = _squareSizeHalfHeight;
            KeyboardKeys.F6.Text = "F6";
            KeyboardKeys.F6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F6);

            KeyboardKeys.F7.Size = _squareSizeHalfHeight;
            KeyboardKeys.F7.Text = "F7";
            KeyboardKeys.F7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F7);

            KeyboardKeys.F8.Size = _squareSizeHalfHeight;
            KeyboardKeys.F8.Text = "F8";
            KeyboardKeys.F8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F8);

            KeyboardKeys.F9.Size = _squareSizeHalfHeight;
            KeyboardKeys.F9.Text = "F9";
            KeyboardKeys.F9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F9);

            KeyboardKeys.F10.Size = _squareSizeHalfHeight;
            KeyboardKeys.F10.Text = "F10";
            KeyboardKeys.F10.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F10);

            KeyboardKeys.F11.Size = _squareSizeHalfHeight;
            KeyboardKeys.F11.Text = "F11";
            KeyboardKeys.F11.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F11);

            KeyboardKeys.F12.Size = _squareSizeHalfHeight;
            KeyboardKeys.F12.Text = "F12";
            KeyboardKeys.F12.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.F12);

            KeyboardKeys.PrintScreen.Size = _squareSizeHalfHeight;
            KeyboardKeys.PrintScreen.Text = "PRT SC\nSYS RQ";
            KeyboardKeys.PrintScreen.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.PrintScreen);

            KeyboardKeys.ScrollLock.Size = _squareSizeHalfHeight;
            KeyboardKeys.ScrollLock.Text = "SCROLL";
            KeyboardKeys.ScrollLock.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.ScrollLock);

            KeyboardKeys.Pause.KeyCodeValue = (int)Keys.Pause;
            KeyboardKeys.Pause.KeyCode = Keys.Pause;
            KeyboardKeys.Pause.Name = "Pause";
            KeyboardKeys.Pause.Size = _squareSizeHalfHeight;
            KeyboardKeys.Pause.Text = "PAUSE\nBREAK";
            KeyboardKeys.Pause.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyboardKeys.Pause);

            _lockScreen.KeyCodeValue = (int)Keys.None;  // No difference to LWin + L, use dummy value for now
            _lockScreen.KeyCode = Keys.None;
            _lockScreen.Name = "LockScreen";
            _lockScreen.Size = _squareSizeHalfHeight;
            _lockScreen.Text = "Lock";
            _lockScreen.TextAlign = ContentAlignment.MiddleCenter;
            _lockScreen.Enabled = false;
            AddKeyToLayout(_lockScreen);

            KeyboardKeys.BrowserHome.Size = _squareSizeHalfHeight;
            KeyboardKeys.BrowserHome.Text = "Browser";
            KeyboardKeys.BrowserHome.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.BrowserHome);

            KeyboardKeys.LaunchMail.Size = _squareSizeHalfHeight;
            KeyboardKeys.LaunchMail.Text = "Mail";
            KeyboardKeys.LaunchMail.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LaunchMail);

            KeyboardKeys.LaunchApplication2.Size = _squareSizeHalfHeight;
            KeyboardKeys.LaunchApplication2.Text = "Calc";
            KeyboardKeys.LaunchApplication2.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyboardKeys.LaunchApplication2);

            KeyboardKeys.Oem5.Size = _squareSize;
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

            KeyboardKeys.Back.Size = _rectangleSize2;
            KeyboardKeys.Back.Text = "←";
            KeyboardKeys.Back.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.Back);

            KeyboardKeys.Insert.Size = _squareSize;
            KeyboardKeys.Insert.Text = "INSERT";
            KeyboardKeys.Insert.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.Insert);

            KeyboardKeys.Home.Size = _squareSize;
            KeyboardKeys.Home.Text = "HOME";
            KeyboardKeys.Home.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.Home);

            KeyboardKeys.PageUp.Size = _squareSize;
            KeyboardKeys.PageUp.Text = "PAGE▴";
            KeyboardKeys.PageUp.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.PageUp);

            KeyboardKeys.NumLock.Size = _squareSize;
            KeyboardKeys.NumLock.Text = "NUM";
            KeyboardKeys.NumLock.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.NumLock);

            KeyboardKeys.Divide.Size = _squareSize;
            KeyboardKeys.Divide.Text = "/";
            KeyboardKeys.Divide.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Divide);

            KeyboardKeys.Multiply.Size = _squareSize;
            KeyboardKeys.Multiply.Text = "*";
            KeyboardKeys.Multiply.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Multiply);

            KeyboardKeys.Subtract.Size = _squareSize;
            KeyboardKeys.Subtract.Text = "-";
            KeyboardKeys.Subtract.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Subtract);

            KeyboardKeys.Tab.Size = _rectangleSize1_5;
            KeyboardKeys.Tab.Text = "⭾";
            KeyboardKeys.Tab.TextAlign = ContentAlignment.BottomLeft;
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

            KeyboardKeys.Return.Size = _returnSize;
            KeyboardKeys.Return.Text = "↩";
            KeyboardKeys.Return.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.Return);

            KeyboardKeys.Delete.Size = _squareSize;
            KeyboardKeys.Delete.Text = "DELETE";
            KeyboardKeys.Delete.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.Delete);

            KeyboardKeys.End.Size = _squareSize;
            KeyboardKeys.End.Text = "END";
            KeyboardKeys.End.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.End);

            KeyboardKeys.PageDown.Size = _squareSize;
            KeyboardKeys.PageDown.Text = "PAGE▾";
            KeyboardKeys.PageDown.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.PageDown);

            KeyboardKeys.NumPad7.Size = _squareSize;
            KeyboardKeys.NumPad7.Text = "7";
            KeyboardKeys.NumPad7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad7);

            KeyboardKeys.NumPad8.Size = _squareSize;
            KeyboardKeys.NumPad8.Text = "8";
            KeyboardKeys.NumPad8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad8);

            KeyboardKeys.NumPad9.Size = _squareSize;
            KeyboardKeys.NumPad9.Text = "9";
            KeyboardKeys.NumPad9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad9);

            KeyboardKeys.Add.Size = _reverseRectangleSize2;
            KeyboardKeys.Add.Text = "+";
            KeyboardKeys.Add.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Add);

            KeyboardKeys.CapsLock.Size = _rectangleSize1_75;
            KeyboardKeys.CapsLock.Text = "CAPS";
            KeyboardKeys.CapsLock.TextAlign = ContentAlignment.BottomLeft;
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

            KeyboardKeys.Oem2.Size = _squareSize;
            KeyboardKeys.Oem2.Text = "*";
            KeyboardKeys.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem2);

            KeyboardKeys.NumPad4.Size = _squareSize;
            KeyboardKeys.NumPad4.Text = "4";
            KeyboardKeys.NumPad4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad4);

            KeyboardKeys.NumPad5.Size = _squareSize;
            KeyboardKeys.NumPad5.Text = "5";
            KeyboardKeys.NumPad5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad5);

            KeyboardKeys.NumPad6.Size = _squareSize;
            KeyboardKeys.NumPad6.Text = "6";
            KeyboardKeys.NumPad6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad6);

            KeyboardKeys.LeftShift.Size = _rectangleSize1_25;
            KeyboardKeys.LeftShift.Text = "↑";
            KeyboardKeys.LeftShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.LeftShift);

            KeyboardKeys.Oem102.Size = _squareSize;
            KeyboardKeys.Oem102.Text = ">\n<";
            KeyboardKeys.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Oem102);

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
            KeyboardKeys.OemComma.Text = ";\n,";
            KeyboardKeys.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemComma);

            KeyboardKeys.OemPeriod.Size = _squareSize;
            KeyboardKeys.OemPeriod.Text = ":\n.";
            KeyboardKeys.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemPeriod);

            KeyboardKeys.OemMinus.Size = _squareSize;
            KeyboardKeys.OemMinus.Text = "_\n-";
            KeyboardKeys.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.OemMinus);

            KeyboardKeys.RightShift.Size = _rectangleSize2_75;
            KeyboardKeys.RightShift.Text = "↑";
            KeyboardKeys.RightShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.RightShift);

            KeyboardKeys.UpArrow.Size = _squareSize;
            KeyboardKeys.UpArrow.Text = "△";
            KeyboardKeys.UpArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.UpArrow);

            KeyboardKeys.NumPad1.Size = _squareSize;
            KeyboardKeys.NumPad1.Text = "1";
            KeyboardKeys.NumPad1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad1);

            KeyboardKeys.NumPad2.Size = _squareSize;
            KeyboardKeys.NumPad2.Text = "2";
            KeyboardKeys.NumPad2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad2);

            KeyboardKeys.NumPad3.Size = _squareSize;
            KeyboardKeys.NumPad3.Text = "3";
            KeyboardKeys.NumPad3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad3);

            KeyboardKeys.Enter.Size = _reverseRectangleSize2;
            KeyboardKeys.Enter.Text = "ENTER";
            KeyboardKeys.Enter.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyboardKeys.Enter);

            KeyboardKeys.LeftControl.Size = _rectangleSize1_7;
            KeyboardKeys.LeftControl.Text = "CONTROL";
            KeyboardKeys.LeftControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.LeftControl);

            KeyboardKeys.LeftWindows.Size = _rectangleSize1_5;
            KeyboardKeys.LeftWindows.Text = "⊞";
            KeyboardKeys.LeftWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.LeftWindows);

            KeyboardKeys.LeftAlt.Size = _rectangleSize1_5;
            KeyboardKeys.LeftAlt.Text = "ALT";
            KeyboardKeys.LeftAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.LeftAlt);

            KeyboardKeys.Spacebar.Size = _spacebarSize;
            KeyboardKeys.Spacebar.Text = string.Empty;
            AddKeyToLayout(KeyboardKeys.Spacebar);

            KeyboardKeys.RightAlt.Size = _rectangleSize1_5;
            KeyboardKeys.RightAlt.Text = "ALT GR";
            KeyboardKeys.RightAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.RightAlt);

            KeyboardKeys.RightWindows.Size = _rectangleSize1_25;
            KeyboardKeys.RightWindows.Text = "⊞";
            KeyboardKeys.RightWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.RightWindows);

            KeyboardKeys.Applications.Size = _rectangleSize1_25;
            KeyboardKeys.Applications.Text = "≣";
            KeyboardKeys.Applications.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.Applications);

            KeyboardKeys.RightControl.Size = _rectangleSize1_25;
            KeyboardKeys.RightControl.Text = "CONTROL";
            KeyboardKeys.RightControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyboardKeys.RightControl);

            KeyboardKeys.LeftArrow.Size = _squareSize;
            KeyboardKeys.LeftArrow.Text = "◁";
            KeyboardKeys.LeftArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.LeftArrow);

            KeyboardKeys.DownArrow.Size = _squareSize;
            KeyboardKeys.DownArrow.Text = "▽";
            KeyboardKeys.DownArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.DownArrow);

            KeyboardKeys.RightArrow.Size = _squareSize;
            KeyboardKeys.RightArrow.Text = "▷";
            KeyboardKeys.RightArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.RightArrow);

            KeyboardKeys.NumPad0.Size = _rectangleSize2;
            KeyboardKeys.NumPad0.Text = "0";
            KeyboardKeys.NumPad0.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.NumPad0);

            KeyboardKeys.Decimal.Size = _squareSize;
            KeyboardKeys.Decimal.Text = ",";
            KeyboardKeys.Decimal.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyboardKeys.Decimal);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseLength;
            var yCoordinate = BaseLength;

            foreach (var key in LayoutKeys.Values)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.KeyCode == Keys.F4 || key.KeyCode == Keys.F12 || key.KeyCode == Keys.Pause)
                {
                    xCoordinate += BaseLength / 2;
                }
                else if (key.KeyCode == Keys.F8)
                {
                    xCoordinate += (BaseLength / 2) + _offset;
                }
                else if (key.KeyCode == Keys.Escape)
                        {
                    xCoordinate += BaseLength + _offset;
                }
                else if (key.KeyCode == Keys.Back || key.KeyCode == Keys.PageUp || (key.KeyCode == Keys.Return && key.KeyCodeValue > 0) || key.KeyCode == Keys.PageDown || key.KeyCode == Keys.RControlKey || key.KeyCode == Keys.Right)
                {
                    xCoordinate += BaseLength / 2;
                }
                else if (key.KeyCode == Keys.Oem1)
                {
                    xCoordinate += Convert.ToInt32(BaseLength * 0.20) + _offset;
                }
                else if (key.KeyCode == Keys.Oem2)
                {
                    xCoordinate += Convert.ToInt32((BaseLength * 5.25) + (4 * _offset));
                }
                else if (key.KeyCode == Keys.RShiftKey || key.KeyCode == Keys.Up)
                {
                    xCoordinate += Convert.ToInt32((BaseLength * 1.5) + _offset);
                }

                // New row
                if (key.KeyCode == Keys.LaunchApplication2)
                {
                    xCoordinate = BaseLength;
                    yCoordinate += key.Height * 2;
                }
                else if (key.KeyCode == Keys.Subtract || key.KeyCode == Keys.Add || key.KeyCode == Keys.NumPad6 || (key.KeyCode == Keys.Enter && key.KeyCodeValue < 0))
                {
                    xCoordinate = BaseLength;
                    yCoordinate += BaseLength + _offset;
                }
            }
        }
    }
}
