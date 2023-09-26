namespace KeyboardTester.KeyboardLayouts
{
    public class ToughbookKeyboardLayout : KeyboardLayout
    {
        // Sizes
        private static readonly int _offset = Convert.ToInt32(BaseLength * 0.05);

        private static readonly Size _squareSize = new (BaseLength, BaseLength);
        private static readonly Size _squareSize0_8 = new (Convert.ToInt32(BaseLength * 0.8), Convert.ToInt32(BaseLength * 0.8));
        private static readonly Size _squareSize0_85 = new (Convert.ToInt32(BaseLength * 0.85), Convert.ToInt32(BaseLength * 0.85));
        private static readonly Size _rectangleSize0_75 = new (Convert.ToInt32(BaseLength * 0.75), BaseLength);
        private static readonly Size _rectangleSize0_9 = new (Convert.ToInt32(BaseLength * 0.9), BaseLength);
        private static readonly Size _rectangleSize1_25 = new (Convert.ToInt32(BaseLength * 1.25) + (_offset / 4), BaseLength);
        private static readonly Size _rectangleSize1_5 = new (Convert.ToInt32(BaseLength * 1.5) + (_offset / 2), BaseLength);
        private static readonly Size _rectangleSize2 = new ((BaseLength * 2) + _offset, BaseLength);
        private static readonly Size _spaceBarSize = new (Convert.ToInt32(BaseLength * 3.5) + Convert.ToInt32(_offset * 2.5), BaseLength);

        // Keys
        private readonly Key _escape = new ();
        private readonly Key _f1 = new ();
        private readonly Key _f2 = new ();
        private readonly Key _f3 = new ();
        private readonly Key _f4 = new ();
        private readonly Key _f5 = new ();
        private readonly Key _f6 = new ();
        private readonly Key _f7 = new ();
        private readonly Key _f8 = new ();
        private readonly Key _f9 = new ();
        private readonly Key _f10 = new ();
        private readonly Key _f11 = new ();
        private readonly Key _f12 = new ();
        private readonly Key _numLock = new ();
        private readonly Key _printScreen = new ();
        private readonly Key _scroll = new ();
        private readonly Key _pause = new ();
        private readonly Key _oem5 = new ();
        private readonly Key _d0 = new ();
        private readonly Key _d1 = new ();
        private readonly Key _d2 = new ();
        private readonly Key _d3 = new ();
        private readonly Key _d4 = new ();
        private readonly Key _d5 = new ();
        private readonly Key _d6 = new ();
        private readonly Key _d7 = new ();
        private readonly Key _d8 = new ();
        private readonly Key _d9 = new ();
        private readonly Key _oemPlus = new ();
        private readonly Key _oemOpenBrackets = new ();
        private readonly Key _back = new ();
        private readonly Key _home = new ();
        private readonly Key _tab = new ();
        private readonly Key _q = new ();
        private readonly Key _w = new ();
        private readonly Key _e = new ();
        private readonly Key _r = new ();
        private readonly Key _t = new ();
        private readonly Key _y = new ();
        private readonly Key _u = new ();
        private readonly Key _i = new ();
        private readonly Key _o = new ();
        private readonly Key _p = new ();
        private readonly Key _oem6 = new ();
        private readonly Key _oem1 = new ();
        private readonly Key _oemQuestion = new ();
        private readonly Key _pageUp = new ();
        private readonly Key _caps = new ();
        private readonly Key _a = new ();
        private readonly Key _s = new ();
        private readonly Key _d = new ();
        private readonly Key _f = new ();
        private readonly Key _g = new ();
        private readonly Key _h = new ();
        private readonly Key _j = new ();
        private readonly Key _k = new ();
        private readonly Key _l = new ();
        private readonly Key _oemTilde = new ();
        private readonly Key _oem7 = new ();
        private readonly Key _return = new ();
        private readonly Key _pageDown = new ();
        private readonly Key _leftShift = new ();
        private readonly Key _z = new ();
        private readonly Key _x = new ();
        private readonly Key _c = new ();
        private readonly Key _v = new ();
        private readonly Key _b = new ();
        private readonly Key _n = new ();
        private readonly Key _m = new ();
        private readonly Key _oemComma = new ();
        private readonly Key _oemPeriod = new ();
        private readonly Key _oemMinus = new ();
        private readonly Key _rightShift = new ();
        private readonly Key _end = new ();
        private readonly Key _leftControl = new ();
        private readonly Key _fn = new ();
        private readonly Key _leftWindows = new ();
        private readonly Key _alt = new ();
        private readonly Key _oemBackslash = new ();
        private readonly Key _space = new ();
        private readonly Key _altGr = new ();
        private readonly Key _apps = new ();
        private readonly Key _insert = new ();
        private readonly Key _delete = new ();
        private readonly Key _up = new ();
        private readonly Key _left = new ();
        private readonly Key _down = new ();
        private readonly Key _right = new ();

        public ToughbookKeyboardLayout(int baseLength)
            : base(baseLength)
        {
            var keys = InitiateToughbookKeyboarLayout();
            AddKeysToBaseClass(keys);
        }

        private List<Key> InitiateToughbookKeyboarLayout()
        {
            var keys = InitiateKeys();
            DoLayout(keys, BaseLength);

            return keys;
        }

        private List<Key> InitiateKeys()
        {
            var keys = new List<Key>();

            _escape.KeyValue = 27;
            _escape.KeyCode = Keys.Escape;
            _escape.KeyData = Keys.Escape;
            _escape.Name = "Escape";
            _escape.Size = _squareSize0_85;
            _escape.Text = "ESC";
            _escape.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_escape);

            _f1.KeyValue = 112;
            _f1.KeyCode = Keys.F1;
            _f1.KeyData = Keys.F1;
            _f1.Name = "F1";
            _f1.Size = _squareSize0_85;
            _f1.Text = "F1\n▼☼";
            _f1.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f1);

            _f2.KeyValue = 113;
            _f2.KeyCode = Keys.F2;
            _f2.KeyData = Keys.F2;
            _f2.Name = "F2";
            _f2.Size = _squareSize0_85;
            _f2.Text = "F2\n▲☼";
            _f2.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f2);

            _f3.KeyValue = 114;
            _f3.KeyCode = Keys.F3;
            _f3.KeyData = Keys.F3;
            _f3.Name = "F3";
            _f3.Size = _squareSize0_85;
            _f3.Text = "F3\n▢/▣";
            _f3.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f3);

            _f4.KeyValue = 115;
            _f4.KeyCode = Keys.F4;
            _f4.KeyData = Keys.F4;
            _f4.Name = "F4";
            _f4.Size = _squareSize0_85;
            _f4.Text = "F4\n🔇";
            _f4.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f4);

            _f5.KeyValue = 116;
            _f5.KeyCode = Keys.F5;
            _f5.KeyData = Keys.F5;
            _f5.Name = "F5";
            _f5.Size = _squareSize0_85;
            _f5.Text = "F5\n▼🔊";
            _f5.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f5);

            _f6.KeyValue = 117;
            _f6.KeyCode = Keys.F6;
            _f6.KeyData = Keys.F6;
            _f6.Name = "F6";
            _f6.Size = _squareSize0_85;
            _f6.Text = "F6\n▲🔊";
            _f6.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f6);

            _f7.KeyValue = 118;
            _f7.KeyCode = Keys.F7;
            _f7.KeyData = Keys.F7;
            _f7.Name = "F7";
            _f7.Size = _squareSize0_85;
            _f7.Text = "F7";
            _f7.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f7);

            _f8.KeyValue = 119;
            _f8.KeyCode = Keys.F8;
            _f8.KeyData = Keys.F8;
            _f8.Name = "F8";
            _f8.Size = _squareSize0_85;
            _f8.Text = "F8";
            _f8.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f8);

            _f9.KeyValue = 120;
            _f9.KeyCode = Keys.F9;
            _f9.KeyData = Keys.F9;
            _f9.Name = "F9";
            _f9.Size = _squareSize0_85;
            _f9.Text = "F9";
            _f9.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f9);

            _f10.KeyValue = 121;
            _f10.KeyCode = Keys.F10;
            _f10.KeyData = Keys.F10;
            _f10.Name = "F10";
            _f10.Size = _squareSize0_85;
            _f10.Text = "F10";
            _f10.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f10);

            _f11.KeyValue = 122;
            _f11.KeyCode = Keys.F11;
            _f11.KeyData = Keys.F11;
            _f11.Name = "F11";
            _f11.Size = _squareSize0_85;
            _f11.Text = "F11";
            _f11.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f11);

            _f12.KeyValue = 123;
            _f12.KeyCode = Keys.F12;
            _f12.KeyData = Keys.F12;
            _f12.Name = "F12";
            _f12.Size = _squareSize0_85;
            _f12.Text = "F12";
            _f12.TextAlign = ContentAlignment.TopCenter;
            keys.Add(_f12);

            _numLock.KeyValue = 144;
            _numLock.KeyCode = Keys.NumLock;
            _numLock.KeyData = Keys.NumLock;
            _numLock.Name = "NumLock";
            _numLock.Size = _squareSize0_85;
            _numLock.Text = "NumLk";
            _numLock.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_numLock);

            _printScreen.KeyValue = 44;
            _printScreen.KeyCode = Keys.PrintScreen;
            _printScreen.KeyData = Keys.PrintScreen;
            _printScreen.Name = "PrintScreen";
            _printScreen.Size = _squareSize0_85;
            _printScreen.Text = "PrtSc\nSysRq";
            _printScreen.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_printScreen);

            _scroll.KeyValue = 145;
            _scroll.KeyCode = Keys.Scroll;
            _scroll.KeyData = Keys.Scroll;
            _scroll.Name = "Scroll";
            _scroll.Size = _squareSize0_85;
            _scroll.Text = "ScrLk";
            _scroll.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_scroll);

            _pause.KeyValue = 19;
            _pause.KeyCode = Keys.Pause;
            _pause.KeyData = Keys.Pause;
            _pause.Name = "Pause";
            _pause.Size = _squareSize0_85;
            _pause.Text = "Pause\nBreak";
            _pause.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pause);

            _oem5.KeyValue = 220;
            _oem5.KeyCode = Keys.Oem5;
            _oem5.KeyData = Keys.Oem5;
            _oem5.Name = "Oem5";
            _oem5.Size = _rectangleSize0_75;
            _oem5.Text = "§½";
            _oem5.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oem5);

            _d1.KeyValue = 49;
            _d1.KeyCode = Keys.D1;
            _d1.KeyData = Keys.D1;
            _d1.Name = "D1";
            _d1.Size = _squareSize;
            _d1.Text = "1";
            _d1.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d1);

            _d2.KeyValue = 50;
            _d2.KeyCode = Keys.D2;
            _d2.KeyData = Keys.D2;
            _d2.Name = "D2";
            _d2.Size = _squareSize;
            _d2.Text = "2";
            _d2.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d2);

            _d3.KeyValue = 51;
            _d3.KeyCode = Keys.D3;
            _d3.KeyData = Keys.D3;
            _d3.Name = "D3";
            _d3.Size = _squareSize;
            _d3.Text = "3";
            _d3.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d3);

            _d4.KeyValue = 52;
            _d4.KeyCode = Keys.D4;
            _d4.KeyData = Keys.D4;
            _d4.Name = "D4";
            _d4.Size = _squareSize;
            _d4.Text = "4";
            _d4.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d4);

            _d5.KeyValue = 53;
            _d5.KeyCode = Keys.D5;
            _d5.KeyData = Keys.D5;
            _d5.Name = "D5";
            _d5.Size = _squareSize;
            _d5.Text = "5";
            _d5.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d5);

            _d6.KeyValue = 54;
            _d6.KeyCode = Keys.D6;
            _d6.KeyData = Keys.D6;
            _d6.Name = "D6";
            _d6.Size = _squareSize;
            _d6.Text = "6";
            _d6.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d6);

            _d7.KeyValue = 55;
            _d7.KeyCode = Keys.D7;
            _d7.KeyData = Keys.D7;
            _d7.Name = "D7";
            _d7.Size = _squareSize;
            _d7.Text = "7";
            _d7.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d7);

            _d8.KeyValue = 56;
            _d8.KeyCode = Keys.D8;
            _d8.KeyData = Keys.D8;
            _d8.Name = "D8";
            _d8.Size = _squareSize;
            _d8.Text = "8";
            _d8.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d8);

            _d9.KeyValue = 57;
            _d9.KeyCode = Keys.D9;
            _d9.KeyData = Keys.D9;
            _d9.Name = "D9";
            _d9.Size = _squareSize;
            _d9.Text = "9";
            _d9.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d9);

            _d0.KeyValue = 48;
            _d0.KeyCode = Keys.D0;
            _d0.KeyData = Keys.D0;
            _d0.Name = "D0";
            _d0.Size = _squareSize;
            _d0.Text = "0";
            _d0.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_d0);

            _oemPlus.KeyValue = 187;
            _oemPlus.KeyCode = Keys.Oemplus;
            _oemPlus.KeyData = Keys.Oemplus;
            _oemPlus.Name = "OemPlus";
            _oemPlus.Size = _squareSize;
            _oemPlus.Text = @"+";
            _oemPlus.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemPlus);

            _oemOpenBrackets.KeyValue = 219;
            _oemOpenBrackets.KeyCode = Keys.OemOpenBrackets;
            _oemOpenBrackets.KeyData = Keys.OemOpenBrackets;
            _oemOpenBrackets.Name = "OemOpenBrackets";
            _oemOpenBrackets.Size = _squareSize;
            _oemOpenBrackets.Text = @"\";
            _oemOpenBrackets.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemOpenBrackets);

            _back.KeyValue = 8;
            _back.KeyCode = Keys.Back;
            _back.KeyData = Keys.Back;
            _back.Name = "Back";
            _back.Size = _rectangleSize1_25;
            _back.Text = "←";
            _back.TextAlign = ContentAlignment.MiddleLeft;
            keys.Add(_back);

            _home.KeyValue = 36;
            _home.KeyCode = Keys.Home;
            _home.KeyData = Keys.Home;
            _home.Name = "Home";
            _home.Size = _rectangleSize0_9;
            _home.Text = "Home";
            _home.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_home);

            _tab.KeyValue = 9;
            _tab.KeyCode = Keys.Tab;
            _tab.KeyData = Keys.Tab;
            _tab.Name = "Tab";
            _tab.Size = _rectangleSize1_25;
            _tab.Text = "⭾";
            _tab.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_tab);

            _q.KeyValue = 81;
            _q.KeyCode = Keys.Q;
            _q.KeyData = Keys.Q;
            _q.Name = "Q";
            _q.Size = _squareSize;
            _q.Text = "Q";
            _q.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_q);

            _w.KeyValue = 87;
            _w.KeyCode = Keys.W;
            _w.KeyData = Keys.W;
            _w.Name = "W";
            _w.Size = _squareSize;
            _w.Text = "W";
            _w.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_w);

            _e.KeyValue = 69;
            _e.KeyCode = Keys.E;
            _e.KeyData = Keys.E;
            _e.Name = "E";
            _e.Size = _squareSize;
            _e.Text = "E";
            _e.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_e);

            _r.KeyValue = 82;
            _r.KeyCode = Keys.R;
            _r.KeyData = Keys.R;
            _r.Name = "R";
            _r.Size = _squareSize;
            _r.Text = "R";
            _r.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_r);

            _t.KeyValue = 84;
            _t.KeyCode = Keys.T;
            _t.KeyData = Keys.T;
            _t.Name = "T";
            _t.Size = _squareSize;
            _t.Text = "T";
            _t.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_t);

            _y.KeyValue = 89;
            _y.KeyCode = Keys.Y;
            _y.KeyData = Keys.Y;
            _y.Name = "Y";
            _y.Size = _squareSize;
            _y.Text = "Y";
            _y.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_y);

            _u.KeyValue = 85;
            _u.KeyCode = Keys.U;
            _u.KeyData = Keys.U;
            _u.Name = "U";
            _u.Size = _squareSize;
            _u.Text = "U";
            _u.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_u);

            _i.KeyValue = 73;
            _i.KeyCode = Keys.I;
            _i.KeyData = Keys.I;
            _i.Name = "I";
            _i.Size = _squareSize;
            _i.Text = "I";
            _i.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_i);

            _o.KeyValue = 79;
            _o.KeyCode = Keys.O;
            _o.KeyData = Keys.O;
            _o.Name = "O";
            _o.Size = _squareSize;
            _o.Text = "O";
            _o.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_o);

            _p.KeyValue = 80;
            _p.KeyCode = Keys.P;
            _p.KeyData = Keys.P;
            _p.Name = "P";
            _p.Size = _squareSize;
            _p.Text = "P";
            _p.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_p);

            _oem6.KeyValue = 221;
            _oem6.KeyCode = Keys.Oem6;
            _oem6.KeyData = Keys.Oem6;
            _oem6.Name = "Oem6";
            _oem6.Size = _squareSize;
            _oem6.Text = "Å";
            _oem6.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem6);

            _oem1.KeyValue = 186;
            _oem1.KeyCode = Keys.Oem1;
            _oem1.KeyData = Keys.Oem1;
            _oem1.Name = "Oem1";
            _oem1.Size = _squareSize;
            _oem1.Text = "^";
            _oem1.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem1);

            _oemQuestion.KeyValue = 191;
            _oemQuestion.KeyCode = Keys.OemQuestion;
            _oemQuestion.KeyData = Keys.OemQuestion;
            _oemQuestion.Name = "OemQuestion";
            _oemQuestion.Size = _rectangleSize0_75;
            _oemQuestion.Text = "*";
            _oemQuestion.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemQuestion);

            _pageUp.KeyValue = 33;
            _pageUp.KeyCode = Keys.PageUp;
            _pageUp.KeyData = Keys.PageUp;
            _pageUp.Name = "PageUp";
            _pageUp.Size = _rectangleSize0_9;
            _pageUp.Text = "PgUp";
            _pageUp.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pageUp);

            _caps.KeyValue = 20;
            _caps.KeyCode = Keys.Capital;
            _caps.KeyData = Keys.Capital;
            _caps.Name = "Caps";
            _caps.Size = _rectangleSize1_5;
            _caps.Text = "Caps Lock";
            _caps.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_caps);

            _a.KeyValue = 65;
            _a.KeyCode = Keys.A;
            _a.KeyData = Keys.A;
            _a.Name = "A";
            _a.Size = _squareSize;
            _a.Text = "A";
            _a.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_a);

            _s.KeyValue = 83;
            _s.KeyCode = Keys.S;
            _s.KeyData = Keys.S;
            _s.Name = "S";
            _s.Size = _squareSize;
            _s.Text = "S";
            _s.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_s);

            _d.KeyValue = 68;
            _d.KeyCode = Keys.D;
            _d.KeyData = Keys.D;
            _d.Name = "D";
            _d.Size = _squareSize;
            _d.Text = "D";
            _d.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_d);

            _f.KeyValue = 70;
            _f.KeyCode = Keys.F;
            _f.KeyData = Keys.F;
            _f.Name = "F";
            _f.Size = _squareSize;
            _f.Text = "F";
            _f.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_f);

            _g.KeyValue = 71;
            _g.KeyCode = Keys.G;
            _g.KeyData = Keys.G;
            _g.Name = "G";
            _g.Size = _squareSize;
            _g.Text = "G";
            _g.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_g);

            _h.KeyValue = 72;
            _h.KeyCode = Keys.H;
            _h.KeyData = Keys.H;
            _h.Name = "H";
            _h.Size = _squareSize;
            _h.Text = "H";
            _h.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_h);

            _j.KeyValue = 74;
            _j.KeyCode = Keys.J;
            _j.KeyData = Keys.J;
            _j.Name = "J";
            _j.Size = _squareSize;
            _j.Text = "J";
            _j.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_j);

            _k.KeyValue = 75;
            _k.KeyCode = Keys.K;
            _k.KeyData = Keys.K;
            _k.Name = "K";
            _k.Size = _squareSize;
            _k.Text = "K";
            _k.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_k);

            _l.KeyValue = 76;
            _l.KeyCode = Keys.L;
            _l.KeyData = Keys.L;
            _l.Name = "L";
            _l.Size = _squareSize;
            _l.Text = "L";
            _l.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_l);

            _oemTilde.KeyValue = 192;
            _oemTilde.KeyCode = Keys.Oemtilde;
            _oemTilde.KeyData = Keys.Oemtilde;
            _oemTilde.Name = "Oemtilde";
            _oemTilde.Size = _squareSize;
            _oemTilde.Text = "Ö";
            _oemTilde.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemTilde);

            _oem7.KeyValue = 222;
            _oem7.KeyCode = Keys.Oem7;
            _oem7.KeyData = Keys.Oem7;
            _oem7.Name = "Oem7";
            _oem7.Size = _squareSize;
            _oem7.Text = "Ä";
            _oem7.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oem7);

            _return.KeyValue = 13;
            _return.KeyCode = Keys.Return;
            _return.KeyData = Keys.Return;
            _return.Name = "Return";
            _return.Size = _rectangleSize1_5;
            _return.Text = "Enter ↩";
            _return.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_return);

            _pageDown.KeyValue = 34;
            _pageDown.KeyCode = Keys.PageDown;
            _pageDown.KeyData = Keys.PageDown;
            _pageDown.Name = "PageDown";
            _pageDown.Size = _rectangleSize0_9;
            _pageDown.Text = "PgDn";
            _pageDown.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_pageDown);

            _leftShift.KeyValue = 160;
            _leftShift.KeyCode = Keys.ShiftKey;
            _leftShift.KeyData = Keys.ShiftKey | Keys.Shift;
            _leftShift.Name = "LeftShift";
            _leftShift.Size = _rectangleSize2;
            _leftShift.Text = "↑ Shift";
            _leftShift.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftShift);

            _z.KeyValue = 90;
            _z.KeyCode = Keys.Z;
            _z.KeyData = Keys.Z;
            _z.Name = "Z";
            _z.Size = _squareSize;
            _z.Text = "Z";
            _z.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_z);

            _x.KeyValue = 88;
            _x.KeyCode = Keys.X;
            _x.KeyData = Keys.X;
            _x.Name = "X";
            _x.Size = _squareSize;
            _x.Text = "X";
            _x.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_x);

            _c.KeyValue = 67;
            _c.KeyCode = Keys.C;
            _c.KeyData = Keys.C;
            _c.Name = "C";
            _c.Size = _squareSize;
            _c.Text = "C";
            _c.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_c);

            _v.KeyValue = 86;
            _v.KeyCode = Keys.V;
            _v.KeyData = Keys.V;
            _v.Name = "V";
            _v.Size = _squareSize;
            _v.Text = "V";
            _v.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_v);

            _b.KeyValue = 66;
            _b.KeyCode = Keys.B;
            _b.KeyData = Keys.B;
            _b.Name = "B";
            _b.Size = _squareSize;
            _b.Text = "B";
            _b.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_b);

            _n.KeyValue = 78;
            _n.KeyCode = Keys.N;
            _n.KeyData = Keys.N;
            _n.Name = "N";
            _n.Size = _squareSize;
            _n.Text = "N";
            _n.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_n);

            _m.KeyValue = 77;
            _m.KeyCode = Keys.M;
            _m.KeyData = Keys.M;
            _m.Name = "M";
            _m.Size = _squareSize;
            _m.Text = "M";
            _m.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_m);

            _oemComma.KeyValue = 188;
            _oemComma.KeyCode = Keys.Oemcomma;
            _oemComma.KeyData = Keys.Oemcomma;
            _oemComma.Name = "Oemcomma";
            _oemComma.Size = _squareSize;
            _oemComma.Text = ",";
            _oemComma.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemComma);

            _oemPeriod.KeyValue = 190;
            _oemPeriod.KeyCode = Keys.OemPeriod;
            _oemPeriod.KeyData = Keys.OemPeriod;
            _oemPeriod.Name = "OemPeriod";
            _oemPeriod.Size = _squareSize;
            _oemPeriod.Text = ".";
            _oemPeriod.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemPeriod);

            _oemMinus.KeyValue = 189;
            _oemMinus.KeyCode = Keys.OemMinus;
            _oemMinus.KeyData = Keys.OemMinus;
            _oemMinus.Name = "OemMinua";
            _oemMinus.Size = _squareSize;
            _oemMinus.Text = "-";
            _oemMinus.TextAlign = ContentAlignment.BottomLeft;
            keys.Add(_oemMinus);

            _rightShift.KeyValue = 161;
            _rightShift.KeyCode = Keys.ShiftKey;
            _rightShift.KeyData = Keys.ShiftKey | Keys.Shift;
            _rightShift.Name = "RightShift";
            _rightShift.Size = _rectangleSize2;
            _rightShift.Text = "↑ Shift";
            _rightShift.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_rightShift);

            _end.KeyValue = 35;
            _end.KeyCode = Keys.End;
            _end.KeyData = Keys.End;
            _end.Name = "End";
            _end.Size = _rectangleSize0_9;
            _end.Text = "End";
            _end.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_end);

            _leftControl.KeyValue = 162;
            _leftControl.KeyCode = Keys.ControlKey;
            _leftControl.KeyData = Keys.ControlKey | Keys.Control;
            _leftControl.Name = "LeftControl";
            _leftControl.Size = _squareSize;
            _leftControl.Text = "Ctrl";
            _leftControl.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftControl);

            // No KeyValue for Fn button since it doesn't trigger any key event.
            // Fn only alters the values of other keys when they are pressed.
            _fn.Name = "Fn";
            _fn.Size = _squareSize;
            _fn.Text = "Fn";
            _fn.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_fn);

            _leftWindows.KeyValue = 91;
            _leftWindows.KeyCode = Keys.LWin;
            _leftWindows.KeyData = Keys.LWin;
            _leftWindows.Name = "LeftWindows";
            _leftWindows.Size = _squareSize;
            _leftWindows.Text = "⊞";
            _leftWindows.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_leftWindows);

            _alt.KeyValue = 164;
            _alt.KeyCode = Keys.Menu;
            _alt.KeyData = Keys.Menu | Keys.Alt;
            _alt.Name = "Alt";
            _alt.Size = _squareSize;
            _alt.Text = "Alt";
            _alt.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_alt);

            _oemBackslash.KeyValue = 226;
            _oemBackslash.KeyCode = Keys.OemBackslash;
            _oemBackslash.KeyData = Keys.OemBackslash;
            _oemBackslash.Name = "OemBackslash";
            _oemBackslash.Size = _squareSize;
            _oemBackslash.Text = ">\n<";
            _oemBackslash.TextAlign = ContentAlignment.TopLeft;
            keys.Add(_oemBackslash);

            _space.KeyValue = 32;
            _space.KeyCode = Keys.Space;
            _space.KeyData = Keys.Space;
            _space.Name = "Space";
            _space.Size = _spaceBarSize;
            _space.Text = string.Empty;
            keys.Add(_space);

            _altGr.KeyValue = 165;
            _altGr.KeyCode = Keys.Menu;
            _altGr.KeyData = Keys.Menu | Keys.Control | Keys.Alt;
            _altGr.Name = "AltGr";
            _altGr.Size = _squareSize;
            _altGr.Text = "Alt Gr";
            _altGr.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_altGr);

            _apps.KeyValue = 93;
            _apps.KeyCode = Keys.Apps;
            _apps.KeyData = Keys.Apps;
            _apps.Name = "Apps";
            _apps.Size = _squareSize;
            _apps.Text = "≣";
            _apps.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_apps);

            _insert.KeyValue = 45;
            _insert.KeyCode = Keys.Insert;
            _insert.KeyData = Keys.Insert;
            _insert.Name = "Insert";
            _insert.Size = _squareSize;
            _insert.Text = "Ins";
            _insert.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_insert);

            _delete.KeyValue = 46;
            _delete.KeyCode = Keys.Delete;
            _delete.KeyData = Keys.Delete;
            _delete.Name = "Delete";
            _delete.Size = _squareSize;
            _delete.Text = "Del";
            _delete.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_delete);

            _up.KeyValue = 38;
            _up.KeyCode = Keys.Up;
            _up.KeyData = Keys.Up;
            _up.Name = "Up";
            _up.Size = _squareSize0_8;
            _up.Text = "↑";
            _up.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_up);

            _left.KeyValue = 37;
            _left.KeyCode = Keys.Left;
            _left.KeyData = Keys.Left;
            _left.Name = "Left";
            _left.Size = _squareSize0_8;
            _left.Text = "←";
            _left.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_left);

            _down.KeyValue = 40;
            _down.KeyCode = Keys.Down;
            _down.KeyData = Keys.Down;
            _down.Name = "Down";
            _down.Size = _squareSize0_8;
            _down.Text = "↓";
            _down.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_down);

            _right.KeyValue = 39;
            _right.KeyCode = Keys.Right;
            _right.KeyData = Keys.Right;
            _right.Name = "Right";
            _right.Size = _squareSize0_8;
            _right.Text = "→";
            _right.TextAlign = ContentAlignment.MiddleCenter;
            keys.Add(_right);

            return keys;
        }

        private void DoLayout(List<Key> keys, int startingYCoordinate)
        {
            var xCoordinate = BaseLength;
            var yCoordinate = startingYCoordinate;

            foreach (var key in keys)
            {
                key.Location = new Point(xCoordinate, yCoordinate);
                xCoordinate += key.Width + _offset;

                if (key.Name == "Escape")
                {
                    xCoordinate += Convert.ToInt32(key.Width * 0.35);
                }
                else if (key.Name == "Delete")
                {
                    xCoordinate += _squareSize0_8.Width + _offset;
                }

                if (key.Name == "Pause" || key.Name == "Home" || key.Name == "PageUp" || key.Name == "PageDown" || key.Name == "End")
                {
                    xCoordinate = BaseLength;
                    yCoordinate += key.Height + _offset;
                }
                else if (key.Name == "Up")
                {
                    xCoordinate -= (key.Width * 2) + (_offset * 2);
                    yCoordinate += key.Height + _offset;
                }
            }
        }
    }
}
