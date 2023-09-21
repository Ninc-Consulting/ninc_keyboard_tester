using Forms = System.Windows.Forms;

namespace KeyboardTester.KeyboardLayouts
{
    public class CherryKeyboardLayout : KeyboardLayout
    {
        // Keys
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
        private readonly Key _pause = new();
        private readonly Key _lWin = new();
        private readonly Key _browserHome = new();
        private readonly Key _launchMail = new();
        private readonly Key _calculator = new();
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
        private readonly Key _oemPlus = new();
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
        private readonly Key _oemTilde = new();
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
        private readonly Key _up = new();
        private readonly Key _numPad1 = new();
        private readonly Key _numPad2 = new();
        private readonly Key _numPad3 = new();
        private readonly Key _enter = new();
        private readonly Key _leftControl = new();
        private readonly Key _leftWindows = new();
        private readonly Key _alt = new();
        private readonly Key _space = new();
        private readonly Key _altGr = new();
        private readonly Key _rightWindows = new();
        private readonly Key _apps = new();
        private readonly Key _rightControl = new();
        private readonly Key _left = new();
        private readonly Key _down = new();
        private readonly Key _right = new();
        private readonly Key _numPad0 = new();
        private readonly Key _decimal = new();

        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new(BaseLength, BaseLength);  
        private static readonly Size _squareSizeHalfHeight = new(BaseLength, BaseLength / 2);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseLength * 1.25) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseLength * 1.5) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_7 = new(Convert.ToInt32(BaseLength * 1.7) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_75 = new(Convert.ToInt32(BaseLength * 1.75) + _offset, BaseLength);
        private static readonly Size _rectangleSize2 = new(BaseLength * 2 + _offset, BaseLength);
        private static readonly Size _rectangleSize2_75 = new(Convert.ToInt32(BaseLength * 2.75) + _offset, BaseLength);
        private static readonly Size _spaceBarSize = new(Convert.ToInt32(BaseLength * 5) + _offset, BaseLength);
        private static readonly Size _reverseRectangleSize2 = new(BaseLength, BaseLength * 2 + _offset);

        public CherryKeyboardLayout(int baseLength) : base (baseLength)
        {
            var keys = InitiateCherryKeyboardLayout();
            base.AddKeysToBaseClass(keys);
        }

        private List<Key> InitiateCherryKeyboardLayout()
        {
            var keys = InitiateKeys();
            DoLayout(keys);

            return keys;
        }

        private List<Key> InitiateKeys()
        {
            var keys = new List<Key>();

            _escape.KeyValue = 27;
            _escape.KeyCode = Forms.Keys.Escape;
            _escape.KeyData = Forms.Keys.Escape;
            _escape.Name = "Escape";
            _escape.Size = _squareSizeHalfHeight;
            _escape.Text = "ESC";
            _escape.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_escape);

            _f1.KeyValue = 112;
            _f1.KeyCode = Forms.Keys.F1;
            _f1.KeyData = Forms.Keys.F1;
            _f1.Name = "F1";
            _f1.Size = _squareSizeHalfHeight;
            _f1.Text = "F1";
            _f1.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f1);

            _f2.KeyValue = 113;
            _f2.KeyCode = Forms.Keys.F2;
            _f2.KeyData = Forms.Keys.F2;
            _f2.Name = "F2";
            _f2.Size = _squareSizeHalfHeight;
            _f2.Text = "F2";
            _f2.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f2);

            _f3.KeyValue = 114;
            _f3.KeyCode = Forms.Keys.F3;
            _f3.KeyData = Forms.Keys.F3;
            _f3.Name = "F3";
            _f3.Size = _squareSizeHalfHeight;
            _f3.Text = "F3";
            _f3.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f3);

            _f4.KeyValue = 115;
            _f4.KeyCode = Forms.Keys.F4;
            _f4.KeyData = Forms.Keys.F4;
            _f4.Name = "F4";
            _f4.Size = _squareSizeHalfHeight;
            _f4.Text = "F4";
            _f4.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f4);

            _f5.KeyValue = 116;
            _f5.KeyCode = Forms.Keys.F5;
            _f5.KeyData = Forms.Keys.F5;
            _f5.Name = "F5";
            _f5.Size = _squareSizeHalfHeight;
            _f5.Text = "F5";
            _f5.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f5);

            _f6.KeyValue = 117;
            _f6.KeyCode = Forms.Keys.F6;
            _f6.KeyData = Forms.Keys.F6;
            _f6.Name = "F6";
            _f6.Size = _squareSizeHalfHeight;
            _f6.Text = "F6";
            _f6.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f6);

            _f7.KeyValue = 118;
            _f7.KeyCode = Forms.Keys.F7;
            _f7.KeyData = Forms.Keys.F7;
            _f7.Name = "F7";
            _f7.Size = _squareSizeHalfHeight;
            _f7.Text = "F7";
            _f7.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f7);

            _f8.KeyValue = 119;
            _f8.KeyCode = Forms.Keys.F8;
            _f8.KeyData = Forms.Keys.F8;
            _f8.Name = "F8";
            _f8.Size = _squareSizeHalfHeight;
            _f8.Text = "F8";
            _f8.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f8);

            _f9.KeyValue = 120;
            _f9.KeyCode = Forms.Keys.F9;
            _f9.KeyData = Forms.Keys.F9;
            _f9.Name = "F9";
            _f9.Size = _squareSizeHalfHeight;
            _f9.Text = "F9";
            _f9.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f9);

            _f10.KeyValue = 121;
            _f10.KeyCode = Forms.Keys.F10;
            _f10.KeyData = Forms.Keys.F10;
            _f10.Name = "F10";
            _f10.Size = _squareSizeHalfHeight;
            _f10.Text = "F10";
            _f10.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f10);

            _f11.KeyValue = 122;
            _f11.KeyCode = Forms.Keys.F11;
            _f11.KeyData = Forms.Keys.F11;
            _f11.Name = "F11";
            _f11.Size = _squareSizeHalfHeight;
            _f11.Text = "F11";
            _f11.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f11);

            _f12.KeyValue = 123;
            _f12.KeyCode = Forms.Keys.F12;
            _f12.KeyData = Forms.Keys.F12;
            _f12.Name = "F12";
            _f12.Size = _squareSizeHalfHeight;
            _f12.Text = "F12";
            _f12.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f12);

            _printScreen.KeyValue = 44;
            _printScreen.KeyCode = Forms.Keys.PrintScreen;
            _printScreen.KeyData = Forms.Keys.PrintScreen;
            _printScreen.Name = "PrintScreen";
            _printScreen.Size = _squareSizeHalfHeight;
            _printScreen.Text = "PRT SC\nSYS RQ";
            _printScreen.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_printScreen);

            _scroll.KeyValue = 145;
            _scroll.KeyCode = Forms.Keys.Scroll;
            _scroll.KeyData = Forms.Keys.Scroll;
            _scroll.Name = "Scroll";
            _scroll.Size = _squareSizeHalfHeight;
            _scroll.Text = "SCROLL";
            _scroll.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_scroll);

            _pause.KeyValue = 19;
            _pause.KeyCode = Forms.Keys.Pause;
            _pause.KeyData = Forms.Keys.Pause;
            _pause.Name = "Pause";
            _pause.Size = _squareSizeHalfHeight;
            _pause.Text = "PAUSE\nBREAK";
            _pause.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_pause);

            _lWin.KeyValue = -998;  // No difference to left windows key, removed for now
            _lWin.KeyCode = Forms.Keys.LWin;
            _lWin.KeyData = Forms.Keys.LWin;
            _lWin.Name = "LWin";
            _lWin.Size = _squareSizeHalfHeight;
            _lWin.Text = "Lock";
            _lWin.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_lWin);

            _browserHome.KeyValue = 172;
            _browserHome.KeyCode = Forms.Keys.BrowserHome;
            _browserHome.KeyData = Forms.Keys.BrowserHome;
            _browserHome.Name = "BrowserHome";
            _browserHome.Size = _squareSizeHalfHeight;
            _browserHome.Text = "Browser";
            _browserHome.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_browserHome);

            _launchMail.KeyValue = 180;
            _launchMail.KeyCode = Forms.Keys.LaunchMail;
            _launchMail.KeyData = Forms.Keys.LaunchMail;
            _launchMail.Name = "LaunchMail";
            _launchMail.Size = _squareSizeHalfHeight;
            _launchMail.Text = "Mail";
            _launchMail.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_launchMail);

            _calculator.KeyValue = 183;
            _calculator.KeyCode = Forms.Keys.LaunchApplication2;
            _calculator.KeyData = Forms.Keys.LaunchApplication2;
            _calculator.Name = "LaunchApplication2";
            _calculator.Size = _squareSizeHalfHeight;
            _calculator.Text = "Calc";
            _calculator.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_calculator);

            _oem5.KeyValue = 220;
            _oem5.KeyCode = Forms.Keys.Oem5;
            _oem5.KeyData = Forms.Keys.Oem5;
            _oem5.Name = "Oem5";
            _oem5.Size = _squareSize;
            _oem5.Text = "§½";
            _oem5.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oem5);

            _d1.KeyValue = 49;
            _d1.KeyCode = Forms.Keys.D1;
            _d1.KeyData = Forms.Keys.D1;
            _d1.Name = "D1";
            _d1.Size = _squareSize;
            _d1.Text = "1";
            _d1.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d1);

            _d2.KeyValue = 50;
            _d2.KeyCode = Forms.Keys.D2;
            _d2.KeyData = Forms.Keys.D2;
            _d2.Name = "D2";
            _d2.Size = _squareSize;
            _d2.Text = "2";
            _d2.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d2);

            _d3.KeyValue = 51;
            _d3.KeyCode = Forms.Keys.D3;
            _d3.KeyData = Forms.Keys.D3;
            _d3.Name = "D3";
            _d3.Size = _squareSize;
            _d3.Text = "3";
            _d3.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d3);

            _d4.KeyValue = 52;
            _d4.KeyCode = Forms.Keys.D4;
            _d4.KeyData = Forms.Keys.D4;
            _d4.Name = "D4";
            _d4.Size = _squareSize;
            _d4.Text = "4";
            _d4.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d4);

            _d5.KeyValue = 53;
            _d5.KeyCode = Forms.Keys.D5;
            _d5.KeyData = Forms.Keys.D5;
            _d5.Name = "D5";
            _d5.Size = _squareSize;
            _d5.Text = "5";
            _d5.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d5);

            _d6.KeyValue = 54;
            _d6.KeyCode = Forms.Keys.D6;
            _d6.KeyData = Forms.Keys.D6;
            _d6.Name = "D6";
            _d6.Size = _squareSize;
            _d6.Text = "6";
            _d6.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d6);

            _d7.KeyValue = 55;
            _d7.KeyCode = Forms.Keys.D7;
            _d7.KeyData = Forms.Keys.D7;
            _d7.Name = "D7";
            _d7.Size = _squareSize;
            _d7.Text = "7";
            _d7.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d7);

            _d8.KeyValue = 56;
            _d8.KeyCode = Forms.Keys.D8;
            _d8.KeyData = Forms.Keys.D8;
            _d8.Name = "D8";
            _d8.Size = _squareSize;
            _d8.Text = "8";
            _d8.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d8);

            _d9.KeyValue = 57;
            _d9.KeyCode = Forms.Keys.D9;
            _d9.KeyData = Forms.Keys.D9;
            _d9.Name = "D9";
            _d9.Size = _squareSize;
            _d9.Text = "9";
            _d9.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d9);

            _d0.KeyValue = 48;
            _d0.KeyCode = Forms.Keys.D0;
            _d0.KeyData = Forms.Keys.D0;
            _d0.Name = "D0";
            _d0.Size = _squareSize;
            _d0.Text = "0";
            _d0.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d0);

            _oemPlus.KeyValue = 187;
            _oemPlus.KeyCode = Forms.Keys.Oemplus;
            _oemPlus.KeyData = Forms.Keys.Oemplus;
            _oemPlus.Name = "OemPlus";
            _oemPlus.Size = _squareSize;
            _oemPlus.Text = @"+";
            _oemPlus.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemPlus);

            _oemOpenBrackets.KeyValue = 219;
            _oemOpenBrackets.KeyCode = Forms.Keys.OemOpenBrackets;
            _oemOpenBrackets.KeyData = Forms.Keys.OemOpenBrackets;
            _oemOpenBrackets.Name = "OemOpenBrackets";
            _oemOpenBrackets.Size = _squareSize;
            _oemOpenBrackets.Text = @"\";
            _oemOpenBrackets.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemOpenBrackets);

            _back.KeyValue = 8;
            _back.KeyCode = Forms.Keys.Back;
            _back.KeyData = Forms.Keys.Back;
            _back.Name = "Back";
            _back.Size = _rectangleSize2;
            _back.Text = "←";
            _back.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_back);

            _insert.KeyValue = 45;
            _insert.KeyCode = Forms.Keys.Insert;
            _insert.KeyData = Forms.Keys.Insert;
            _insert.Name = "Insert";
            _insert.Size = _squareSize;
            _insert.Text = "INSERT";
            _insert.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_insert);

            _home.KeyValue = 36;
            _home.KeyCode = Forms.Keys.Home;
            _home.KeyData = Forms.Keys.Home;
            _home.Name = "Home";
            _home.Size = _squareSize;
            _home.Text = "HOME";
            _home.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_home);

            _pageUp.KeyValue = 33;
            _pageUp.KeyCode = Forms.Keys.PageUp;
            _pageUp.KeyData = Forms.Keys.PageUp;
            _pageUp.Name = "PageUp";
            _pageUp.Size = _squareSize;
            _pageUp.Text = "PAGE▴";
            _pageUp.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_pageUp);

            _numLock.KeyValue = 144;
            _numLock.KeyCode = Forms.Keys.NumLock;
            _numLock.KeyData = Forms.Keys.NumLock;
            _numLock.Name = "NumLock";
            _numLock.Size = _squareSize;
            _numLock.Text = "NUM";
            _numLock.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_numLock);

            _divide.KeyValue = 111;
            _divide.KeyCode = Forms.Keys.Divide;
            _divide.KeyData = Forms.Keys.Divide;
            _divide.Name = "Divide";
            _divide.Size = _squareSize;
            _divide.Text = "/";
            _divide.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_divide);

            _multiply.KeyValue = 106;
            _multiply.KeyCode = Forms.Keys.Multiply;
            _multiply.KeyData = Forms.Keys.Multiply;
            _multiply.Name = "Multiply";
            _multiply.Size = _squareSize;
            _multiply.Text = "*";
            _multiply.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_multiply);

            _subtract.KeyValue = 109;
            _subtract.KeyCode = Forms.Keys.Subtract;
            _subtract.KeyData = Forms.Keys.Subtract;
            _subtract.Name = "Subtract";
            _subtract.Size = _squareSize;
            _subtract.Text = "-";
            _subtract.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_subtract);

            _tab.KeyValue = 9;
            _tab.KeyCode = Forms.Keys.Tab;
            _tab.KeyData = Forms.Keys.Tab;
            _tab.Name = "Tab";
            _tab.Size = _rectangleSize1_5;
            _tab.Text = "↹";
            _tab.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_tab);

            _q.KeyValue = 81;
            _q.KeyCode = Forms.Keys.Q;
            _q.KeyData = Forms.Keys.Q;
            _q.Name = "Q";
            _q.Size = _squareSize;
            _q.Text = "Q";
            _q.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_q);

            _w.KeyValue = 87;
            _w.KeyCode = Forms.Keys.W;
            _w.KeyData = Forms.Keys.W;
            _w.Name = "W";
            _w.Size = _squareSize;
            _w.Text = "W";
            _w.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_w);

            _e.KeyValue = 69;
            _e.KeyCode = Forms.Keys.E;
            _e.KeyData = Forms.Keys.E;
            _e.Name = "E";
            _e.Size = _squareSize;
            _e.Text = "E";
            _e.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_e);

            _r.KeyValue = 82;
            _r.KeyCode = Forms.Keys.R;
            _r.KeyData = Forms.Keys.R;
            _r.Name = "R";
            _r.Size = _squareSize;
            _r.Text = "R";
            _r.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_r);

            _t.KeyValue = 84;
            _t.KeyCode = Forms.Keys.T;
            _t.KeyData = Forms.Keys.T;
            _t.Name = "T";
            _t.Size = _squareSize;
            _t.Text = "T";
            _t.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_t);

            _y.KeyValue = 89;
            _y.KeyCode = Forms.Keys.Y;
            _y.KeyData = Forms.Keys.Y;
            _y.Name = "Y";
            _y.Size = _squareSize;
            _y.Text = "Y";
            _y.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_y);

            _u.KeyValue = 85;
            _u.KeyCode = Forms.Keys.U;
            _u.KeyData = Forms.Keys.U;
            _u.Name = "U";
            _u.Size = _squareSize;
            _u.Text = "U";
            _u.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_u);

            _i.KeyValue = 73;
            _i.KeyCode = Forms.Keys.I;
            _i.KeyData = Forms.Keys.I;
            _i.Name = "I";
            _i.Size = _squareSize;
            _i.Text = "I";
            _i.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_i);

            _o.KeyValue = 79;
            _o.KeyCode = Forms.Keys.O;
            _o.KeyData = Forms.Keys.O;
            _o.Name = "O";
            _o.Size = _squareSize;
            _o.Text = "O";
            _o.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_o);

            _p.KeyValue = 80;
            _p.KeyCode = Forms.Keys.P;
            _p.KeyData = Forms.Keys.P;
            _p.Name = "P";
            _p.Size = _squareSize;
            _p.Text = "P";
            _p.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_p);

            _oem6.KeyValue = 221;
            _oem6.KeyCode = Forms.Keys.Oem6;
            _oem6.KeyData = Forms.Keys.Oem6;
            _oem6.Name = "Oem6";
            _oem6.Size = _squareSize;
            _oem6.Text = "Å";
            _oem6.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem6);

            _oem1.KeyValue = 186;
            _oem1.KeyCode = Forms.Keys.Oem1;
            _oem1.KeyData = Forms.Keys.Oem1;
            _oem1.Name = "Oem1";
            _oem1.Size = _squareSize;
            _oem1.Text = "^";
            _oem1.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem1);

            _return.KeyValue = 13;
            _return.KeyCode = Forms.Keys.Return;
            _return.KeyData = Forms.Keys.Return;
            _return.Name = "Return";
            _return.Size = new Size(Convert.ToInt32(BaseLength * 1.25), BaseLength * 2 + _offset);
            _return.Text = "↩";
            _return.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_return);

            _delete.KeyValue = 46;
            _delete.KeyCode = Forms.Keys.Delete;
            _delete.KeyData = Forms.Keys.Delete;
            _delete.Name = "Delete";
            _delete.Size = _squareSize;
            _delete.Text = "DELETE";
            _delete.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_delete);

            _end.KeyValue = 35;
            _end.KeyCode = Forms.Keys.End;
            _end.KeyData = Forms.Keys.End;
            _end.Name = "End";
            _end.Size = _squareSize;
            _end.Text = "END";
            _end.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_end);

            _pageDown.KeyValue = 34;
            _pageDown.KeyCode = Forms.Keys.PageDown;
            _pageDown.KeyData = Forms.Keys.PageDown;
            _pageDown.Name = "PageDown";
            _pageDown.Size = _squareSize;
            _pageDown.Text = "PAGE▾";
            _pageDown.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_pageDown);

            _numPad7.KeyValue = 103;
            _numPad7.KeyCode = Forms.Keys.NumPad7;
            _numPad7.KeyData = Forms.Keys.NumPad7;
            _numPad7.Name = "NumPad7";
            _numPad7.Size = _squareSize;
            _numPad7.Text = "7";
            _numPad7.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad7);

            _numPad8.KeyValue = 104;
            _numPad8.KeyCode = Forms.Keys.NumPad8;
            _numPad8.KeyData = Forms.Keys.NumPad8;
            _numPad8.Name = "NumPad8";
            _numPad8.Size = _squareSize;
            _numPad8.Text = "8";
            _numPad8.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad8);

            _numPad9.KeyValue = 105;
            _numPad9.KeyCode = Forms.Keys.NumPad9;
            _numPad9.KeyData = Forms.Keys.NumPad9;
            _numPad9.Name = "NumPad9";
            _numPad9.Size = _squareSize;
            _numPad9.Text = "9";
            _numPad9.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad9);

            _add.KeyValue = 107;
            _add.KeyCode = Forms.Keys.Add;
            _add.KeyData = Forms.Keys.Add;
            _add.Name = "Add";
            _add.Size = _reverseRectangleSize2;
            _add.Text = "+";
            _add.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_add);

            _caps.KeyValue = 20;
            _caps.KeyCode = Forms.Keys.Capital;
            _caps.KeyData = Forms.Keys.Capital;
            _caps.Name = "Caps";
            _caps.Size = _rectangleSize1_75;
            _caps.Text = "CAPS";
            _caps.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_caps);

            _a.KeyValue = 65;
            _a.KeyCode = Forms.Keys.A;
            _a.KeyData = Forms.Keys.A;
            _a.Name = "A";
            _a.Size = _squareSize;
            _a.Text = "A";
            _a.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_a);

            _s.KeyValue = 83;
            _s.KeyCode = Forms.Keys.S;
            _s.KeyData = Forms.Keys.S;
            _s.Name = "S";
            _s.Size = _squareSize;
            _s.Text = "S";
            _s.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_s);

            _d.KeyValue = 68;
            _d.KeyCode = Forms.Keys.D;
            _d.KeyData = Forms.Keys.D;
            _d.Name = "D";
            _d.Size = _squareSize;
            _d.Text = "D";
            _d.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_d);

            _f.KeyValue = 70;
            _f.KeyCode = Forms.Keys.F;
            _f.KeyData = Forms.Keys.F;
            _f.Name = "F";
            _f.Size = _squareSize;
            _f.Text = "F";
            _f.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f);

            _g.KeyValue = 71;
            _g.KeyCode = Forms.Keys.G;
            _g.KeyData = Forms.Keys.G;
            _g.Name = "G";
            _g.Size = _squareSize;
            _g.Text = "G";
            _g.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_g);

            _h.KeyValue = 72;
            _h.KeyCode = Forms.Keys.H;
            _h.KeyData = Forms.Keys.H;
            _h.Name = "H";
            _h.Size = _squareSize;
            _h.Text = "H";
            _h.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_h);

            _j.KeyValue = 74;
            _j.KeyCode = Forms.Keys.J;
            _j.KeyData = Forms.Keys.J;
            _j.Name = "J";
            _j.Size = _squareSize;
            _j.Text = "J";
            _j.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_j);

            _k.KeyValue = 75;
            _k.KeyCode = Forms.Keys.K;
            _k.KeyData = Forms.Keys.K;
            _k.Name = "K";
            _k.Size = _squareSize;
            _k.Text = "K";
            _k.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_k);

            _l.KeyValue = 76;
            _l.KeyCode = Forms.Keys.L;
            _l.KeyData = Forms.Keys.L;
            _l.Name = "L";
            _l.Size = _squareSize;
            _l.Text = "L";
            _l.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_l);

            _oemTilde.KeyValue = 192;
            _oemTilde.KeyCode = Forms.Keys.Oemtilde;
            _oemTilde.KeyData = Forms.Keys.Oemtilde;
            _oemTilde.Name = "Oemtilde";
            _oemTilde.Size = _squareSize;
            _oemTilde.Text = "Ö";
            _oemTilde.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemTilde);

            _oem7.KeyValue = 222;
            _oem7.KeyCode = Forms.Keys.Oem7;
            _oem7.KeyData = Forms.Keys.Oem7;
            _oem7.Name = "Oem7";
            _oem7.Size = _squareSize;
            _oem7.Text = "Ä";
            _oem7.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem7);

            _oemQuestion.KeyValue = 191;
            _oemQuestion.KeyCode = Forms.Keys.OemQuestion;
            _oemQuestion.KeyData = Forms.Keys.OemQuestion;
            _oemQuestion.Name = "OemQuestion";
            _oemQuestion.Size = _squareSize;
            _oemQuestion.Text = "*";
            _oemQuestion.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemQuestion);

            _numPad4.KeyValue = 100;
            _numPad4.KeyCode = Forms.Keys.NumPad4;
            _numPad4.KeyData = Forms.Keys.NumPad4;
            _numPad4.Name = "NumPad4";
            _numPad4.Size = _squareSize;
            _numPad4.Text = "4";
            _numPad4.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad4);

            _numPad5.KeyValue = 101;
            _numPad5.KeyCode = Forms.Keys.NumPad5;
            _numPad5.KeyData = Forms.Keys.NumPad5;
            _numPad5.Name = "NumPad5";
            _numPad5.Size = _squareSize;
            _numPad5.Text = "5";
            _numPad5.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad5);

            _numPad6.KeyValue = 102;
            _numPad6.KeyCode = Forms.Keys.NumPad6;
            _numPad6.KeyData = Forms.Keys.NumPad6;
            _numPad6.Name = "NumPad6";
            _numPad6.Size = _squareSize;
            _numPad6.Text = "6";
            _numPad6.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad6);

            _leftShift.KeyValue = 160;
            _leftShift.KeyCode = Forms.Keys.ShiftKey;
            _leftShift.KeyData = Forms.Keys.ShiftKey | Forms.Keys.Shift;
            _leftShift.Name = "LeftShift";
            _leftShift.Size = _rectangleSize1_25;
            _leftShift.Text = "↑";
            _leftShift.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_leftShift);

            _oemBackslash.KeyValue = 226;
            _oemBackslash.KeyCode = Forms.Keys.OemBackslash;
            _oemBackslash.KeyData = Forms.Keys.OemBackslash;
            _oemBackslash.Name = "OemBackslash";
            _oemBackslash.Size = _squareSize;
            _oemBackslash.Text = ">\n<";
            _oemBackslash.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemBackslash);

            _z.KeyValue = 90;
            _z.KeyCode = Forms.Keys.Z;
            _z.KeyData = Forms.Keys.Z;
            _z.Name = "Z";
            _z.Size = _squareSize;
            _z.Text = "Z";
            _z.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_z);

            _x.KeyValue = 88;
            _x.KeyCode = Forms.Keys.X;
            _x.KeyData = Forms.Keys.X;
            _x.Name = "X";
            _x.Size = _squareSize;
            _x.Text = "X";
            _x.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_x);

            _c.KeyValue = 67;
            _c.KeyCode = Forms.Keys.C;
            _c.KeyData = Forms.Keys.C;
            _c.Name = "C";
            _c.Size = _squareSize;
            _c.Text = "C";
            _c.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_c);

            _v.KeyValue = 86;
            _v.KeyCode = Forms.Keys.V;
            _v.KeyData = Forms.Keys.V;
            _v.Name = "V";
            _v.Size = _squareSize;
            _v.Text = "V";
            _v.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_v);

            _b.KeyValue = 66;
            _b.KeyCode = Forms.Keys.B;
            _b.KeyData = Forms.Keys.B;
            _b.Name = "B";
            _b.Size = _squareSize;
            _b.Text = "B";
            _b.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_b);

            _n.KeyValue = 78;
            _n.KeyCode = Forms.Keys.N;
            _n.KeyData = Forms.Keys.N;
            _n.Name = "N";
            _n.Size = _squareSize;
            _n.Text = "N";
            _n.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_n);

            _m.KeyValue = 77;
            _m.KeyCode = Forms.Keys.M;
            _m.KeyData = Forms.Keys.M;
            _m.Name = "M";
            _m.Size = _squareSize;
            _m.Text = "M";
            _m.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_m);

            _oemComma.KeyValue = 188;
            _oemComma.KeyCode = Forms.Keys.Oemcomma;
            _oemComma.KeyData = Forms.Keys.Oemcomma;
            _oemComma.Name = "Oemcomma";
            _oemComma.Size = _squareSize;
            _oemComma.Text = ",";
            _oemComma.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemComma);

            _oemPeriod.KeyValue = 190;
            _oemPeriod.KeyCode = Forms.Keys.OemPeriod;
            _oemPeriod.KeyData = Forms.Keys.OemPeriod;
            _oemPeriod.Name = "OemPeriod";
            _oemPeriod.Size = _squareSize;
            _oemPeriod.Text = ".";
            _oemPeriod.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemPeriod);

            _oemMinus.KeyValue = 189;
            _oemMinus.KeyCode = Forms.Keys.OemMinus;
            _oemMinus.KeyData = Forms.Keys.OemMinus;
            _oemMinus.Name = "OemMinua";
            _oemMinus.Size = _squareSize;
            _oemMinus.Text = "-";
            _oemMinus.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemMinus);

            _rightShift.KeyValue = 161; 
            _rightShift.KeyCode = Forms.Keys.ShiftKey;
            _rightShift.KeyData = Forms.Keys.ShiftKey | Forms.Keys.Shift;
            _rightShift.Name = "RightShift";
            _rightShift.Size = _rectangleSize2_75;
            _rightShift.Text = "↑";
            _rightShift.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_rightShift);

            _up.KeyValue = 38;
            _up.KeyCode = Forms.Keys.Up;
            _up.KeyData = Forms.Keys.Up;
            _up.Name = "Up";
            _up.Size = _squareSize;
            _up.Text = "△";
            _up.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_up);

            _numPad1.KeyValue = 97;
            _numPad1.KeyCode = Forms.Keys.NumPad1;
            _numPad1.KeyData = Forms.Keys.NumPad1;
            _numPad1.Name = "NumPad1";
            _numPad1.Size = _squareSize;
            _numPad1.Text = "1";
            _numPad1.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad1);

            _numPad2.KeyValue = 98;
            _numPad2.KeyCode = Forms.Keys.NumPad2;
            _numPad2.KeyData = Forms.Keys.NumPad2;
            _numPad2.Name = "NumPad2";
            _numPad2.Size = _squareSize;
            _numPad2.Text = "2";
            _numPad2.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad2);

            _numPad3.KeyValue = 99;
            _numPad3.KeyCode = Forms.Keys.NumPad3;
            _numPad3.KeyData = Forms.Keys.NumPad3;
            _numPad3.Name = "NumPad3";
            _numPad3.Size = _squareSize;
            _numPad3.Text = "3";
            _numPad3.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad3);

            _enter.KeyValue = -13;  // Inverting the KeyValue to distinguish between regular Return and NumPad Enter since they both have the same KeyValue
            _enter.KeyCode = Forms.Keys.Enter;
            _enter.KeyData = Forms.Keys.Enter;
            _enter.Name = "Enter";
            _enter.Size = _reverseRectangleSize2;
            _enter.Text = "ENTER";
            _enter.TextAlign = ContentAlignment.BottomCenter;
            keys.Add(_enter);

            _leftControl.KeyValue = 162;
            _leftControl.KeyCode = Forms.Keys.ControlKey;
            _leftControl.KeyData = Forms.Keys.ControlKey | Forms.Keys.Control;
            _leftControl.Name = "LeftControl";
            _leftControl.Size = _rectangleSize1_7;
            _leftControl.Text = "CONTROL";
            _leftControl.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_leftControl);

            _leftWindows.KeyValue = 91;
            _leftWindows.KeyCode = Forms.Keys.LWin;
            _leftWindows.KeyData = Forms.Keys.LWin;
            _leftWindows.Name = "LeftWindows";
            _leftWindows.Size = _rectangleSize1_5;
            _leftWindows.Text = "⊞";
            _leftWindows.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_leftWindows);

            _alt.KeyValue = 164;
            _alt.KeyCode = Forms.Keys.Menu;
            _alt.KeyData = Forms.Keys.Menu | Forms.Keys.Alt;
            _alt.Name = "Alt";
            _alt.Size = _rectangleSize1_5;
            _alt.Text = "ALT";
            _alt.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_alt);

            _space.KeyValue = 32;
            _space.KeyCode = Forms.Keys.Space;
            _space.KeyData = Forms.Keys.Space;
            _space.Name = "Space";
            _space.Size = _spaceBarSize;
            _space.Text = "";
            keys.Add(_space);

            _altGr.KeyValue = 165;
            _altGr.KeyCode = Forms.Keys.Menu;
            _altGr.KeyData = Forms.Keys.Menu | Forms.Keys.Control | Forms.Keys.Alt;
            _altGr.Name = "AltGr";
            _altGr.Size = _rectangleSize1_5;
            _altGr.Text = "ALT GR";
            _altGr.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_altGr);

            _rightWindows.KeyValue = 92;
            _rightWindows.KeyCode = Forms.Keys.RWin;
            _rightWindows.KeyData = Forms.Keys.RWin;
            _rightWindows.Name = "RightWindows";
            _rightWindows.Size = _rectangleSize1_25;
            _rightWindows.Text = "⊞";
            _rightWindows.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_rightWindows);

            _apps.KeyValue = 93;
            _apps.KeyCode = Forms.Keys.Apps;
            _apps.KeyData = Forms.Keys.Apps;
            _apps.Name = "Apps";
            _apps.Size = _rectangleSize1_25;
            _apps.Text = "≣";
            _apps.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_apps);

            _rightControl.KeyValue = 163;
            _rightControl.KeyCode = Forms.Keys.ControlKey;
            _rightControl.KeyData = Forms.Keys.ControlKey | Forms.Keys.Control;
            _rightControl.Name = "RightControl";
            _rightControl.Size = _rectangleSize1_25;
            _rightControl.Text = "CONTROL";
            _rightControl.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_rightControl);

            _left.KeyValue = 37;
            _left.KeyCode = Forms.Keys.Left;
            _left.KeyData = Forms.Keys.Left;
            _left.Name = "Left";
            _left.Size = _squareSize;
            _left.Text = "◁";
            _left.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_left);

            _down.KeyValue = 40;
            _down.KeyCode = Forms.Keys.Down;
            _down.KeyData = Forms.Keys.Down;
            _down.Name = "Down";
            _down.Size = _squareSize;
            _down.Text = "▽";
            _down.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_down);

            _right.KeyValue = 39;
            _right.KeyCode = Forms.Keys.Right;
            _right.KeyData = Forms.Keys.Right;
            _right.Name = "Right";
            _right.Size = _squareSize;
            _right.Text = "▷";
            _right.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_right);

            _numPad0.KeyValue = 96;
            _numPad0.KeyCode = Forms.Keys.NumPad0;
            _numPad0.KeyData = Forms.Keys.NumPad0;
            _numPad0.Name = "NumPad0";
            _numPad0.Size = _rectangleSize2;
            _numPad0.Text = "0";
            _numPad0.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_numPad0);

            _decimal.KeyValue = 110;
            _decimal.KeyCode = Forms.Keys.Decimal;
            _decimal.KeyData = Forms.Keys.Decimal;
            _decimal.Name = "Decimal";
            _decimal.Size = _squareSize;
            _decimal.Text = ",";
            _decimal.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_decimal);

            return keys;
        }

        private static void DoLayout(List<Key> keys)
        {
            var xCoordinate = BaseLength;
            var yCoordinate = BaseLength;

            foreach (var key in keys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "F4" || key.Name == "F12" || key.Name == "Pause")
                {
                    xCoordinate += BaseLength / 2;
                }
                else if (key.Name == "F8")
                {
                    xCoordinate += BaseLength / 2 + _offset;
                }
                else if (key.Name == "Escape")
                        {
                    xCoordinate += BaseLength + _offset;
                }
                else if (key.Name == "Back" || key.Name == "PageUp" || key.Name == "Return" || key.Name == "PageDown" || key.Name == "RightControl" || key.Name == "Right")
                {
                    xCoordinate += BaseLength / 2;
                }
                else if (key.Name == "Oem1")
                {
                    xCoordinate += Convert.ToInt32(BaseLength * 0.20) + _offset;
                }
                else if (key.Name == "OemQuestion")
                {
                    xCoordinate += Convert.ToInt32((BaseLength * 5.25) + (4 * _offset));
                }
                else if (key.Name == "RightShift" || key.Name == "Up")
                {
                    xCoordinate += Convert.ToInt32((BaseLength * 1.5) + _offset);
                }

                // New row
                if (key.Name == "LaunchApplication2")
                {
                    xCoordinate = BaseLength;
                    yCoordinate += key.Height * 2;
                }
                else if (key.Name == "Subtract" || key.Name == "Add" || key.Name == "NumPad6" || key.Name == "Enter")
                {
                    xCoordinate = BaseLength;
                    yCoordinate += BaseLength + _offset;
                }
            }
        }
    }
}
