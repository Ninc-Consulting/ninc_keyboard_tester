using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace KeyboardTester.KeyboardLayouts
{
    public class CherryKeyboardLayout : KeyboardLayout
    {
        // Keys
        private readonly Key _oem5 = new();
        private readonly Key _d0 = new();
        private readonly Key _d1 = new();
        private readonly Key _d2 = new();
        private readonly Key _d3 = new();
        private readonly Key _d4 = new();
        private readonly Key _d5 = new();
        private readonly Key _d6 = new();
        private readonly Key _d7 = new();
        private readonly Key _d8 = new();
        private readonly Key _d9 = new();
        private readonly Key _oemplus = new();
        private readonly Key _oemOpenBrackets = new();
        private readonly Key _back = new();
        private readonly Key _insert = new();
        private readonly Key _home = new();
        private readonly Key _pageUp = new();
        private readonly Key _numLock = new();
        private readonly Key _divide = new();
        private readonly Key _multiply = new();
        private readonly Key _subtract = new();
        private readonly Key _tab = new();
        private readonly Key _q = new();
        private readonly Key _w = new();
        private readonly Key _e = new();
        private readonly Key _r = new();
        private readonly Key _t = new();
        private readonly Key _y = new();
        private readonly Key _u = new();
        private readonly Key _i = new();
        private readonly Key _o = new();
        private readonly Key _p = new();
        private readonly Key _oem6 = new();
        private readonly Key _oem1 = new();
        private readonly Key _return = new();
        private readonly Key _delete = new();
        private readonly Key _end = new();
        private readonly Key _pageDown = new();
        private readonly Key _numPad7 = new();
        private readonly Key _numPad8 = new();
        private readonly Key _numPad9 = new();
        private readonly Key _add = new();
        private readonly Key _escape = new();
        private readonly Key _f1 = new();
        private readonly Key _f2 = new();
        private readonly Key _f3 = new();
        private readonly Key _f4 = new();
        private readonly Key _f5 = new();
        private readonly Key _f6 = new();
        private readonly Key _f7 = new();
        private readonly Key _f8 = new();
        private readonly Key _f9 = new();
        private readonly Key _f10 = new();
        private readonly Key _f11 = new();
        private readonly Key _f12 = new();
        private readonly Key _printScreen = new();
        private readonly Key _scroll = new();
        private readonly Key _paus = new();
        private readonly Key _lWin = new();
        private readonly Key _browserHome = new();
        private readonly Key _launchMail = new();
        private readonly Key _calculator = new();
        private readonly Key _caps = new();
        private readonly Key _a = new();
        private readonly Key _s = new();
        private readonly Key _d = new();
        private readonly Key _f = new();
        private readonly Key _g = new();
        private readonly Key _h = new();
        private readonly Key _j = new();
        private readonly Key _k = new();
        private readonly Key _l = new();
        private readonly Key _oemtilde = new();
        private readonly Key _oem7 = new();
        private readonly Key _oemQuestion = new();
        private readonly Key _numPad4 = new();
        private readonly Key _numPad5 = new();
        private readonly Key _numPad6 = new();
        private readonly Key _leftShift = new();
        private readonly Key _oemBackslash = new();
        private readonly Key _z = new();
        private readonly Key _x = new();
        private readonly Key _c = new();
        private readonly Key _v = new();
        private readonly Key _b = new();
        private readonly Key _n = new();
        private readonly Key _m = new();
        private readonly Key _oemComma = new();
        private readonly Key _oemPeriod = new();
        private readonly Key _oemMinus = new();
        private readonly Key _rightShift = new();

        // Sizes
        private static readonly int _baseHeight = 122;
        private static readonly int _baseWidth = 122;
        private static readonly int _offset = 5;
        private static readonly Size _squareSize = new(_baseWidth, _baseHeight);  
        private static readonly Size _squareSizeHalfHeight = new(_baseWidth, _baseHeight / 2);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(_baseWidth * 1.25) + _offset, _baseHeight);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(_baseWidth * 1.5) + _offset, _baseHeight);
        private static readonly Size _rectangleSize1_75 = new(Convert.ToInt32(_baseWidth * 1.75) + _offset, _baseHeight);
        private static readonly Size _rectangleSize2 = new(_baseWidth * 2 + _offset, _baseHeight);
        private static readonly Size _rectangleSize2_5 = new(Convert.ToInt32(_baseWidth * 2.5) + _offset, _baseHeight);
        private static readonly Size _reverseRectangleSize2 = new(_baseWidth, _baseHeight * 2 + _offset);

        private static readonly Font _font = new Font("Segoe UI", 8);
        public CherryKeyboardLayout(ControlCollection controls, Margins margins)
        {
            InitiateKeys(margins);
            SetCommonAttributes();
            base.AddControls(controls);
        }

        private void InitiateKeys(Margins margins)
        {
            var rowKeys = InitiateFirstRow();
            PositionFirstRow(rowKeys, margins);
            AddKeysToBaseClass(rowKeys);

            var startingYCoordinate = rowKeys.First().Location.Y + rowKeys.First().Height + _squareSizeHalfHeight.Height;
            rowKeys = InitiateSecondRow();
            PositionSecondRow(rowKeys, startingYCoordinate, margins);
            AddKeysToBaseClass(rowKeys);

            startingYCoordinate = rowKeys.First().Location.Y + rowKeys.First().Height + _offset;
            rowKeys = InitiateThirdRow();
            PositionThirdRow(rowKeys, startingYCoordinate, margins);
            AddKeysToBaseClass(rowKeys);

            startingYCoordinate = rowKeys.First().Location.Y + rowKeys.First().Height + _offset;
            rowKeys = InitiateFourthRow();
            PositionFourthRow(rowKeys, startingYCoordinate, margins);
            AddKeysToBaseClass(rowKeys);

            startingYCoordinate = rowKeys.First().Location.Y + rowKeys.First().Height + _offset;
            rowKeys = InitiateFifthRow();
            PositionFifthRow(rowKeys, startingYCoordinate, margins);
            AddKeysToBaseClass(rowKeys);

            SetKeyboardLayoutSize(rowKeys, margins);
        }

        #region FirstRow
        private List<Key> InitiateFirstRow()
        {
            var keys = new List<Key>();

            _escape.KeyValue = 27;
            _escape.KeyCode = "Escape";
            _escape.KeyData = "Escape";
            _escape.Name = "Escape";
            _escape.Size = _squareSizeHalfHeight;
            _escape.Text = "ESC";
            _escape.TextAlign = ContentAlignment.TopLeft;
            _escape.UseVisualStyleBackColor = true;
            keys.Add(_escape);

            _f1.KeyValue = 112;
            _f1.KeyCode = "F1";
            _f1.KeyData = "F1";
            _f1.Name = "F1";
            _f1.Size = _squareSizeHalfHeight;
            _f1.Text = "F1";
            _f1.TextAlign = ContentAlignment.TopLeft;
            _f1.UseVisualStyleBackColor = true;
            keys.Add(_f1);

            _f2.KeyValue = 113;
            _f2.KeyCode = "F2";
            _f2.KeyData = "F2";
            _f2.Name = "F2";
            _f2.Size = _squareSizeHalfHeight;
            _f2.Text = "F2";
            _f2.TextAlign = ContentAlignment.TopLeft;
            _f2.UseVisualStyleBackColor = true;
            keys.Add(_f2);

            _f3.KeyValue = 114;
            _f3.KeyCode = "F3";
            _f3.KeyData = "F3";
            _f3.Name = "F3";
            _f3.Size = _squareSizeHalfHeight;
            _f3.Text = "F3";
            _f3.TextAlign = ContentAlignment.TopLeft;
            _f3.UseVisualStyleBackColor = true;
            keys.Add(_f3);

            _f4.KeyValue = 115;
            _f4.KeyCode = "F4";
            _f4.KeyData = "F4";
            _f4.Name = "F4";
            _f4.Size = _squareSizeHalfHeight;
            _f4.Text = "F4";
            _f4.TextAlign = ContentAlignment.TopLeft;
            _f4.UseVisualStyleBackColor = true;
            keys.Add(_f4);

            _f5.KeyValue = 116;
            _f5.KeyCode = "F5";
            _f5.KeyData = "F5";
            _f5.Name = "F5";
            _f5.Size = _squareSizeHalfHeight;
            _f5.Text = "F5";
            _f5.TextAlign = ContentAlignment.TopLeft;
            _f5.UseVisualStyleBackColor = true;
            keys.Add(_f5);

            _f6.KeyValue = 117;
            _f6.KeyCode = "F6";
            _f6.KeyData = "F6";
            _f6.Name = "F6";
            _f6.Size = _squareSizeHalfHeight;
            _f6.Text = "F6";
            _f6.TextAlign = ContentAlignment.TopLeft;
            _f6.UseVisualStyleBackColor = true;
            keys.Add(_f6);

            _f7.KeyValue = 118;
            _f7.KeyCode = "F7";
            _f7.KeyData = "F7";
            _f7.Name = "F7";
            _f7.Size = _squareSizeHalfHeight;
            _f7.Text = "F7";
            _f7.TextAlign = ContentAlignment.TopLeft;
            _f7.UseVisualStyleBackColor = true;
            keys.Add(_f7);

            _f8.KeyValue = 119;
            _f8.KeyCode = "F8";
            _f8.KeyData = "F8";
            _f8.Name = "F8";
            _f8.Size = _squareSizeHalfHeight;
            _f8.Text = "F8";
            _f8.TextAlign = ContentAlignment.TopLeft;
            _f8.UseVisualStyleBackColor = true;
            keys.Add(_f8);

            _f9.KeyValue = 120;
            _f9.KeyCode = "F9";
            _f9.KeyData = "F9";
            _f9.Name = "F9";
            _f9.Size = _squareSizeHalfHeight;
            _f9.Text = "F9";
            _f9.TextAlign = ContentAlignment.TopLeft;
            _f9.UseVisualStyleBackColor = true;
            keys.Add(_f9);

            _f10.KeyValue = 121;
            _f10.KeyCode = "F10";
            _f10.KeyData = "F10";
            _f10.Name = "F10";
            _f10.Size = _squareSizeHalfHeight;
            _f10.Text = "F10";
            _f10.TextAlign = ContentAlignment.TopLeft;
            _f10.UseVisualStyleBackColor = true;
            keys.Add(_f10);

            _f11.KeyValue = 122;
            _f11.KeyCode = "F11";
            _f11.KeyData = "F11";
            _f11.Name = "F11";
            _f11.Size = _squareSizeHalfHeight;
            _f11.Text = "F11";
            _f11.TextAlign = ContentAlignment.TopLeft;
            _f11.UseVisualStyleBackColor = true;
            keys.Add(_f11);

            _f12.KeyValue = 123;
            _f12.KeyCode = "F12";
            _f12.KeyData = "F12";
            _f12.Name = "F12";
            _f12.Size = _squareSizeHalfHeight;
            _f12.Text = "F12";
            _f12.TextAlign = ContentAlignment.TopLeft;
            _f12.UseVisualStyleBackColor = true;
            keys.Add(_f12);

            _printScreen.KeyValue = -1;
            _printScreen.KeyCode = "PrintScreen";
            _printScreen.KeyData = "PrintScreen";
            _printScreen.Name = "PrintScreen";
            _printScreen.Size = _squareSizeHalfHeight;
            _printScreen.Text = "PRT SC\nSYS RQ";
            _printScreen.TextAlign = ContentAlignment.TopCenter;
            _printScreen.UseVisualStyleBackColor = true;
            keys.Add(_printScreen);

            _scroll.KeyValue = 145;
            _scroll.KeyCode = "Scroll";
            _scroll.KeyData = "Scroll";
            _scroll.Name = "Scroll";
            _scroll.Size = _squareSizeHalfHeight;
            _scroll.Text = "SCROLL";
            _scroll.TextAlign = ContentAlignment.TopCenter;
            _scroll.UseVisualStyleBackColor = true;
            keys.Add(_scroll);

            _paus.KeyValue = 19;
            _paus.KeyCode = "Paus";
            _paus.KeyData = "Paus";
            _paus.Name = "Paus";
            _paus.Size = _squareSizeHalfHeight;
            _paus.Text = "PAUS\nBREAK";
            _paus.TextAlign = ContentAlignment.TopCenter;
            _paus.UseVisualStyleBackColor = true;
            keys.Add(_paus);

            _lWin.KeyValue = 91;
            _lWin.KeyCode = "LWin";
            _lWin.KeyData = "LWin";
            _lWin.Name = "LWin";
            _lWin.Size = _squareSizeHalfHeight;
            _lWin.Text = "Lock";
            _lWin.TextAlign = ContentAlignment.MiddleCenter;
            _lWin.UseVisualStyleBackColor = true;
            keys.Add(_lWin);

            _browserHome.KeyValue = 172;
            _browserHome.KeyCode = "BrowserHome";
            _browserHome.KeyData = "BrowserHome";
            _browserHome.Name = "BrowserHome";
            _browserHome.Size = _squareSizeHalfHeight;
            _browserHome.Text = "Browser";
            _browserHome.TextAlign = ContentAlignment.MiddleCenter;
            _browserHome.UseVisualStyleBackColor = true;
            keys.Add(_browserHome);

            _launchMail.KeyValue = 180;
            _launchMail.KeyCode = "LaunchMail";
            _launchMail.KeyData = "LaunchMail";
            _launchMail.Name = "LaunchMail";
            _launchMail.Size = _squareSizeHalfHeight;
            _launchMail.Text = "Mail";
            _launchMail.TextAlign = ContentAlignment.MiddleCenter;
            _launchMail.UseVisualStyleBackColor = true;
            keys.Add(_launchMail);

            _calculator.KeyValue = 183;
            _calculator.KeyCode = "LaunchApplication2";
            _calculator.KeyData = "LaunchApplication2";
            _calculator.Name = "LaunchApplication2";
            _calculator.Size = _squareSizeHalfHeight;
            _calculator.Text = "Calc";
            _calculator.TextAlign = ContentAlignment.MiddleCenter;
            _calculator.UseVisualStyleBackColor = true;
            keys.Add(_calculator);

            return keys;
        }

        private void PositionFirstRow(List<Key> keys, Margins margins)
        {
            var xCoordinate = margins.Left;
            var yCoordinate = margins.Top;

            foreach (var key in keys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "F8" || key.Name == "F12" || key.Name == "Paus")
                {
                    xCoordinate += (_squareSizeHalfHeight.Width / 2) + _offset;
                }
                else if (key.Name == "F4")
                {
                    xCoordinate += _squareSizeHalfHeight.Width / 2;
                }
                else if (key.Name == "Escape")
                {
                    xCoordinate += _squareSizeHalfHeight.Width + _offset;
                }
            }
        }
        #endregion FirstRow

        #region SecondRow
        private List<Key> InitiateSecondRow()
        {
            var keys = new List<Key>();

            _oem5.KeyValue = 220;
            _oem5.KeyCode = "Oem5";
            _oem5.KeyData = "Oem5";
            _oem5.Name = "Oem5";
            _oem5.Size = _squareSize;
            _oem5.Text = "§½";
            _oem5.TextAlign = ContentAlignment.BottomLeft;
            _oem5.UseVisualStyleBackColor = true;
            keys.Add(_oem5);

            _d1.KeyValue = 49;
            _d1.KeyCode = "D1";
            _d1.KeyData = "D1";
            _d1.Name = "D1";
            _d1.Size = _squareSize;
            _d1.Text = "1";
            _d1.TextAlign = ContentAlignment.BottomLeft;
            _d1.UseVisualStyleBackColor = true;
            keys.Add(_d1);

            _d2.KeyValue = 50;
            _d2.KeyCode = "D2";
            _d2.KeyData = "D2";
            _d2.Name = "D2";
            _d2.Size = _squareSize;
            _d2.Text = "2";
            _d2.TextAlign = ContentAlignment.BottomLeft;
            _d2.UseVisualStyleBackColor = true;
            keys.Add(_d2);

            _d3.KeyValue = 51;
            _d3.KeyCode = "D3";
            _d3.KeyData = "D3";
            _d3.Name = "D3";
            _d3.Size = _squareSize;
            _d3.Text = "3";
            _d3.TextAlign = ContentAlignment.BottomLeft;
            _d3.UseVisualStyleBackColor = true;
            keys.Add(_d3);

            _d4.KeyValue = 52;
            _d4.KeyCode = "D4";
            _d4.KeyData = "D4";
            _d4.Name = "D4";
            _d4.Size = _squareSize;
            _d4.Text = "4";
            _d4.TextAlign = ContentAlignment.BottomLeft;
            _d4.UseVisualStyleBackColor = true;
            keys.Add(_d4);

            _d5.KeyValue = 53;
            _d5.KeyCode = "D5";
            _d5.KeyData = "D5";
            _d5.Name = "D5";
            _d5.Size = _squareSize;
            _d5.Text = "5";
            _d5.TextAlign = ContentAlignment.BottomLeft;
            _d5.UseVisualStyleBackColor = true;
            keys.Add(_d5);

            _d6.KeyValue = 54;
            _d6.KeyCode = "D6";
            _d6.KeyData = "D6";
            _d6.Name = "D6";
            _d6.Size = _squareSize;
            _d6.Text = "6";
            _d6.TextAlign = ContentAlignment.BottomLeft;
            _d6.UseVisualStyleBackColor = true;
            keys.Add(_d6);

            _d7.KeyValue = 55;
            _d7.KeyCode = "D7";
            _d7.KeyData = "D7";
            _d7.Name = "D7";
            _d7.Size = _squareSize;
            _d7.Text = "7";
            _d7.TextAlign = ContentAlignment.BottomLeft;
            _d7.UseVisualStyleBackColor = true;
            keys.Add(_d7);

            _d8.KeyValue = 56;
            _d8.KeyCode = "D8";
            _d8.KeyData = "D8";
            _d8.Name = "D8";
            _d8.Size = _squareSize;
            _d8.Text = "8";
            _d8.TextAlign = ContentAlignment.BottomLeft;
            _d8.UseVisualStyleBackColor = true;
            keys.Add(_d8);

            _d9.KeyValue = 57;
            _d9.KeyCode = "D9";
            _d9.KeyData = "D9";
            _d9.Name = "D9";
            _d9.Size = _squareSize;
            _d9.Text = "9";
            _d9.TextAlign = ContentAlignment.BottomLeft;
            _d9.UseVisualStyleBackColor = true;
            keys.Add(_d9);

            _d0.KeyValue = 48;
            _d0.KeyCode = "D0";
            _d0.KeyData = "D0";
            _d0.Name = "D0";
            _d0.Size = _squareSize;
            _d0.Text = "0";
            _d0.TextAlign = ContentAlignment.BottomLeft;
            _d0.UseVisualStyleBackColor = true;
            keys.Add(_d0);

            _oemplus.KeyValue = 187;
            _oemplus.KeyCode = "Oemplus";
            _oemplus.KeyData = "Oemplus";
            _oemplus.Name = "Oemplus";
            _oemplus.Size = _squareSize;
            _oemplus.Text = @"+";
            _oemplus.TextAlign = ContentAlignment.BottomLeft;
            _oemplus.UseVisualStyleBackColor = true;
            keys.Add(_oemplus);

            _oemOpenBrackets.KeyValue = 219;
            _oemOpenBrackets.KeyCode = "OemOpenBrackets";
            _oemOpenBrackets.KeyData = "OemOpenBrackets";
            _oemOpenBrackets.Name = "OemOpenBrackets";
            _oemOpenBrackets.Size = _squareSize;
            _oemOpenBrackets.Text = @"\";
            _oemOpenBrackets.TextAlign = ContentAlignment.BottomLeft;
            _oemOpenBrackets.UseVisualStyleBackColor = true;
            keys.Add(_oemOpenBrackets);

            _back.KeyValue = 8;
            _back.KeyCode = "Back";
            _back.KeyData = "Back";
            _back.Name = "Back";
            _back.Size = _rectangleSize2;
            _back.Text = @"←";
            _back.TextAlign = ContentAlignment.BottomLeft;
            _back.UseVisualStyleBackColor = true;
            keys.Add(_back);

            _insert.KeyValue = 45;
            _insert.KeyCode = "Insert";
            _insert.KeyData = "Insert";
            _insert.Name = "Insert";
            _insert.Size = _squareSize;
            _insert.Text = @"INSERT";
            _insert.TextAlign = ContentAlignment.BottomCenter;
            _insert.UseVisualStyleBackColor = true;
            keys.Add(_insert);

            _home.KeyValue = 36;
            _home.KeyCode = "Home";
            _home.KeyData = "Home";
            _home.Name = "Home";
            _home.Size = _squareSize;
            _home.Text = @"HOME";
            _home.TextAlign = ContentAlignment.BottomCenter;
            _home.UseVisualStyleBackColor = true;
            keys.Add(_home);

            _pageUp.KeyValue = 33;
            _pageUp.KeyCode = "PageUp";
            _pageUp.KeyData = "PageUp";
            _pageUp.Name = "PageUp";
            _pageUp.Size = _squareSize;
            _pageUp.Text = @"PAGE↑";
            _pageUp.TextAlign = ContentAlignment.BottomCenter;
            _pageUp.UseVisualStyleBackColor = true;
            keys.Add(_pageUp);

            _numLock.KeyValue = 144;
            _numLock.KeyCode = "NumLock";
            _numLock.KeyData = "NumLock";
            _numLock.Name = "NumLock";
            _numLock.Size = _squareSize;
            _numLock.Text = @"NUM";
            _numLock.TextAlign = ContentAlignment.BottomCenter;
            _numLock.UseVisualStyleBackColor = true;
            keys.Add(_numLock);

            _divide.KeyValue = 111;
            _divide.KeyCode = "Divide";
            _divide.KeyData = "Divide";
            _divide.Name = "Divide";
            _divide.Size = _squareSize;
            _divide.Text = @"/";
            _divide.TextAlign = ContentAlignment.TopLeft;
            _divide.UseVisualStyleBackColor = true;
            keys.Add(_divide);

            _multiply.KeyValue = 106;
            _multiply.KeyCode = "Multiply";
            _multiply.KeyData = "Multiply";
            _multiply.Name = "Multiply";
            _multiply.Size = _squareSize;
            _multiply.Text = @"*";
            _multiply.TextAlign = ContentAlignment.TopLeft;
            _multiply.UseVisualStyleBackColor = true;
            keys.Add(_multiply);

            _subtract.KeyValue = 109;
            _subtract.KeyCode = "Subtract";
            _subtract.KeyData = "Subtract";
            _subtract.Name = "Subtract";
            _subtract.Size = _squareSize;
            _subtract.Text = @"-";
            _subtract.TextAlign = ContentAlignment.TopLeft;
            _subtract.UseVisualStyleBackColor = true;
            keys.Add(_subtract);

            return keys;
        }

        private void PositionSecondRow(List<Key> rowKeys, int startingYCoordinate, Margins margins)
        {
            var xCoordinate = margins.Left;
            var yCoordinate = startingYCoordinate;

            foreach ( var key in rowKeys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "Back" || key.Name == "PageUp")
                {
                    xCoordinate += Convert.ToInt32(_squareSize.Width / 2);
                }
            }
        }
        #endregion SecondRow

        #region ThirdRow

        private List<Key> InitiateThirdRow()
        {
            var keys = new List<Key>();

            _tab.KeyValue = 9;
            _tab.KeyCode = "Tab";
            _tab.KeyData = "Tab";
            _tab.Name = "Tab";
            _tab.Size = _rectangleSize1_5;
            _tab.Text = "↹";
            _tab.TextAlign = ContentAlignment.BottomLeft;
            _tab.UseVisualStyleBackColor = true;
            keys.Add(_tab);

            _q.KeyValue = 81;
            _q.KeyCode = "Q";
            _q.KeyData = "Q";
            _q.Name = "Q";
            _q.Size = _squareSize;
            _q.Text = "Q";
            _q.TextAlign = ContentAlignment.TopLeft;
            _q.UseVisualStyleBackColor = true;
            keys.Add(_q);

            _w.KeyValue = 87;
            _w.KeyCode = "W";
            _w.KeyData = "W";
            _w.Name = "W";
            _w.Size = _squareSize;
            _w.Text = "W";
            _w.TextAlign = ContentAlignment.TopLeft;
            _w.UseVisualStyleBackColor = true;
            keys.Add(_w);

            _e.KeyValue = 69;
            _e.KeyCode = "E";
            _e.KeyData = "E";
            _e.Name = "E";
            _e.Size = _squareSize;
            _e.Text = "E";
            _e.TextAlign = ContentAlignment.TopLeft;
            _e.UseVisualStyleBackColor = true;
            keys.Add(_e);

            _r.KeyValue = 82;
            _r.KeyCode = "R";
            _r.KeyData = "R";
            _r.Name = "R";
            _r.Size = _squareSize;
            _r.Text = "R";
            _r.TextAlign = ContentAlignment.TopLeft;
            _r.UseVisualStyleBackColor = true;
            keys.Add(_r);

            _t.KeyValue = 84;
            _t.KeyCode = "T";
            _t.KeyData = "T";
            _t.Name = "T";
            _t.Size = _squareSize;
            _t.Text = "T";
            _t.TextAlign = ContentAlignment.TopLeft;
            _t.UseVisualStyleBackColor = true;
            keys.Add(_t);

            _y.KeyValue = 89;
            _y.KeyCode = "Y";
            _y.KeyData = "Y";
            _y.Name = "Y";
            _y.Size = _squareSize;
            _y.Text = "Y";
            _y.TextAlign = ContentAlignment.TopLeft;
            _y.UseVisualStyleBackColor = true;
            keys.Add(_y);

            _u.KeyValue = 85;
            _u.KeyCode = "U";
            _u.KeyData = "U";
            _u.Name = "U";
            _u.Size = _squareSize;
            _u.Text = "U";
            _u.TextAlign = ContentAlignment.TopLeft;
            _u.UseVisualStyleBackColor = true;
            keys.Add(_u);

            _i.KeyValue = 73;
            _i.KeyCode = "I";
            _i.KeyData = "I";
            _i.Name = "I";
            _i.Size = _squareSize;
            _i.Text = "I";
            _i.TextAlign = ContentAlignment.TopLeft;
            _i.UseVisualStyleBackColor = true;
            keys.Add(_i);

            _o.KeyValue = 79;
            _o.KeyCode = "O";
            _o.KeyData = "O";
            _o.Name = "O";
            _o.Size = _squareSize;
            _o.Text = "O";
            _o.TextAlign = ContentAlignment.TopLeft;
            _o.UseVisualStyleBackColor = true;
            keys.Add(_o);

            _p.KeyValue = 80;
            _p.KeyCode = "P";
            _p.KeyData = "P";
            _p.Name = "P";
            _p.Size = _squareSize;
            _p.Text = "P";
            _p.TextAlign = ContentAlignment.TopLeft;
            _p.UseVisualStyleBackColor = true;
            keys.Add(_p);

            _oem6.KeyValue = 221;
            _oem6.KeyCode = "Oem6";
            _oem6.KeyData = "Oem6";
            _oem6.Name = "Oem6";
            _oem6.Size = _squareSize;
            _oem6.Text = "Å";
            _oem6.TextAlign = ContentAlignment.TopLeft;
            _oem6.UseVisualStyleBackColor = true;
            keys.Add(_oem6);

            _oem1.KeyValue = 186;
            _oem1.KeyCode = "Oem1";
            _oem1.KeyData = "Oem1";
            _oem1.Name = "Oem1";
            _oem1.Size = _squareSize;
            _oem1.Text = "¨";
            _oem1.TextAlign = ContentAlignment.TopLeft;
            _oem1.UseVisualStyleBackColor = true;
            keys.Add(_oem1);

            _return.KeyValue = 13;
            _return.KeyCode = "Return";
            _return.KeyData = "Return";
            _return.Name = "Return";
            _return.Size = new Size(Convert.ToInt32(_baseWidth * 1.25), _baseHeight * 2 + _offset);
            _return.Text = "↩";
            _return.TextAlign = ContentAlignment.BottomLeft;
            _return.UseVisualStyleBackColor = true;
            keys.Add(_return);

            _delete.KeyValue = 46;
            _delete.KeyCode = "Delete";
            _delete.KeyData = "Delete";
            _delete.Name = "Delete";
            _delete.Size = _squareSize;
            _delete.Text = "DELETE";
            _delete.TextAlign = ContentAlignment.BottomCenter;
            _delete.UseVisualStyleBackColor = true;
            keys.Add(_delete);

            _end.KeyValue = 35;
            _end.KeyCode = "End";
            _end.KeyData = "End";
            _end.Name = "End";
            _end.Size = _squareSize;
            _end.Text = "END";
            _end.TextAlign = ContentAlignment.BottomCenter;
            _end.UseVisualStyleBackColor = true;
            keys.Add(_end);

            _pageDown.KeyValue = 34;
            _pageDown.KeyCode = "PageDown";
            _pageDown.KeyData = "PageDown";
            _pageDown.Name = "PageDown";
            _pageDown.Size = _squareSize;
            _pageDown.Text = "Page↓";
            _pageDown.TextAlign = ContentAlignment.BottomCenter;
            _pageDown.UseVisualStyleBackColor = true;
            keys.Add(_pageDown);

            _numPad7.KeyValue = 103;
            _numPad7.KeyCode = "NumPad7";
            _numPad7.KeyData = "NumPad7";
            _numPad7.Name = "NumPad7";
            _numPad7.Size = _squareSize;
            _numPad7.Text = "7";
            _numPad7.TextAlign = ContentAlignment.TopLeft;
            _numPad7.UseVisualStyleBackColor = true;
            keys.Add(_numPad7);

            _numPad8.KeyValue = 104;
            _numPad8.KeyCode = "NumPad8";
            _numPad8.KeyData = "NumPad8";
            _numPad8.Name = "NumPad8";
            _numPad8.Size = _squareSize;
            _numPad8.Text = "8";
            _numPad8.TextAlign = ContentAlignment.TopLeft;
            _numPad8.UseVisualStyleBackColor = true;
            keys.Add(_numPad8);

            _numPad9.KeyValue = 105;
            _numPad9.KeyCode = "NumPad9";
            _numPad9.KeyData = "NumPad9";
            _numPad9.Name = "NumPad9";
            _numPad9.Size = _squareSize;
            _numPad9.Text = "9";
            _numPad9.TextAlign = ContentAlignment.TopLeft;
            _numPad9.UseVisualStyleBackColor = true;
            keys.Add(_numPad9);

            _add.KeyValue = 107;
            _add.KeyCode = "Add";
            _add.KeyData = "Add";
            _add.Name = "Add";
            _add.Size = _reverseRectangleSize2;
            _add.Text = "+";
            _add.TextAlign = ContentAlignment.TopLeft;
            _add.UseVisualStyleBackColor = true;
            keys.Add(_add);

            return keys;
        }

        private void PositionThirdRow(List<Key> rowKeys, int startingYCoordinate, Margins margins)
        {
            var xCoordinate = margins.Left;
            var yCoordinate = startingYCoordinate;

            foreach (var key in rowKeys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "Oem1")
                {
                    xCoordinate += Convert.ToInt32(_squareSize.Width * 0.25);
                }
                else if (key.Name == "Return" || key.Name == "PageDown")
                {
                    xCoordinate += Convert.ToInt32(_squareSize.Width / 2);
                }
            }
        }
        #endregion ThirdRow

        #region FourthRow
        private List<Key> InitiateFourthRow()
        {
            var keys = new List<Key>();

            _caps.KeyValue = 20;
            _caps.KeyCode = "Caps";
            _caps.KeyData = "Caps";
            _caps.Name = "Caps";
            _caps.Size = _rectangleSize1_75;
            _caps.Text = "CAPS";
            _caps.TextAlign = ContentAlignment.BottomLeft;
            _caps.UseVisualStyleBackColor = true;
            keys.Add(_caps);

            _a.KeyValue = 65;
            _a.KeyCode = "A";
            _a.KeyData = "A";
            _a.Name = "A";
            _a.Size = _squareSize;
            _a.Text = "A";
            _a.TextAlign = ContentAlignment.TopLeft;
            _a.UseVisualStyleBackColor = true;
            keys.Add(_a);

            _s.KeyValue = 83;
            _s.KeyCode = "S";
            _s.KeyData = "S";
            _s.Name = "S";
            _s.Size = _squareSize;
            _s.Text = "S";
            _s.TextAlign = ContentAlignment.TopLeft;
            _s.UseVisualStyleBackColor = true;
            keys.Add(_s);

            _d.KeyValue = 68;
            _d.KeyCode = "D";
            _d.KeyData = "D";
            _d.Name = "D";
            _d.Size = _squareSize;
            _d.Text = "D";
            _d.TextAlign = ContentAlignment.TopLeft;
            _d.UseVisualStyleBackColor = true;
            keys.Add(_d);

            _f.KeyValue = 70;
            _f.KeyCode = "F";
            _f.KeyData = "F";
            _f.Name = "F";
            _f.Size = _squareSize;
            _f.Text = "F";
            _f.TextAlign = ContentAlignment.TopLeft;
            _f.UseVisualStyleBackColor = true;
            keys.Add(_f);

            _g.KeyValue = 71;
            _g.KeyCode = "G";
            _g.KeyData = "G";
            _g.Name = "G";
            _g.Size = _squareSize;
            _g.Text = "G";
            _g.TextAlign = ContentAlignment.TopLeft;
            _g.UseVisualStyleBackColor = true;
            keys.Add(_g);

            _h.KeyValue = 72;
            _h.KeyCode = "H";
            _h.KeyData = "H";
            _h.Name = "H";
            _h.Size = _squareSize;
            _h.Text = "H";
            _h.TextAlign = ContentAlignment.TopLeft;
            _h.UseVisualStyleBackColor = true;
            keys.Add(_h);

            _j.KeyValue = 74;
            _j.KeyCode = "J";
            _j.KeyData = "J";
            _j.Name = "J";
            _j.Size = _squareSize;
            _j.Text = "J";
            _j.TextAlign = ContentAlignment.TopLeft;
            _j.UseVisualStyleBackColor = true;
            keys.Add(_j);

            _k.KeyValue = 75;
            _k.KeyCode = "K";
            _k.KeyData = "K";
            _k.Name = "K";
            _k.Size = _squareSize;
            _k.Text = "K";
            _k.TextAlign = ContentAlignment.TopLeft;
            _k.UseVisualStyleBackColor = true;
            keys.Add(_k);

            _l.KeyValue = 76;
            _l.KeyCode = "L";
            _l.KeyData = "L";
            _l.Name = "L";
            _l.Size = _squareSize;
            _l.Text = "L";
            _l.TextAlign = ContentAlignment.TopLeft;
            _l.UseVisualStyleBackColor = true;
            keys.Add(_l);

            _oemtilde.KeyValue = 192;
            _oemtilde.KeyCode = "Oemtilde";
            _oemtilde.KeyData = "Oemtilde";
            _oemtilde.Name = "Oemtilde";
            _oemtilde.Size = _squareSize;
            _oemtilde.Text = "Ö";
            _oemtilde.TextAlign = ContentAlignment.TopLeft;
            _oemtilde.UseVisualStyleBackColor = true;
            keys.Add(_oemtilde);

            _oem7.KeyValue = 222;
            _oem7.KeyCode = "Oem7";
            _oem7.KeyData = "Oem7";
            _oem7.Name = "Oem7";
            _oem7.Size = _squareSize;
            _oem7.Text = "Ä";
            _oem7.TextAlign = ContentAlignment.TopLeft;
            _oem7.UseVisualStyleBackColor = true;
            keys.Add(_oem7);

            _oemQuestion.KeyValue = 191;
            _oemQuestion.KeyCode = "OemQuestion";
            _oemQuestion.KeyData = "OemQuestion";
            _oemQuestion.Name = "OemQuestion";
            _oemQuestion.Size = _squareSize;
            _oemQuestion.Text = "*";
            _oemQuestion.TextAlign = ContentAlignment.TopLeft;
            _oemQuestion.UseVisualStyleBackColor = true;
            keys.Add(_oemQuestion);

            _numPad4.KeyValue = 100;
            _numPad4.KeyCode = "NumPad4";
            _numPad4.KeyData = "NumPad4";
            _numPad4.Name = "NumPad4";
            _numPad4.Size = _squareSize;
            _numPad4.Text = "4";
            _numPad4.TextAlign = ContentAlignment.TopLeft;
            _numPad4.UseVisualStyleBackColor = true;
            keys.Add(_numPad4);

            _numPad5.KeyValue = 101;
            _numPad5.KeyCode = "NumPad5";
            _numPad5.KeyData = "NumPad5";
            _numPad5.Name = "NumPad5";
            _numPad5.Size = _squareSize;
            _numPad5.Text = "5";
            _numPad5.TextAlign = ContentAlignment.TopLeft;
            _numPad5.UseVisualStyleBackColor = true;
            keys.Add(_numPad5);

            _numPad6.KeyValue = 102;
            _numPad6.KeyCode = "NumPad6";
            _numPad6.KeyData = "NumPad6";
            _numPad6.Name = "NumPad6";
            _numPad6.Size = _squareSize;
            _numPad6.Text = "6";
            _numPad6.TextAlign = ContentAlignment.TopLeft;
            _numPad6.UseVisualStyleBackColor = true;
            keys.Add(_numPad6);

            return keys;
        }

        private void PositionFourthRow(List<Key> rowKeys, int startingYCoordinate, Margins margins)
        {         
            var xCoordinate = margins.Left;
            var yCoordinate = startingYCoordinate;

            foreach (var key in rowKeys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "OemQuestion")
                {
                    xCoordinate += Convert.ToInt32((_squareSize.Width * 5.25) + (4 * _offset));
                }
            }
        }
        #endregion FourthRow

        #region FifthRow
        private List<Key> InitiateFifthRow()
        {
            var keys = new List<Key>();

            _leftShift.KeyValue = 16;
            _leftShift.KeyCode = "ShiftKey";
            _leftShift.KeyData = "ShiftKey, Shift";
            _leftShift.Name = "LeftShift";
            _leftShift.Size = _rectangleSize1_25;
            _leftShift.Text = "↑";
            _leftShift.TextAlign = ContentAlignment.BottomLeft;
            _leftShift.UseVisualStyleBackColor = true;
            keys.Add(_leftShift);

            _oemBackslash.KeyValue = 226;
            _oemBackslash.KeyCode = "OemBackslash";
            _oemBackslash.KeyData = "OemBackslash";
            _oemBackslash.Name = "OemBackslash";
            _oemBackslash.Size = _squareSize;
            _oemBackslash.Text = ">\n<";
            _oemBackslash.TextAlign = ContentAlignment.TopLeft;
            _oemBackslash.UseVisualStyleBackColor = true;
            keys.Add(_oemBackslash);

            _z.KeyValue = 90;
            _z.KeyCode = "Z";
            _z.KeyData = "Z";
            _z.Name = "Z";
            _z.Size = _squareSize;
            _z.Text = "Z";
            _z.TextAlign = ContentAlignment.TopLeft;
            _z.UseVisualStyleBackColor = true;
            keys.Add(_z);

            _x.KeyValue = 88;
            _x.KeyCode = "X";
            _x.KeyData = "X";
            _x.Name = "X";
            _x.Size = _squareSize;
            _x.Text = "X";
            _x.TextAlign = ContentAlignment.TopLeft;
            _x.UseVisualStyleBackColor = true;
            keys.Add(_x);

            _c.KeyValue = 67;
            _c.KeyCode = "C";
            _c.KeyData = "C";
            _c.Name = "C";
            _c.Size = _squareSize;
            _c.Text = "C";
            _c.TextAlign = ContentAlignment.TopLeft;
            _c.UseVisualStyleBackColor = true;
            keys.Add(_c);

            _v.KeyValue = 86;
            _v.KeyCode = "V";
            _v.KeyData = "V";
            _v.Name = "V";
            _v.Size = _squareSize;
            _v.Text = "V";
            _v.TextAlign = ContentAlignment.TopLeft;
            _v.UseVisualStyleBackColor = true;
            keys.Add(_v);

            _b.KeyValue = 66;
            _b.KeyCode = "B";
            _b.KeyData = "B";
            _b.Name = "B";
            _b.Size = _squareSize;
            _b.Text = "B";
            _b.TextAlign = ContentAlignment.TopLeft;
            _b.UseVisualStyleBackColor = true;
            keys.Add(_b);

            _n.KeyValue = 78;
            _n.KeyCode = "N";
            _n.KeyData = "N";
            _n.Name = "N";
            _n.Size = _squareSize;
            _n.Text = "N";
            _n.TextAlign = ContentAlignment.TopLeft;
            _n.UseVisualStyleBackColor = true;
            keys.Add(_n);

            _m.KeyValue = 77;
            _m.KeyCode = "M";
            _m.KeyData = "M";
            _m.Name = "M";
            _m.Size = _squareSize;
            _m.Text = "M";
            _m.TextAlign = ContentAlignment.TopLeft;
            _m.UseVisualStyleBackColor = true;
            keys.Add(_m);

            _oemComma.KeyValue = 188;
            _oemComma.KeyCode = "Oemcomma";
            _oemComma.KeyData = "Oemcomma";
            _oemComma.Name = "Oemcomma";
            _oemComma.Size = _squareSize;
            _oemComma.Text = ",";
            _oemComma.TextAlign = ContentAlignment.TopLeft;
            _oemComma.UseVisualStyleBackColor = true;
            keys.Add(_oemComma);

            _oemPeriod.KeyValue = 190;
            _oemPeriod.KeyCode = "OemPeriod";
            _oemPeriod.KeyData = "OemPeriod";
            _oemPeriod.Name = "OemPeriod";
            _oemPeriod.Size = _squareSize;
            _oemPeriod.Text = ".";
            _oemPeriod.TextAlign = ContentAlignment.TopLeft;
            _oemPeriod.UseVisualStyleBackColor = true;
            keys.Add(_oemPeriod);

            _oemMinus.KeyValue = 189;
            _oemMinus.KeyCode = "OemMinus";
            _oemMinus.KeyData = "OemMinus";
            _oemMinus.Name = "OemMinua";
            _oemMinus.Size = _squareSize;
            _oemMinus.Text = "-";
            _oemMinus.TextAlign = ContentAlignment.TopLeft;
            _oemMinus.UseVisualStyleBackColor = true;
            keys.Add(_oemMinus);

            _rightShift.KeyValue = -16;  // Inverting the KeyValue to distinguish between left and right shift since they both have the same KeyValue
            _rightShift.KeyCode = "ShiftKey";
            _rightShift.KeyData = "ShiftKey, Shift";
            _rightShift.Name = "RightShift";
            _rightShift.Size = _rectangleSize2_5;
            _rightShift.Text = "↑";
            _rightShift.TextAlign = ContentAlignment.BottomLeft;
            _rightShift.UseVisualStyleBackColor = true;
            keys.Add(_rightShift);

            return keys;
        }

        private void PositionFifthRow(List<Key> rowKeys, int startingYCoordinate, Margins margins)
        {
            var xCoordinate = margins.Left;
            var yCoordinate = startingYCoordinate;

            foreach (var key in rowKeys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "RightShift")
                {
                    xCoordinate += Convert.ToInt32((_squareSize.Width * 1.5) + _offset);
                }
            }
        }
        #endregion FifthRow

        private void AddKeysToBaseClass(List<Key> rowKeys)
        {
            foreach (var key in rowKeys)
            {
                base.Keys.Add(key.KeyValue, key);
            }           
        }

        private void SetCommonAttributes()
        {
            foreach (var key in Keys)
            {
                key.Value.TabStop = false;
                key.Value.Font = _font;
            }
        }

        private void SetKeyboardLayoutSize(List<Key> lastRowKeys, Margins margins)
        {
            var width = lastRowKeys.Last().Location.X + lastRowKeys.Last().Width + margins.Right;
            var height = lastRowKeys.Last().Location.Y + lastRowKeys.Last().Height;   // No margin to bottom since we have the text boxes below
            KeyboardLayoutSize = new Size(width, height);
        }
    }
}
