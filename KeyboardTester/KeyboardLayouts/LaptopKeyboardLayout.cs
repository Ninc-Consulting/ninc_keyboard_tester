using Forms = System.Windows.Forms;

namespace KeyboardTester.KeyboardLayouts
{
    public class LaptopKeyboardLayout : KeyboardLayout
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
        private readonly Key _numLock = new();
        private readonly Key _printScreen = new();
        private readonly Key _scroll = new();
        private readonly Key _pause = new();
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
        private readonly Key _home = new();
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
        private readonly Key _oemQuestion = new();
        private readonly Key _pageUp = new();
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
        private readonly Key _return = new();
        private readonly Key _pageDown = new();
        private readonly Key _leftShift = new();
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
        private readonly Key _end = new();
        private readonly Key _leftControl = new();
        private readonly Key _fn = new();
        private readonly Key _leftWindows = new();
        private readonly Key _alt = new();
        private readonly Key _oemBackslash = new();
        private readonly Key _space = new();
        private readonly Key _altGr = new();
        private readonly Key _apps = new();
        private readonly Key _insert = new();
        private readonly Key _delete = new();
        private readonly Key _up = new();
        private readonly Key _left = new();
        private readonly Key _down = new();
        private readonly Key _right = new();

        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new(BaseLength, BaseLength);
        private static readonly Size _squareSize0_9 = new(Convert.ToInt32(BaseLength * 0.9), Convert.ToInt32(BaseLength * 0.75));
        private static readonly Size _rectangleSize0_9 = new(Convert.ToInt32(BaseLength * 0.9), BaseLength);
        private static readonly Size _rectangleSize1_25 = new(Convert.ToInt32(BaseLength * 1.25) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_5 = new(Convert.ToInt32(BaseLength * 1.5) + _offset, BaseLength);
        private static readonly Size _rectangleSize1_75 = new(Convert.ToInt32(BaseLength * 1.75) + _offset, BaseLength);
        private static readonly Size _rectangleSize2_25 = new(Convert.ToInt32(BaseLength * 2.25) + _offset, BaseLength);
        private static readonly Size _spaceBarSize = new(Convert.ToInt32(BaseLength * 3.5) + _offset, BaseLength);

        public LaptopKeyboardLayout(int baseLength) : base (baseLength)
        {
            var keys = InitiateLaptopKeyboarLayout();
            base.AddKeysToBaseClass(keys);
        }

        private List<Key> InitiateLaptopKeyboarLayout()
        {
            var keys = InitiateKeys();
            DoLayout(keys, BaseLength);

            return keys;
        }

        private List<Key> InitiateKeys()
        {
            var keys = new List<Key>();

            _escape.KeyValue = 27;
            _escape.KeyCode = Forms.Keys.Escape;
            _escape.KeyData = Forms.Keys.Escape;
            _escape.Name = "Escape";
            _escape.Size = _squareSize0_9;
            _escape.Text = "ESC";
            _escape.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_escape);

            _f1.KeyValue = 112;
            _f1.KeyCode = Forms.Keys.F1;
            _f1.KeyData = Forms.Keys.F1;
            _f1.Name = "F1";
            _f1.Size = _squareSize0_9;
            _f1.Text = "F1";
            _f1.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f1);

            _f2.KeyValue = 113;
            _f2.KeyCode = Forms.Keys.F2;
            _f2.KeyData = Forms.Keys.F2;
            _f2.Name = "F2";
            _f2.Size = _squareSize0_9;
            _f2.Text = "F2";
            _f2.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f2);

            _f3.KeyValue = 114;
            _f3.KeyCode = Forms.Keys.F3;
            _f3.KeyData = Forms.Keys.F3;
            _f3.Name = "F3";
            _f3.Size = _squareSize0_9;
            _f3.Text = "F3";
            _f3.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f3);

            _f4.KeyValue = 115;
            _f4.KeyCode = Forms.Keys.F4;
            _f4.KeyData = Forms.Keys.F4;
            _f4.Name = "F4";
            _f4.Size = _squareSize0_9;
            _f4.Text = "F4";
            _f4.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f4);

            _f5.KeyValue = 116;
            _f5.KeyCode = Forms.Keys.F5;
            _f5.KeyData = Forms.Keys.F5;
            _f5.Name = "F5";
            _f5.Size = _squareSize0_9;
            _f5.Text = "F5";
            _f5.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f5);

            _f6.KeyValue = 117;
            _f6.KeyCode = Forms.Keys.F6;
            _f6.KeyData = Forms.Keys.F6;
            _f6.Name = "F6";
            _f6.Size = _squareSize0_9;
            _f6.Text = "F6";
            _f6.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f6);

            _f7.KeyValue = 118;
            _f7.KeyCode = Forms.Keys.F7;
            _f7.KeyData = Forms.Keys.F7;
            _f7.Name = "F7";
            _f7.Size = _squareSize0_9;
            _f7.Text = "F7";
            _f7.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f7);

            _f8.KeyValue = 119;
            _f8.KeyCode = Forms.Keys.F8;
            _f8.KeyData = Forms.Keys.F8;
            _f8.Name = "F8";
            _f8.Size = _squareSize0_9;
            _f8.Text = "F8";
            _f8.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f8);

            _f9.KeyValue = 120;
            _f9.KeyCode = Forms.Keys.F9;
            _f9.KeyData = Forms.Keys.F9;
            _f9.Name = "F9";
            _f9.Size = _squareSize0_9;
            _f9.Text = "F9";
            _f9.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f9);

            _f10.KeyValue = 121;
            _f10.KeyCode = Forms.Keys.F10;
            _f10.KeyData = Forms.Keys.F10;
            _f10.Name = "F10";
            _f10.Size = _squareSize0_9;
            _f10.Text = "F10";
            _f10.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f10);

            _f11.KeyValue = 122;
            _f11.KeyCode = Forms.Keys.F11;
            _f11.KeyData = Forms.Keys.F11;
            _f11.Name = "F11";
            _f11.Size = _squareSize0_9;
            _f11.Text = "F11";
            _f11.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f11);

            _f12.KeyValue = 123;
            _f12.KeyCode = Forms.Keys.F12;
            _f12.KeyData = Forms.Keys.F12;
            _f12.Name = "F12";
            _f12.Size = _squareSize0_9;
            _f12.Text = "F12";
            _f12.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f12);

            _numLock.KeyValue = 144;
            _numLock.KeyCode = Forms.Keys.NumLock;
            _numLock.KeyData = Forms.Keys.NumLock;
            _numLock.Name = "NumLock";
            _numLock.Size = _squareSize0_9;
            _numLock.Text = "NumLk";
            _numLock.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_numLock);

            _printScreen.KeyValue = 44;
            _printScreen.KeyCode = Forms.Keys.PrintScreen;
            _printScreen.KeyData = Forms.Keys.PrintScreen;
            _printScreen.Name = "PrintScreen";
            _printScreen.Size = _squareSize0_9;
            _printScreen.Text = "PrtSc\nSysRq";
            _printScreen.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_printScreen);

            _scroll.KeyValue = 145;
            _scroll.KeyCode = Forms.Keys.Scroll;
            _scroll.KeyData = Forms.Keys.Scroll;
            _scroll.Name = "Scroll";
            _scroll.Size = _squareSize0_9;
            _scroll.Text = "ScrLk";
            _scroll.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_scroll);

            _pause.KeyValue = 19;
            _pause.KeyCode = Forms.Keys.Pause;
            _pause.KeyData = Forms.Keys.Pause;
            _pause.Name = "Pause";
            _pause.Size = _squareSize0_9;
            _pause.Text = "Pause\nBreak";
            _pause.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pause);

            _oem5.KeyValue = 220;
            _oem5.KeyCode = Forms.Keys.Oem5;
            _oem5.KeyData = Forms.Keys.Oem5;
            _oem5.Name = "Oem5";
            _oem5.Size = _rectangleSize0_9;
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
            _back.Size = _rectangleSize1_25;
            _back.Text = "←";
            _back.TextAlign = ContentAlignment.MiddleLeft;
            keys.Add(_back);

            _home.KeyValue = 36;
            _home.KeyCode = Forms.Keys.Home;
            _home.KeyData = Forms.Keys.Home;
            _home.Name = "Home";
            _home.Size = _rectangleSize0_9;
            _home.Text = "Home";
            _home.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_home);

            _tab.KeyValue = 9;
            _tab.KeyCode = Forms.Keys.Tab;
            _tab.KeyData = Forms.Keys.Tab;
            _tab.Name = "Tab";
            _tab.Size = _rectangleSize1_5;
            _tab.Text = "↹";
            _tab.TextAlign = ContentAlignment.MiddleCenter;
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

            _oemQuestion.KeyValue = 191;
            _oemQuestion.KeyCode = Forms.Keys.OemQuestion;
            _oemQuestion.KeyData = Forms.Keys.OemQuestion;
            _oemQuestion.Name = "OemQuestion";
            _oemQuestion.Size = _rectangleSize0_9;
            _oemQuestion.Text = "*";
            _oemQuestion.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemQuestion);

            _pageUp.KeyValue = 33;
            _pageUp.KeyCode = Forms.Keys.PageUp;
            _pageUp.KeyData = Forms.Keys.PageUp;
            _pageUp.Name = "PageUp";
            _pageUp.Size = _rectangleSize0_9;
            _pageUp.Text = "PgUp";
            _pageUp.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pageUp);

            _caps.KeyValue = 20;
            _caps.KeyCode = Forms.Keys.Capital;
            _caps.KeyData = Forms.Keys.Capital;
            _caps.Name = "Caps";
            _caps.Size = _rectangleSize1_75;
            _caps.Text = "Caps Lock";
            _caps.TextAlign = ContentAlignment.MiddleCenter;
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

            _return.KeyValue = 13;
            _return.KeyCode = Forms.Keys.Return;
            _return.KeyData = Forms.Keys.Return;
            _return.Name = "Return";
            _return.Size = _rectangleSize1_25;
            _return.Text = "Enter ↩";
            _return.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_return);

            _pageDown.KeyValue = 34;
            _pageDown.KeyCode = Forms.Keys.PageDown;
            _pageDown.KeyData = Forms.Keys.PageDown;
            _pageDown.Name = "PageDown";
            _pageDown.Size = _rectangleSize0_9;
            _pageDown.Text = "PgDn";
            _pageDown.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pageDown);

            _leftShift.KeyValue = 16;
            _leftShift.KeyCode = Forms.Keys.ShiftKey;
            _leftShift.KeyData = Forms.Keys.ShiftKey | Forms.Keys.Shift;
            _leftShift.Name = "LeftShift";
            _leftShift.Size = _rectangleSize2_25;
            _leftShift.Text = "↑ Shift";
            _leftShift.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftShift);

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

            _rightShift.KeyValue = -16;  // Inverting the KeyValue to distinguish between left and right shift since they both have the same KeyValue
            _rightShift.KeyCode = Forms.Keys.ShiftKey;
            _rightShift.KeyData = Forms.Keys.ShiftKey | Forms.Keys.Shift;
            _rightShift.Name = "RightShift";
            _rightShift.Size = _rectangleSize2_25;
            _rightShift.Text = "↑ Shift";
            _rightShift.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_rightShift);

            _end.KeyValue = 35;
            _end.KeyCode = Forms.Keys.End;
            _end.KeyData = Forms.Keys.End;
            _end.Name = "End";
            _end.Size = _squareSize;
            _end.Text = "End";
            _end.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_end);

            _leftControl.KeyValue = 17;
            _leftControl.KeyCode = Forms.Keys.ControlKey;
            _leftControl.KeyData = Forms.Keys.ControlKey | Forms.Keys.Control;
            _leftControl.Name = "LeftControl";
            _leftControl.Size = _squareSize;
            _leftControl.Text = "Ctrl";
            _leftControl.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftControl);

            //_leftControl.KeyValue = -999;
            //_leftControl.KeyCode = Forms.Keys.ControlKey;
            //_leftControl.KeyData = Forms.Keys.ControlKey | Forms.Keys.Control;
            _fn.Name = "Fn";
            _fn.Size = _squareSize;
            _fn.Text = "Fn";
            _fn.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_fn);

            _leftWindows.KeyValue = 91;
            _leftWindows.KeyCode = Forms.Keys.LWin;
            _leftWindows.KeyData = Forms.Keys.LWin;
            _leftWindows.Name = "LeftWindows";
            _leftWindows.Size = _squareSize;
            _leftWindows.Text = "⊞";
            _leftWindows.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftWindows);

            _alt.KeyValue = 18;
            _alt.KeyCode = Forms.Keys.Menu;
            _alt.KeyData = Forms.Keys.Menu | Forms.Keys.Alt;
            _alt.Name = "Alt";
            _alt.Size = _squareSize;
            _alt.Text = "Alt";
            _alt.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_alt);

            _oemBackslash.KeyValue = 226;
            _oemBackslash.KeyCode = Forms.Keys.OemBackslash;
            _oemBackslash.KeyData = Forms.Keys.OemBackslash;
            _oemBackslash.Name = "OemBackslash";
            _oemBackslash.Size = _squareSize;
            _oemBackslash.Text = ">\n<";
            _oemBackslash.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemBackslash);

            _space.KeyValue = 32;
            _space.KeyCode = Forms.Keys.Space;
            _space.KeyData = Forms.Keys.Space;
            _space.Name = "Space";
            _space.Size = _spaceBarSize;
            _space.Text = "";
            keys.Add(_space);

            _altGr.KeyValue = -18;    // Inverting the KeyValue to distinguish between left and right Alt since they both have the same KeyValue
            _altGr.KeyCode = Forms.Keys.Menu;
            _altGr.KeyData = Forms.Keys.Menu | Forms.Keys.Control | Forms.Keys.Alt;
            _altGr.Name = "AltGr";
            _altGr.Size = _squareSize;
            _altGr.Text = "Alt Gr";
            _altGr.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_altGr);

            _apps.KeyValue = 93;
            _apps.KeyCode = Forms.Keys.Apps;
            _apps.KeyData = Forms.Keys.Apps;
            _apps.Name = "Apps";
            _apps.Size = _squareSize;
            _apps.Text = "≣";
            _apps.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_apps);

            _insert.KeyValue = 45;
            _insert.KeyCode = Forms.Keys.Insert;
            _insert.KeyData = Forms.Keys.Insert;
            _insert.Name = "Insert";
            _insert.Size = _squareSize;
            _insert.Text = "Ins";
            _insert.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_insert);

            _delete.KeyValue = 46;
            _delete.KeyCode = Forms.Keys.Delete;
            _delete.KeyData = Forms.Keys.Delete;
            _delete.Name = "Delete";
            _delete.Size = _squareSize;
            _delete.Text = "Del";
            _delete.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_delete);

            _up.KeyValue = 38;
            _up.KeyCode = Forms.Keys.Up;
            _up.KeyData = Forms.Keys.Up;
            _up.Name = "Up";
            _up.Size = _squareSize0_9;
            _up.Text = "↑";
            _up.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_up);

            _left.KeyValue = 37;
            _left.KeyCode = Forms.Keys.Left;
            _left.KeyData = Forms.Keys.Left;
            _left.Name = "Left";
            _left.Size = _squareSize0_9;
            _left.Text = "←";
            _left.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_left);

            _down.KeyValue = 40;
            _down.KeyCode = Forms.Keys.Down;
            _down.KeyData = Forms.Keys.Down;
            _down.Name = "Down";
            _down.Size = _squareSize0_9;
            _down.Text = "↓";
            _down.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_down);

            _right.KeyValue = 39;
            _right.KeyCode = Forms.Keys.Right;
            _right.KeyData = Forms.Keys.Right;
            _right.Name = "Right";
            _right.Size = _squareSize0_9;
            _right.Text = "→";
            _right.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_right);

            return keys;
        }

        private static void DoLayout(List<Key> keys, int startingYCoordinate)
        {
            var xCoordinate = BaseLength;
            var yCoordinate = startingYCoordinate;

            foreach (var key in keys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "Escape")
                {
                    xCoordinate += Convert.ToInt32(key.Width * 0.25);
                }
                else if (key.Name == "Delete")
                {
                    xCoordinate += _squareSize0_9.Width + _offset;
                }

                if (key.Name == "Pause" || key.Name == "Home" || key.Name == "PageUp" || key.Name == "PageDown" || key.Name == "End")
                {
                    xCoordinate = BaseLength;
                    yCoordinate += key.Height + _offset;
                }
                else if (key.Name == "Up")
                {
                    xCoordinate -= key.Width * 2 + _offset * 2;
                    yCoordinate += key.Height + _offset;
                }
            }
        }
    }
}
