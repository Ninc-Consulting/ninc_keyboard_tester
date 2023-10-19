namespace KeyboardTesterApp.Models.KeyboardLayouts
{
    public class Iso105KeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseKeyWidth * 0.05);

        private static readonly Size _squareSize = new(BaseKeyWidth, BaseKeyWidth);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseKeyWidth * 1.25) + _offset, BaseKeyWidth);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseKeyWidth * 1.5) + _offset, BaseKeyWidth);
        private static readonly Size _rectangleSize1_7 = new(Convert.ToInt32(BaseKeyWidth * 1.7) + _offset, BaseKeyWidth);
        private static readonly Size _rectangleSize1_75 = new(Convert.ToInt32(BaseKeyWidth * 1.75) + _offset, BaseKeyWidth);
        private static readonly Size _rectangleSize2 = new((BaseKeyWidth * 2) + _offset, BaseKeyWidth);
        private static readonly Size _rectangleSize2_75 = new(Convert.ToInt32(BaseKeyWidth * 2.75) + _offset, BaseKeyWidth);
        private static readonly Size _reverseRectangleSize2 = new(BaseKeyWidth, (BaseKeyWidth * 2) + _offset);
        private static readonly Size _spacebarSize = new(Convert.ToInt32(BaseKeyWidth * 5) + _offset, BaseKeyWidth);
        private static readonly Size _returnSize = new(Convert.ToInt32(BaseKeyWidth * 1.25), (BaseKeyWidth * 2) + _offset);

        public Iso105KeyboardLayout(int baseKeyWidth)
            : base(baseKeyWidth)
        {
            KeyboardLayoutType = KeyboardLayoutType.ISO_105;
            InitiateKeys();
            SetCommonAttributes();
            DoLayout();
            SetKeyboardLayoutSize();
        }

        private void InitiateKeys()
        {
            Resources.Keys.Escape.Size = _squareSize;
            Resources.Keys.Escape.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Escape);

            Resources.Keys.F1.Size = _squareSize;
            Resources.Keys.F1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F1);

            Resources.Keys.F2.Size = _squareSize;
            Resources.Keys.F2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F2);

            Resources.Keys.F3.Size = _squareSize;
            Resources.Keys.F3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F3);

            Resources.Keys.F4.Size = _squareSize;
            Resources.Keys.F4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F4);

            Resources.Keys.F5.Size = _squareSize;
            Resources.Keys.F5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F5);

            Resources.Keys.F6.Size = _squareSize;
            Resources.Keys.F6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F6);

            Resources.Keys.F7.Size = _squareSize;
            Resources.Keys.F7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F7);

            Resources.Keys.F8.Size = _squareSize;
            Resources.Keys.F8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F8);

            Resources.Keys.F9.Size = _squareSize;
            Resources.Keys.F9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F9);

            Resources.Keys.F10.Size = _squareSize;
            Resources.Keys.F10.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F10);

            Resources.Keys.F11.Size = _squareSize;
            Resources.Keys.F11.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F11);

            Resources.Keys.F12.Size = _squareSize;
            Resources.Keys.F12.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F12);

            Resources.Keys.PrintScreen.Size = _squareSize;
            Resources.Keys.PrintScreen.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.PrintScreen);

            Resources.Keys.ScrollLock.Size = _squareSize;
            Resources.Keys.ScrollLock.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.ScrollLock);

            Resources.Keys.Pause.Size = _squareSize;
            Resources.Keys.Pause.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(Resources.Keys.Pause);

            Resources.Keys.Oem5.Size = _squareSize;
            Resources.Keys.Oem5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Oem5);

            Resources.Keys.D1.Size = _squareSize;
            Resources.Keys.D1.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D1);

            Resources.Keys.D2.Size = _squareSize;
            Resources.Keys.D2.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D2);

            Resources.Keys.D3.Size = _squareSize;
            Resources.Keys.D3.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D3);

            Resources.Keys.D4.Size = _squareSize;
            Resources.Keys.D4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D4);

            Resources.Keys.D5.Size = _squareSize;
            Resources.Keys.D5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D5);

            Resources.Keys.D6.Size = _squareSize;
            Resources.Keys.D6.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D6);

            Resources.Keys.D7.Size = _squareSize;
            Resources.Keys.D7.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D7);

            Resources.Keys.D8.Size = _squareSize;
            Resources.Keys.D8.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D8);

            Resources.Keys.D9.Size = _squareSize;
            Resources.Keys.D9.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D9);

            Resources.Keys.D0.Size = _squareSize;
            Resources.Keys.D0.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.D0);

            Resources.Keys.OemPlus.Size = _squareSize;
            Resources.Keys.OemPlus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemPlus);

            Resources.Keys.Oem4.Size = _squareSize;
            Resources.Keys.Oem4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Oem4);

            Resources.Keys.Back.Size = _rectangleSize2;
            Resources.Keys.Back.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Back);

            Resources.Keys.Insert.Size = _squareSize;
            Resources.Keys.Insert.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.Insert);

            Resources.Keys.Home.Size = _squareSize;
            Resources.Keys.Home.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.Home);

            Resources.Keys.PageUp.Size = _squareSize;
            Resources.Keys.PageUp.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.PageUp);

            Resources.Keys.NumLock.Size = _squareSize;
            Resources.Keys.NumLock.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.NumLock);

            Resources.Keys.Divide.Size = _squareSize;
            Resources.Keys.Divide.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Divide);

            Resources.Keys.Multiply.Size = _squareSize;
            Resources.Keys.Multiply.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Multiply);

            Resources.Keys.Subtract.Size = _squareSize;
            Resources.Keys.Subtract.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Subtract);

            Resources.Keys.Tab.Size = _rectangleSize1_5;
            Resources.Keys.Tab.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Tab);

            Resources.Keys.Q.Size = _squareSize;
            Resources.Keys.Q.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Q);

            Resources.Keys.W.Size = _squareSize;
            Resources.Keys.W.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.W);

            Resources.Keys.E.Size = _squareSize;
            Resources.Keys.E.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.E);

            Resources.Keys.R.Size = _squareSize;
            Resources.Keys.R.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.R);

            Resources.Keys.T.Size = _squareSize;
            Resources.Keys.T.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.T);

            Resources.Keys.Y.Size = _squareSize;
            Resources.Keys.Y.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Y);

            Resources.Keys.U.Size = _squareSize;
            Resources.Keys.U.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.U);

            Resources.Keys.I.Size = _squareSize;
            Resources.Keys.I.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.I);

            Resources.Keys.O.Size = _squareSize;
            Resources.Keys.O.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.O);

            Resources.Keys.P.Size = _squareSize;
            Resources.Keys.P.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.P);

            Resources.Keys.Oem6.Size = _squareSize;
            Resources.Keys.Oem6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem6);

            Resources.Keys.Oem1.Size = _squareSize;
            Resources.Keys.Oem1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem1);

            Resources.Keys.Return.Size = _returnSize;
            Resources.Keys.Return.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Return);

            Resources.Keys.Delete.Size = _squareSize;
            Resources.Keys.Delete.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.Delete);

            Resources.Keys.End.Size = _squareSize;
            Resources.Keys.End.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.End);

            Resources.Keys.PageDown.Size = _squareSize;
            Resources.Keys.PageDown.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.PageDown);

            Resources.Keys.NumPad7.Size = _squareSize;
            Resources.Keys.NumPad7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad7);

            Resources.Keys.NumPad8.Size = _squareSize;
            Resources.Keys.NumPad8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad8);

            Resources.Keys.NumPad9.Size = _squareSize;
            Resources.Keys.NumPad9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad9);

            Resources.Keys.Add.Size = _reverseRectangleSize2;
            Resources.Keys.Add.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Add);

            Resources.Keys.CapsLock.Size = _rectangleSize1_75;
            Resources.Keys.CapsLock.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.CapsLock);

            Resources.Keys.A.Size = _squareSize;
            Resources.Keys.A.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.A);

            Resources.Keys.S.Size = _squareSize;
            Resources.Keys.S.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.S);

            Resources.Keys.D.Size = _squareSize;
            Resources.Keys.D.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.D);

            Resources.Keys.F.Size = _squareSize;
            Resources.Keys.F.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.F);

            Resources.Keys.G.Size = _squareSize;
            Resources.Keys.G.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.G);

            Resources.Keys.H.Size = _squareSize;
            Resources.Keys.H.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.H);

            Resources.Keys.J.Size = _squareSize;
            Resources.Keys.J.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.J);

            Resources.Keys.K.Size = _squareSize;
            Resources.Keys.K.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.K);

            Resources.Keys.L.Size = _squareSize;
            Resources.Keys.L.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.L);

            Resources.Keys.OemTilde.Size = _squareSize;
            Resources.Keys.OemTilde.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.OemTilde);

            Resources.Keys.Oem7.Size = _squareSize;
            Resources.Keys.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem7);

            Resources.Keys.Oem2.Size = _squareSize;
            Resources.Keys.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem2);

            Resources.Keys.NumPad4.Size = _squareSize;
            Resources.Keys.NumPad4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad4);

            Resources.Keys.NumPad5.Size = _squareSize;
            Resources.Keys.NumPad5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad5);

            Resources.Keys.NumPad6.Size = _squareSize;
            Resources.Keys.NumPad6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad6);

            Resources.Keys.LeftShift.Size = _rectangleSize1_25;
            Resources.Keys.LeftShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.LeftShift);

            Resources.Keys.Oem102.Size = _squareSize;
            Resources.Keys.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Oem102);

            Resources.Keys.Z.Size = _squareSize;
            Resources.Keys.Z.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Z);

            Resources.Keys.X.Size = _squareSize;
            Resources.Keys.X.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.X);

            Resources.Keys.C.Size = _squareSize;
            Resources.Keys.C.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.C);

            Resources.Keys.V.Size = _squareSize;
            Resources.Keys.V.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.V);

            Resources.Keys.B.Size = _squareSize;
            Resources.Keys.B.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.B);

            Resources.Keys.N.Size = _squareSize;
            Resources.Keys.N.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.N);

            Resources.Keys.M.Size = _squareSize;
            Resources.Keys.M.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.M);

            Resources.Keys.OemComma.Size = _squareSize;
            Resources.Keys.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemComma);

            Resources.Keys.OemPeriod.Size = _squareSize;
            Resources.Keys.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemPeriod);

            Resources.Keys.OemMinus.Size = _squareSize;
            Resources.Keys.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.OemMinus);

            Resources.Keys.RightShift.Size = _rectangleSize2_75;
            Resources.Keys.RightShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.RightShift);

            Resources.Keys.UpArrow.Size = _squareSize;
            Resources.Keys.UpArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.UpArrow);

            Resources.Keys.NumPad1.Size = _squareSize;
            Resources.Keys.NumPad1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad1);

            Resources.Keys.NumPad2.Size = _squareSize;
            Resources.Keys.NumPad2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad2);

            Resources.Keys.NumPad3.Size = _squareSize;
            Resources.Keys.NumPad3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad3);

            Resources.Keys.Enter.Size = _reverseRectangleSize2;
            Resources.Keys.Enter.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(Resources.Keys.Enter);

            Resources.Keys.LeftControl.Size = _rectangleSize1_7;
            Resources.Keys.LeftControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.LeftControl);

            Resources.Keys.LeftWindows.Size = _rectangleSize1_5;
            Resources.Keys.LeftWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.LeftWindows);

            Resources.Keys.LeftAlt.Size = _rectangleSize1_5;
            Resources.Keys.LeftAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.LeftAlt);

            Resources.Keys.Spacebar.Size = _spacebarSize;
            Resources.Keys.Spacebar.Text = string.Empty;
            AddKeyToLayout(Resources.Keys.Spacebar);

            Resources.Keys.RightAlt.Size = _rectangleSize1_5;
            Resources.Keys.RightAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.RightAlt);

            Resources.Keys.RightWindows.Size = _rectangleSize1_25;
            Resources.Keys.RightWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.RightWindows);

            Resources.Keys.Applications.Size = _rectangleSize1_25;
            Resources.Keys.Applications.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.Applications);

            Resources.Keys.RightControl.Size = _rectangleSize1_25;
            Resources.Keys.RightControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(Resources.Keys.RightControl);

            Resources.Keys.LeftArrow.Size = _squareSize;
            Resources.Keys.LeftArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.LeftArrow);

            Resources.Keys.DownArrow.Size = _squareSize;
            Resources.Keys.DownArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.DownArrow);

            Resources.Keys.RightArrow.Size = _squareSize;
            Resources.Keys.RightArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.RightArrow);

            Resources.Keys.NumPad0.Size = _rectangleSize2;
            Resources.Keys.NumPad0.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.NumPad0);

            Resources.Keys.Decimal.Size = _squareSize;
            Resources.Keys.Decimal.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(Resources.Keys.Decimal);

            Resources.Keys.Clear.Hide();
            AddKeyToLayout(Resources.Keys.Clear);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth / 2;
            var yCoordinate = BaseKeyWidth;

            foreach (var key in LayoutKeys.Values)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.KeyCode == Keys.F4 || key.KeyCode == Keys.F12 || key.KeyCode == Keys.Pause)
                {
                    xCoordinate += BaseKeyWidth / 2;
                }
                else if (key.KeyCode == Keys.F8)
                {
                    xCoordinate += (BaseKeyWidth / 2) + _offset;
                }
                else if (key.KeyCode == Keys.Escape)
                {
                    xCoordinate += BaseKeyWidth + _offset;
                }
                else if (key.KeyCode == Keys.Back || key.KeyCode == Keys.PageUp || (key.KeyCode == Keys.Return && key.KeyCodeValue > 0) || key.KeyCode == Keys.PageDown || key.KeyCode == Keys.RControlKey || key.KeyCode == Keys.Right)
                {
                    xCoordinate += BaseKeyWidth / 2;
                }
                else if (key.KeyCode == Keys.Oem1)
                {
                    xCoordinate += Convert.ToInt32(BaseKeyWidth * 0.20) + _offset;
                }
                else if (key.KeyCode == Keys.Oem2)
                {
                    xCoordinate += Convert.ToInt32((BaseKeyWidth * 5.25) + (4 * _offset));
                }
                else if (key.KeyCode == Keys.RShiftKey || key.KeyCode == Keys.Up)
                {
                    xCoordinate += Convert.ToInt32((BaseKeyWidth * 1.5) + _offset);
                }

                // New row
                if (key.KeyCode == Keys.Pause)
                {
                    xCoordinate = BaseKeyWidth / 2;
                    yCoordinate += Convert.ToInt32(key.Height * 1.5);
                }
                else if (key.KeyCode == Keys.Subtract || key.KeyCode == Keys.Add || key.KeyCode == Keys.NumPad6 || (key.KeyCode == Keys.Enter && key.KeyCodeValue < 0))
                {
                    xCoordinate = BaseKeyWidth / 2;
                    yCoordinate += BaseKeyWidth + _offset;
                }
            }
        }
    }
}