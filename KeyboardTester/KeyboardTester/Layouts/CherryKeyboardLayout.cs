using KeyboardTester.Util;
using System.Diagnostics.Metrics;

namespace KeyboardTester.KeyboardLayouts
{
    public class CherryKeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new(BaseLength, BaseLength);
        private static readonly Size _squareSizeHalfHeight = new(BaseLength, BaseLength / 2);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseLength * 1.25) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseLength * 1.5) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_7 = new(Convert.ToInt32(BaseLength * 1.7) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_75 = new(Convert.ToInt32(BaseLength * 1.75) + _offset, BaseLength);
        private static readonly Size _rectangleSize2 = new((BaseLength * 2) + _offset, BaseLength);
        private static readonly Size _rectangleSize2_75 = new(Convert.ToInt32(BaseLength * 2.75) + _offset, BaseLength);
        private static readonly Size _reverseRectangleSize2 = new(BaseLength, (BaseLength * 2) + _offset);
        private static readonly Size _spacebarSize = new(Convert.ToInt32(BaseLength * 5) + _offset, BaseLength);
        private static readonly Size _returnSize = new(Convert.ToInt32(BaseLength * 1.25), (BaseLength * 2) + _offset);

        // Dummy button
        private readonly Key _lockScreen = new();

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
            KeyResource.Escape.Size = _squareSizeHalfHeight;
            KeyResource.Escape.Text = "ESC";
            KeyResource.Escape.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Escape);

            KeyResource.F1.Size = _squareSizeHalfHeight;
            KeyResource.F1.Text = "F1";
            KeyResource.F1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F1);

            KeyResource.F2.Size = _squareSizeHalfHeight;
            KeyResource.F2.Text = "F2";
            KeyResource.F2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F2);

            KeyResource.F3.Size = _squareSizeHalfHeight;
            KeyResource.F3.Text = "F3";
            KeyResource.F3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F3);

            KeyResource.F4.Size = _squareSizeHalfHeight;
            KeyResource.F4.Text = "F4";
            KeyResource.F4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F4);

            KeyResource.F5.Size = _squareSizeHalfHeight;
            KeyResource.F5.Text = "F5";
            KeyResource.F5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F5);

            KeyResource.F6.Size = _squareSizeHalfHeight;
            KeyResource.F6.Text = "F6";
            KeyResource.F6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F6);

            KeyResource.F7.Size = _squareSizeHalfHeight;
            KeyResource.F7.Text = "F7";
            KeyResource.F7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F7);

            KeyResource.F8.Size = _squareSizeHalfHeight;
            KeyResource.F8.Text = "F8";
            KeyResource.F8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F8);

            KeyResource.F9.Size = _squareSizeHalfHeight;
            KeyResource.F9.Text = "F9";
            KeyResource.F9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F9);

            KeyResource.F10.Size = _squareSizeHalfHeight;
            KeyResource.F10.Text = "F10";
            KeyResource.F10.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F10);

            KeyResource.F11.Size = _squareSizeHalfHeight;
            KeyResource.F11.Text = "F11";
            KeyResource.F11.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F11);

            KeyResource.F12.Size = _squareSizeHalfHeight;
            KeyResource.F12.Text = "F12";
            KeyResource.F12.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F12);

            KeyResource.PrintScreen.Size = _squareSizeHalfHeight;
            KeyResource.PrintScreen.Text = "PRT SC\nSYS RQ";
            KeyResource.PrintScreen.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.PrintScreen);

            KeyResource.ScrollLock.Size = _squareSizeHalfHeight;
            KeyResource.ScrollLock.Text = "SCROLL";
            KeyResource.ScrollLock.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.ScrollLock);

            KeyResource.Pause.KeyCodeValue = (int)Keys.Pause;
            KeyResource.Pause.KeyCode = Keys.Pause;
            KeyResource.Pause.Name = "Pause";
            KeyResource.Pause.Size = _squareSizeHalfHeight;
            KeyResource.Pause.Text = "PAUSE\nBREAK";
            KeyResource.Pause.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.Pause);

            _lockScreen.KeyCodeValue = (int)Keys.None;  // No difference to LWin + L, use dummy value for now
            _lockScreen.KeyCode = Keys.None;
            _lockScreen.Name = "LockScreen";
            _lockScreen.Size = _squareSizeHalfHeight;
            _lockScreen.Text = "Lock";
            _lockScreen.TextAlign = ContentAlignment.MiddleCenter;
            _lockScreen.Enabled = false;
            AddKeyToLayout(_lockScreen);

            KeyResource.BrowserHome.Size = _squareSizeHalfHeight;
            KeyResource.BrowserHome.Text = "Browser";
            KeyResource.BrowserHome.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.BrowserHome);

            KeyResource.LaunchMail.Size = _squareSizeHalfHeight;
            KeyResource.LaunchMail.Text = "Mail";
            KeyResource.LaunchMail.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LaunchMail);

            KeyResource.LaunchApplication2.Size = _squareSizeHalfHeight;
            KeyResource.LaunchApplication2.Text = "Calc";
            KeyResource.LaunchApplication2.TextAlign = ContentAlignment.MiddleCenter;
            AddKeyToLayout(KeyResource.LaunchApplication2);

            KeyResource.Oem5.Size = _squareSize;
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

            KeyResource.Back.Size = _rectangleSize2;
            KeyResource.Back.Text = "←";
            KeyResource.Back.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Back);

            KeyResource.Insert.Size = _squareSize;
            KeyResource.Insert.Text = "INSERT";
            KeyResource.Insert.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Insert);

            KeyResource.Home.Size = _squareSize;
            KeyResource.Home.Text = "HOME";
            KeyResource.Home.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Home);

            KeyResource.PageUp.Size = _squareSize;
            KeyResource.PageUp.Text = "PAGE▴";
            KeyResource.PageUp.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.PageUp);

            KeyResource.NumLock.Size = _squareSize;
            KeyResource.NumLock.Text = "NUM";
            KeyResource.NumLock.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.NumLock);

            KeyResource.Divide.Size = _squareSize;
            KeyResource.Divide.Text = "/";
            KeyResource.Divide.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Divide);

            KeyResource.Multiply.Size = _squareSize;
            KeyResource.Multiply.Text = "*";
            KeyResource.Multiply.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Multiply);

            KeyResource.Subtract.Size = _squareSize;
            KeyResource.Subtract.Text = "-";
            KeyResource.Subtract.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Subtract);

            KeyResource.Tab.Size = _rectangleSize1_5;
            KeyResource.Tab.Text = "⭾";
            KeyResource.Tab.TextAlign = ContentAlignment.BottomLeft;
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

            KeyResource.Return.Size = _returnSize;
            KeyResource.Return.Text = "↩";
            KeyResource.Return.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Return);

            KeyResource.Delete.Size = _squareSize;
            KeyResource.Delete.Text = "DELETE";
            KeyResource.Delete.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Delete);

            KeyResource.End.Size = _squareSize;
            KeyResource.End.Text = "END";
            KeyResource.End.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.End);

            KeyResource.PageDown.Size = _squareSize;
            KeyResource.PageDown.Text = "PAGE▾";
            KeyResource.PageDown.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.PageDown);

            KeyResource.NumPad7.Size = _squareSize;
            KeyResource.NumPad7.Text = "7";
            KeyResource.NumPad7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad7);

            KeyResource.NumPad8.Size = _squareSize;
            KeyResource.NumPad8.Text = "8";
            KeyResource.NumPad8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad8);

            KeyResource.NumPad9.Size = _squareSize;
            KeyResource.NumPad9.Text = "9";
            KeyResource.NumPad9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad9);

            KeyResource.Add.Size = _reverseRectangleSize2;
            KeyResource.Add.Text = "+";
            KeyResource.Add.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Add);

            KeyResource.CapsLock.Size = _rectangleSize1_75;
            KeyResource.CapsLock.Text = "CAPS";
            KeyResource.CapsLock.TextAlign = ContentAlignment.BottomLeft;
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

            KeyResource.Oem3.Size = _squareSize;
            KeyResource.Oem3.Text = "Ö";
            KeyResource.Oem3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem3);

            KeyResource.Oem7.Size = _squareSize;
            KeyResource.Oem7.Text = "Ä";
            KeyResource.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem7);

            KeyResource.Oem2.Size = _squareSize;
            KeyResource.Oem2.Text = "*";
            KeyResource.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem2);

            KeyResource.NumPad4.Size = _squareSize;
            KeyResource.NumPad4.Text = "4";
            KeyResource.NumPad4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad4);

            KeyResource.NumPad5.Size = _squareSize;
            KeyResource.NumPad5.Text = "5";
            KeyResource.NumPad5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad5);

            KeyResource.NumPad6.Size = _squareSize;
            KeyResource.NumPad6.Text = "6";
            KeyResource.NumPad6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad6);

            KeyResource.LeftShift.Size = _rectangleSize1_25;
            KeyResource.LeftShift.Text = "↑";
            KeyResource.LeftShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftShift);

            KeyResource.Oem102.Size = _squareSize;
            KeyResource.Oem102.Text = ">\n<";
            KeyResource.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem102);

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
            KeyResource.OemComma.Text = ";\n,";
            KeyResource.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemComma);

            KeyResource.OemPeriod.Size = _squareSize;
            KeyResource.OemPeriod.Text = ":\n.";
            KeyResource.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemPeriod);

            KeyResource.OemMinus.Size = _squareSize;
            KeyResource.OemMinus.Text = "_\n-";
            KeyResource.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemMinus);

            KeyResource.RightShift.Size = _rectangleSize2_75;
            KeyResource.RightShift.Text = "↑";
            KeyResource.RightShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightShift);

            KeyResource.UpArrow.Size = _squareSize;
            KeyResource.UpArrow.Text = "△";
            KeyResource.UpArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.UpArrow);

            KeyResource.NumPad1.Size = _squareSize;
            KeyResource.NumPad1.Text = "1";
            KeyResource.NumPad1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad1);

            KeyResource.NumPad2.Size = _squareSize;
            KeyResource.NumPad2.Text = "2";
            KeyResource.NumPad2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad2);

            KeyResource.NumPad3.Size = _squareSize;
            KeyResource.NumPad3.Text = "3";
            KeyResource.NumPad3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad3);

            KeyResource.Enter.Size = _reverseRectangleSize2;
            KeyResource.Enter.Text = "ENTER";
            KeyResource.Enter.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Enter);

            KeyResource.LeftControl.Size = _rectangleSize1_7;
            KeyResource.LeftControl.Text = "CONTROL";
            KeyResource.LeftControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftControl);

            KeyResource.LeftWindows.Size = _rectangleSize1_5;
            KeyResource.LeftWindows.Text = "⊞";
            KeyResource.LeftWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftWindows);

            KeyResource.LeftAlt.Size = _rectangleSize1_5;
            KeyResource.LeftAlt.Text = "ALT";
            KeyResource.LeftAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftAlt);

            KeyResource.Spacebar.Size = _spacebarSize;
            KeyResource.Spacebar.Text = string.Empty;
            AddKeyToLayout(KeyResource.Spacebar);

            KeyResource.RightAlt.Size = _rectangleSize1_5;
            KeyResource.RightAlt.Text = "ALT GR";
            KeyResource.RightAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightAlt);

            KeyResource.RightWindows.Size = _rectangleSize1_25;
            KeyResource.RightWindows.Text = "⊞";
            KeyResource.RightWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightWindows);

            KeyResource.Applications.Size = _rectangleSize1_25;
            KeyResource.Applications.Text = "≣";
            KeyResource.Applications.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Applications);

            KeyResource.RightControl.Size = _rectangleSize1_25;
            KeyResource.RightControl.Text = "CONTROL";
            KeyResource.RightControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightControl);

            KeyResource.LeftArrow.Size = _squareSize;
            KeyResource.LeftArrow.Text = "◁";
            KeyResource.LeftArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.LeftArrow);

            KeyResource.DownArrow.Size = _squareSize;
            KeyResource.DownArrow.Text = "▽";
            KeyResource.DownArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.DownArrow);

            KeyResource.RightArrow.Size = _squareSize;
            KeyResource.RightArrow.Text = "▷";
            KeyResource.RightArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.RightArrow);

            KeyResource.NumPad0.Size = _rectangleSize2;
            KeyResource.NumPad0.Text = "0";
            KeyResource.NumPad0.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad0);

            KeyResource.Decimal.Size = _squareSize;
            KeyResource.Decimal.Text = ",";
            KeyResource.Decimal.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Decimal);
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