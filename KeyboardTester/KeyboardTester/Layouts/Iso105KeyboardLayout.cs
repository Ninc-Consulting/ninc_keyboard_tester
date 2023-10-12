namespace KeyboardTester.Layouts
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
            KeyResource.Escape.Size = _squareSize;
            KeyResource.Escape.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Escape);

            KeyResource.F1.Size = _squareSize;
            KeyResource.F1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F1);

            KeyResource.F2.Size = _squareSize;
            KeyResource.F2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F2);

            KeyResource.F3.Size = _squareSize;
            KeyResource.F3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F3);

            KeyResource.F4.Size = _squareSize;
            KeyResource.F4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F4);

            KeyResource.F5.Size = _squareSize;
            KeyResource.F5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F5);

            KeyResource.F6.Size = _squareSize;
            KeyResource.F6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F6);

            KeyResource.F7.Size = _squareSize;
            KeyResource.F7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F7);

            KeyResource.F8.Size = _squareSize;
            KeyResource.F8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F8);

            KeyResource.F9.Size = _squareSize;
            KeyResource.F9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F9);

            KeyResource.F10.Size = _squareSize;
            KeyResource.F10.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F10);

            KeyResource.F11.Size = _squareSize;
            KeyResource.F11.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F11);

            KeyResource.F12.Size = _squareSize;
            KeyResource.F12.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F12);

            KeyResource.PrintScreen.Size = _squareSize;
            KeyResource.PrintScreen.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.PrintScreen);

            KeyResource.ScrollLock.Size = _squareSize;
            KeyResource.ScrollLock.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.ScrollLock);

            KeyResource.Pause.Size = _squareSize;
            KeyResource.Pause.TextAlign = ContentAlignment.TopCenter;
            AddKeyToLayout(KeyResource.Pause);

            KeyResource.Oem5.Size = _squareSize;
            KeyResource.Oem5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Oem5);

            KeyResource.D1.Size = _squareSize;
            KeyResource.D1.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D1);

            KeyResource.D2.Size = _squareSize;
            KeyResource.D2.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D2);

            KeyResource.D3.Size = _squareSize;
            KeyResource.D3.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D3);

            KeyResource.D4.Size = _squareSize;
            KeyResource.D4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D4);

            KeyResource.D5.Size = _squareSize;
            KeyResource.D5.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D5);

            KeyResource.D6.Size = _squareSize;
            KeyResource.D6.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D6);

            KeyResource.D7.Size = _squareSize;
            KeyResource.D7.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D7);

            KeyResource.D8.Size = _squareSize;
            KeyResource.D8.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D8);

            KeyResource.D9.Size = _squareSize;
            KeyResource.D9.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D9);

            KeyResource.D0.Size = _squareSize;
            KeyResource.D0.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.D0);

            KeyResource.OemPlus.Size = _squareSize;
            KeyResource.OemPlus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemPlus);

            KeyResource.Oem4.Size = _squareSize;
            KeyResource.Oem4.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Oem4);

            KeyResource.Back.Size = _rectangleSize2;
            KeyResource.Back.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Back);

            KeyResource.Insert.Size = _squareSize;
            KeyResource.Insert.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Insert);

            KeyResource.Home.Size = _squareSize;
            KeyResource.Home.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Home);

            KeyResource.PageUp.Size = _squareSize;
            KeyResource.PageUp.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.PageUp);

            KeyResource.NumLock.Size = _squareSize;
            KeyResource.NumLock.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.NumLock);

            KeyResource.Divide.Size = _squareSize;
            KeyResource.Divide.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Divide);

            KeyResource.Multiply.Size = _squareSize;
            KeyResource.Multiply.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Multiply);

            KeyResource.Subtract.Size = _squareSize;
            KeyResource.Subtract.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Subtract);

            KeyResource.Tab.Size = _rectangleSize1_5;
            KeyResource.Tab.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Tab);

            KeyResource.Q.Size = _squareSize;
            KeyResource.Q.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Q);

            KeyResource.W.Size = _squareSize;
            KeyResource.W.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.W);

            KeyResource.E.Size = _squareSize;
            KeyResource.E.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.E);

            KeyResource.R.Size = _squareSize;
            KeyResource.R.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.R);

            KeyResource.T.Size = _squareSize;
            KeyResource.T.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.T);

            KeyResource.Y.Size = _squareSize;
            KeyResource.Y.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Y);

            KeyResource.U.Size = _squareSize;
            KeyResource.U.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.U);

            KeyResource.I.Size = _squareSize;
            KeyResource.I.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.I);

            KeyResource.O.Size = _squareSize;
            KeyResource.O.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.O);

            KeyResource.P.Size = _squareSize;
            KeyResource.P.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.P);

            KeyResource.Oem6.Size = _squareSize;
            KeyResource.Oem6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem6);

            KeyResource.Oem1.Size = _squareSize;
            KeyResource.Oem1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem1);

            KeyResource.Return.Size = _returnSize;
            KeyResource.Return.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Return);

            KeyResource.Delete.Size = _squareSize;
            KeyResource.Delete.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Delete);

            KeyResource.End.Size = _squareSize;
            KeyResource.End.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.End);

            KeyResource.PageDown.Size = _squareSize;
            KeyResource.PageDown.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.PageDown);

            KeyResource.NumPad7.Size = _squareSize;
            KeyResource.NumPad7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad7);

            KeyResource.NumPad8.Size = _squareSize;
            KeyResource.NumPad8.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad8);

            KeyResource.NumPad9.Size = _squareSize;
            KeyResource.NumPad9.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad9);

            KeyResource.Add.Size = _reverseRectangleSize2;
            KeyResource.Add.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Add);

            KeyResource.CapsLock.Size = _rectangleSize1_75;
            KeyResource.CapsLock.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.CapsLock);

            KeyResource.A.Size = _squareSize;
            KeyResource.A.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.A);

            KeyResource.S.Size = _squareSize;
            KeyResource.S.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.S);

            KeyResource.D.Size = _squareSize;
            KeyResource.D.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.D);

            KeyResource.F.Size = _squareSize;
            KeyResource.F.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.F);

            KeyResource.G.Size = _squareSize;
            KeyResource.G.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.G);

            KeyResource.H.Size = _squareSize;
            KeyResource.H.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.H);

            KeyResource.J.Size = _squareSize;
            KeyResource.J.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.J);

            KeyResource.K.Size = _squareSize;
            KeyResource.K.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.K);

            KeyResource.L.Size = _squareSize;
            KeyResource.L.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.L);

            KeyResource.OemTilde.Size = _squareSize;
            KeyResource.OemTilde.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.OemTilde);

            KeyResource.Oem7.Size = _squareSize;
            KeyResource.Oem7.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem7);

            KeyResource.Oem2.Size = _squareSize;
            KeyResource.Oem2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem2);

            KeyResource.NumPad4.Size = _squareSize;
            KeyResource.NumPad4.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad4);

            KeyResource.NumPad5.Size = _squareSize;
            KeyResource.NumPad5.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad5);

            KeyResource.NumPad6.Size = _squareSize;
            KeyResource.NumPad6.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad6);

            KeyResource.LeftShift.Size = _rectangleSize1_25;
            KeyResource.LeftShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftShift);

            KeyResource.Oem102.Size = _squareSize;
            KeyResource.Oem102.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Oem102);

            KeyResource.Z.Size = _squareSize;
            KeyResource.Z.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Z);

            KeyResource.X.Size = _squareSize;
            KeyResource.X.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.X);

            KeyResource.C.Size = _squareSize;
            KeyResource.C.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.C);

            KeyResource.V.Size = _squareSize;
            KeyResource.V.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.V);

            KeyResource.B.Size = _squareSize;
            KeyResource.B.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.B);

            KeyResource.N.Size = _squareSize;
            KeyResource.N.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.N);

            KeyResource.M.Size = _squareSize;
            KeyResource.M.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.M);

            KeyResource.OemComma.Size = _squareSize;
            KeyResource.OemComma.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemComma);

            KeyResource.OemPeriod.Size = _squareSize;
            KeyResource.OemPeriod.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemPeriod);

            KeyResource.OemMinus.Size = _squareSize;
            KeyResource.OemMinus.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.OemMinus);

            KeyResource.RightShift.Size = _rectangleSize2_75;
            KeyResource.RightShift.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightShift);

            KeyResource.UpArrow.Size = _squareSize;
            KeyResource.UpArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.UpArrow);

            KeyResource.NumPad1.Size = _squareSize;
            KeyResource.NumPad1.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad1);

            KeyResource.NumPad2.Size = _squareSize;
            KeyResource.NumPad2.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad2);

            KeyResource.NumPad3.Size = _squareSize;
            KeyResource.NumPad3.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad3);

            KeyResource.Enter.Size = _reverseRectangleSize2;
            KeyResource.Enter.TextAlign = ContentAlignment.BottomCenter;
            AddKeyToLayout(KeyResource.Enter);

            KeyResource.LeftControl.Size = _rectangleSize1_7;
            KeyResource.LeftControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftControl);

            KeyResource.LeftWindows.Size = _rectangleSize1_5;
            KeyResource.LeftWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftWindows);

            KeyResource.LeftAlt.Size = _rectangleSize1_5;
            KeyResource.LeftAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.LeftAlt);

            KeyResource.Spacebar.Size = _spacebarSize;
            KeyResource.Spacebar.Text = string.Empty;
            AddKeyToLayout(KeyResource.Spacebar);

            KeyResource.RightAlt.Size = _rectangleSize1_5;
            KeyResource.RightAlt.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightAlt);

            KeyResource.RightWindows.Size = _rectangleSize1_25;
            KeyResource.RightWindows.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightWindows);

            KeyResource.Applications.Size = _rectangleSize1_25;
            KeyResource.Applications.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.Applications);

            KeyResource.RightControl.Size = _rectangleSize1_25;
            KeyResource.RightControl.TextAlign = ContentAlignment.BottomLeft;
            AddKeyToLayout(KeyResource.RightControl);

            KeyResource.LeftArrow.Size = _squareSize;
            KeyResource.LeftArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.LeftArrow);

            KeyResource.DownArrow.Size = _squareSize;
            KeyResource.DownArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.DownArrow);

            KeyResource.RightArrow.Size = _squareSize;
            KeyResource.RightArrow.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.RightArrow);

            KeyResource.NumPad0.Size = _rectangleSize2;
            KeyResource.NumPad0.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.NumPad0);

            KeyResource.Decimal.Size = _squareSize;
            KeyResource.Decimal.TextAlign = ContentAlignment.TopLeft;
            AddKeyToLayout(KeyResource.Decimal);

            KeyResource.Clear.Hide();
            AddKeyToLayout(KeyResource.Clear);
        }

        private void DoLayout()
        {
            var xCoordinate = BaseKeyWidth;
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
                    xCoordinate = BaseKeyWidth;
                    yCoordinate += Convert.ToInt32(key.Height * 1.5);
                }
                else if (key.KeyCode == Keys.Subtract || key.KeyCode == Keys.Add || key.KeyCode == Keys.NumPad6 || (key.KeyCode == Keys.Enter && key.KeyCodeValue < 0))
                {
                    xCoordinate = BaseKeyWidth;
                    yCoordinate += BaseKeyWidth + _offset;
                }
            }
        }
    }
}