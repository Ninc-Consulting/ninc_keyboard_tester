namespace KeyboardTester.Util
{
    public static class KeyResource
    {
        private static readonly List<Key> _keys = new();
        public static Key Back { get; private set; }
        public static Key Tab { get; private set; }
        public static Key Clear { get; private set; }
        public static Key Return { get; private set; }
        public static Key Enter { get; private set; }
        public static Key Shift { get; private set; }
        public static Key Control { get; private set; }
        public static Key Alt { get; private set; }
        public static Key Pause { get; private set; }
        public static Key CapsLock { get; private set; }
        public static Key KanaMode { get; private set; }
        public static Key HangulMode { get; private set; }
        public static Key HanguelMode { get; private set; }
        public static Key JunjaMode { get; private set; }
        public static Key FinalMode { get; private set; }
        public static Key HanjaMode { get; private set; }
        public static Key KanjiMode { get; private set; }
        public static Key Escape { get; private set; }
        public static Key ImeConvert { get; private set; }
        public static Key ImeNonConvert { get; private set; }
        public static Key ImeAccept { get; private set; }
        public static Key ImeModeChange { get; private set; }
        public static Key Spacebar { get; private set; }
        public static Key PageUp { get; private set; }
        public static Key PageDown { get; private set; }
        public static Key End { get; private set; }
        public static Key Home { get; private set; }
        public static Key LeftArrow { get; private set; }
        public static Key UpArrow { get; private set; }
        public static Key RightArrow { get; private set; }
        public static Key DownArrow { get; private set; }
        public static Key Select { get; private set; }
        public static Key Print { get; private set; }
        public static Key Execute { get; private set; }
        public static Key PrintScreen { get; private set; }
        public static Key Insert { get; private set; }
        public static Key Delete { get; private set; }
        public static Key Help { get; private set; }
        public static Key D0 { get; private set; }
        public static Key D1 { get; private set; }
        public static Key D2 { get; private set; }
        public static Key D3 { get; private set; }
        public static Key D4 { get; private set; }
        public static Key D5 { get; private set; }
        public static Key D6 { get; private set; }
        public static Key D7 { get; private set; }
        public static Key D8 { get; private set; }
        public static Key D9 { get; private set; }
        public static Key A { get; private set; }
        public static Key B { get; private set; }
        public static Key C { get; private set; }
        public static Key D { get; private set; }
        public static Key E { get; private set; }
        public static Key F { get; private set; }
        public static Key G { get; private set; }
        public static Key H { get; private set; }
        public static Key I { get; private set; }
        public static Key J { get; private set; }
        public static Key K { get; private set; }
        public static Key L { get; private set; }
        public static Key M { get; private set; }
        public static Key N { get; private set; }
        public static Key O { get; private set; }
        public static Key P { get; private set; }
        public static Key Q { get; private set; }
        public static Key R { get; private set; }
        public static Key S { get; private set; }
        public static Key T { get; private set; }
        public static Key U { get; private set; }
        public static Key V { get; private set; }
        public static Key W { get; private set; }
        public static Key X { get; private set; }
        public static Key Y { get; private set; }
        public static Key Z { get; private set; }
        public static Key LeftWindows { get; private set; }
        public static Key RightWindows { get; private set; }
        public static Key Applications { get; private set; }
        public static Key Sleep { get; private set; }
        public static Key NumPad0 { get; private set; }
        public static Key NumPad1 { get; private set; }
        public static Key NumPad2 { get; private set; }
        public static Key NumPad3 { get; private set; }
        public static Key NumPad4 { get; private set; }
        public static Key NumPad5 { get; private set; }
        public static Key NumPad6 { get; private set; }
        public static Key NumPad7 { get; private set; }
        public static Key NumPad8 { get; private set; }
        public static Key NumPad9 { get; private set; }
        public static Key Multiply { get; private set; }
        public static Key Add { get; private set; }
        public static Key Separator { get; private set; }
        public static Key Subtract { get; private set; }
        public static Key Decimal { get; private set; }
        public static Key Divide { get; private set; }
        public static Key F1 { get; private set; }
        public static Key F2 { get; private set; }
        public static Key F3 { get; private set; }
        public static Key F4 { get; private set; }
        public static Key F5 { get; private set; }
        public static Key F6 { get; private set; }
        public static Key F7 { get; private set; }
        public static Key F8 { get; private set; }
        public static Key F9 { get; private set; }
        public static Key F10 { get; private set; }
        public static Key F11 { get; private set; }
        public static Key F12 { get; private set; }
        public static Key F13 { get; private set; }
        public static Key F14 { get; private set; }
        public static Key F15 { get; private set; }
        public static Key F16 { get; private set; }
        public static Key F17 { get; private set; }
        public static Key F18 { get; private set; }
        public static Key F19 { get; private set; }
        public static Key F20 { get; private set; }
        public static Key F21 { get; private set; }
        public static Key F22 { get; private set; }
        public static Key F23 { get; private set; }
        public static Key F24 { get; private set; }
        public static Key NumLock { get; private set; }
        public static Key ScrollLock { get; private set; }
        public static Key LeftShift { get; private set; }
        public static Key RightShift { get; private set; }
        public static Key LeftControl { get; private set; }
        public static Key RightControl { get; private set; }
        public static Key LeftAlt { get; private set; }
        public static Key RightAlt { get; private set; }
        public static Key BrowserBack { get; private set; }
        public static Key BrowserForward { get; private set; }
        public static Key BrowserRefresh { get; private set; }
        public static Key BrowserStop { get; private set; }
        public static Key BrowserSearch { get; private set; }
        public static Key BrowserFavorites { get; private set; }
        public static Key BrowserHome { get; private set; }
        public static Key VolumeMute { get; private set; }
        public static Key VolumeDown { get; private set; }
        public static Key VolumeUp { get; private set; }
        public static Key MediaNextTrack { get; private set; }
        public static Key MediaPreviousTrack { get; private set; }
        public static Key MediaStop { get; private set; }
        public static Key MediaPlayPause { get; private set; }
        public static Key LaunchMail { get; private set; }
        public static Key SelectMedia { get; private set; }
        public static Key LaunchApplication1 { get; private set; }
        public static Key LaunchApplication2 { get; private set; }
        public static Key Oem1 { get; private set; }
        public static Key OemPlus { get; private set; }
        public static Key OemComma { get; private set; }
        public static Key OemMinus { get; private set; }
        public static Key OemPeriod { get; private set; }
        public static Key Oem2 { get; private set; }
        public static Key OemTilde { get; private set; }
        public static Key Oem4 { get; private set; }
        public static Key Oem5 { get; private set; }
        public static Key Oem6 { get; private set; }
        public static Key Oem7 { get; private set; }
        public static Key Oem8 { get; private set; }
        public static Key Oem102 { get; private set; }
        public static Key ProcessKey { get; private set; }
        public static Key Packet { get; private set; }
        public static Key Attn { get; private set; }
        public static Key Crsel { get; private set; }
        public static Key Exsel { get; private set; }
        public static Key EraseEof { get; private set; }
        public static Key Play { get; private set; }
        public static Key Zoom { get; private set; }
        public static Key Pa1 { get; private set; }
        public static Key OemClear { get; private set; }

        static KeyResource()
        {
            Back = new Key()
            {
                KeyCodeValue = (int)Keys.Back,
                KeyCode = Keys.Back,
                Name = Keys.Back.ToString()
            };
            _keys.Add(Back);

            Tab = new Key()
            {
                KeyCodeValue = (int)Keys.Tab,
                KeyCode = Keys.Tab,
                Name = Keys.Tab.ToString()
            };
            _keys.Add(Tab);

            Clear = new Key()
            {
                KeyCodeValue = (int)Keys.Clear,
                KeyCode = Keys.Clear,
                Name = Keys.Clear.ToString()
            };
            _keys.Add(Clear);

            Return = new Key()
            {
                KeyCodeValue = (int)Keys.Return,
                KeyCode = Keys.Return,
                Name = Keys.Return.ToString()
            };
            _keys.Add(Return);

            Enter = new Key()
            {
                KeyCodeValue = -(int)Keys.Enter,    // Inverting the KeyCodeValue to distinguish between Return and Enter since they both have the same values in the Keys enumerator
                KeyCode = Keys.Enter,
                Name = Keys.Enter.ToString()
            };
            _keys.Add(Enter);

            Shift = new Key()
            {
                KeyCodeValue = (int)Keys.ShiftKey,
                KeyCode = Keys.ShiftKey,
                Name = Keys.ShiftKey.ToString()
            };
            _keys.Add(Shift);

            Control = new Key()
            {
                KeyCodeValue = (int)Keys.ControlKey,
                KeyCode = Keys.ControlKey,
                Name = Keys.ControlKey.ToString()
            };
            _keys.Add(Control);

            Alt = new Key()
            {
                KeyCodeValue = (int)Keys.Alt,
                KeyCode = Keys.Alt,
                Name = Keys.Alt.ToString()
            };
            _keys.Add(Alt);

            Pause = new Key()
            {
                KeyCodeValue = (int)Keys.Pause,
                KeyCode = Keys.Pause,
                Name = Keys.Pause.ToString()
            };
            _keys.Add(Pause);

            CapsLock = new Key()
            {
                KeyCodeValue = (int)Keys.CapsLock,
                KeyCode = Keys.CapsLock,
                Name = Keys.CapsLock.ToString()
            };
            _keys.Add(CapsLock);

            KanaMode = new Key()
            {
                KeyCodeValue = (int)Keys.KanaMode,
                KeyCode = Keys.KanaMode,
                Name = Keys.KanaMode.ToString()
            };
            _keys.Add(KanaMode);

            HangulMode = new Key()
            {
                KeyCodeValue = (int)Keys.HangulMode,
                KeyCode = Keys.HangulMode,
                Name = Keys.HangulMode.ToString()
            };
            _keys.Add(HangulMode);

            HanguelMode = new Key()
            {
                KeyCodeValue = (int)Keys.HanguelMode,
                KeyCode = Keys.HanguelMode,
                Name = Keys.HanguelMode.ToString()
            };
            _keys.Add(HanguelMode);

            JunjaMode = new Key()
            {
                KeyCodeValue = (int)Keys.JunjaMode,
                KeyCode = Keys.JunjaMode,
                Name = Keys.JunjaMode.ToString()
            };
            _keys.Add(JunjaMode);

            FinalMode = new Key()
            {
                KeyCodeValue = (int)Keys.FinalMode,
                KeyCode = Keys.FinalMode,
                Name = Keys.FinalMode.ToString()
            };
            _keys.Add(FinalMode);

            HanjaMode = new Key()
            {
                KeyCodeValue = (int)Keys.HanjaMode,
                KeyCode = Keys.HanjaMode,
                Name = Keys.HanjaMode.ToString()
            };
            _keys.Add(HanjaMode);

            KanjiMode = new Key()
            {
                KeyCodeValue = (int)Keys.KanjiMode,
                KeyCode = Keys.KanjiMode,
                Name = Keys.KanjiMode.ToString()
            };
            _keys.Add(KanjiMode);

            Escape = new Key()
            {
                KeyCodeValue = (int)Keys.Escape,
                KeyCode = Keys.Escape,
                Name = Keys.Escape.ToString()
            };
            _keys.Add(Escape);

            ImeConvert = new Key()
            {
                KeyCodeValue = (int)Keys.IMEConvert,
                KeyCode = Keys.IMEConvert,
                Name = Keys.IMEConvert.ToString()
            };
            _keys.Add(ImeConvert);

            ImeNonConvert = new Key()
            {
                KeyCodeValue = (int)Keys.IMENonconvert,
                KeyCode = Keys.IMENonconvert,
                Name = Keys.IMENonconvert.ToString()
            };
            _keys.Add(ImeNonConvert);

            ImeAccept = new Key()
            {
                KeyCodeValue = (int)Keys.IMEAccept,
                KeyCode = Keys.IMEAccept,
                Name = Keys.IMEAccept.ToString()
            };
            _keys.Add(ImeAccept);

            ImeModeChange = new Key()
            {
                KeyCodeValue = (int)Keys.IMEModeChange,
                KeyCode = Keys.IMEModeChange,
                Name = Keys.IMEModeChange.ToString()
            };
            _keys.Add(ImeModeChange);

            Spacebar = new Key()
            {
                KeyCodeValue = (int)Keys.Space,
                KeyCode = Keys.Space,
                Name = Keys.Space.ToString()
            };
            _keys.Add(Spacebar);

            PageUp = new Key()
            {
                KeyCodeValue = (int)Keys.PageUp,
                KeyCode = Keys.PageUp,
                Name = Keys.PageUp.ToString()
            };
            _keys.Add(PageUp);

            PageDown = new Key()
            {
                KeyCodeValue = (int)Keys.PageDown,
                KeyCode = Keys.PageDown,
                Name = Keys.PageDown.ToString()
            };
            _keys.Add(PageDown);

            End = new Key()
            {
                KeyCodeValue = (int)Keys.End,
                KeyCode = Keys.End,
                Name = Keys.End.ToString()
            };
            _keys.Add(End);

            Home = new Key()
            {
                KeyCodeValue = (int)Keys.Home,
                KeyCode = Keys.Home,
                Name = Keys.Home.ToString()
            };
            _keys.Add(Home);

            LeftArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Left,
                KeyCode = Keys.Left,
                Name = Keys.Left.ToString()
            };
            _keys.Add(LeftArrow);

            UpArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Up,
                KeyCode = Keys.Up,
                Name = Keys.Up.ToString()
            };
            _keys.Add(UpArrow);

            RightArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Right,
                KeyCode = Keys.Right,
                Name = Keys.Right.ToString()
            };
            _keys.Add(RightArrow);

            DownArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Down,
                KeyCode = Keys.Down,
                Name = Keys.Down.ToString()
            };
            _keys.Add(DownArrow);

            Select = new Key()
            {
                KeyCodeValue = (int)Keys.Select,
                KeyCode = Keys.Select,
                Name = Keys.Select.ToString()
            };
            _keys.Add(Select);

            Print = new Key()
            {
                KeyCodeValue = (int)Keys.Print,
                KeyCode = Keys.Print,
                Name = Keys.Print.ToString()
            };
            _keys.Add(Print);

            Execute = new Key()
            {
                KeyCodeValue = (int)Keys.Execute,
                KeyCode = Keys.Execute,
                Name = Keys.Execute.ToString()
            };
            _keys.Add(Execute);

            PrintScreen = new Key()
            {
                KeyCodeValue = (int)Keys.PrintScreen,
                KeyCode = Keys.PrintScreen,
                Name = Keys.PrintScreen.ToString()
            };
            _keys.Add(PrintScreen);

            Insert = new Key()
            {
                KeyCodeValue = (int)Keys.Insert,
                KeyCode = Keys.Insert,
                Name = Keys.Insert.ToString()
            };
            _keys.Add(Insert);

            Delete = new Key()
            {
                KeyCodeValue = (int)Keys.Delete,
                KeyCode = Keys.Delete,
                Name = Keys.Delete.ToString()
            };
            _keys.Add(Delete);

            Help = new Key()
            {
                KeyCodeValue = (int)Keys.Help,
                KeyCode = Keys.Help,
                Name = Keys.Help.ToString()
            };
            _keys.Add(Help);

            D0 = new Key()
            {
                KeyCodeValue = (int)Keys.D0,
                KeyCode = Keys.D0,
                Name = Keys.D0.ToString()
            };
            _keys.Add(D0);

            D1 = new Key()
            {
                KeyCodeValue = (int)Keys.D1,
                KeyCode = Keys.D1,
                Name = Keys.D1.ToString()
            };
            _keys.Add(D1);

            D2 = new Key()
            {
                KeyCodeValue = (int)Keys.D2,
                KeyCode = Keys.D2,
                Name = Keys.D2.ToString()
            };
            _keys.Add(D2);

            D3 = new Key()
            {
                KeyCodeValue = (int)Keys.D3,
                KeyCode = Keys.D3,
                Name = Keys.D3.ToString()
            };
            _keys.Add(D3);

            D4 = new Key()
            {
                KeyCodeValue = (int)Keys.D4,
                KeyCode = Keys.D4,
                Name = Keys.D4.ToString()
            };
            _keys.Add(D4);

            D5 = new Key()
            {
                KeyCodeValue = (int)Keys.D5,
                KeyCode = Keys.D5,
                Name = Keys.D5.ToString()
            };
            _keys.Add(D5);

            D6 = new Key()
            {
                KeyCodeValue = (int)Keys.D6,
                KeyCode = Keys.D6,
                Name = Keys.D6.ToString()
            };
            _keys.Add(D6);

            D7 = new Key()
            {
                KeyCodeValue = (int)Keys.D7,
                KeyCode = Keys.D7,
                Name = Keys.D7.ToString()
            };
            _keys.Add(D7);

            D8 = new Key()
            {
                KeyCodeValue = (int)Keys.D8,
                KeyCode = Keys.D8,
                Name = Keys.D8.ToString()
            };
            _keys.Add(D8);

            D9 = new Key()
            {
                KeyCodeValue = (int)Keys.D9,
                KeyCode = Keys.D9,
                Name = Keys.D9.ToString()
            };
            _keys.Add(D9);

            A = new Key()
            {
                KeyCodeValue = (int)Keys.A,
                KeyCode = Keys.A,
                Name = Keys.A.ToString()
            };
            _keys.Add(A);

            B = new Key()
            {
                KeyCodeValue = (int)Keys.B,
                KeyCode = Keys.B,
                Name = Keys.B.ToString()
            };
            _keys.Add(B);

            C = new Key()
            {
                KeyCodeValue = (int)Keys.C,
                KeyCode = Keys.C,
                Name = Keys.C.ToString()
            };
            _keys.Add(C);

            D = new Key()
            {
                KeyCodeValue = (int)Keys.D,
                KeyCode = Keys.D,
                Name = Keys.D.ToString()
            };
            _keys.Add(D);

            E = new Key()
            {
                KeyCodeValue = (int)Keys.E,
                KeyCode = Keys.E,
                Name = Keys.E.ToString()
            };
            _keys.Add(E);

            F = new Key()
            {
                KeyCodeValue = (int)Keys.F,
                KeyCode = Keys.F,
                Name = Keys.F.ToString()
            };
            _keys.Add(F);

            G = new Key()
            {
                KeyCodeValue = (int)Keys.G,
                KeyCode = Keys.G,
                Name = Keys.G.ToString()
            };
            _keys.Add(G);

            H = new Key()
            {
                KeyCodeValue = (int)Keys.H,
                KeyCode = Keys.H,
                Name = Keys.H.ToString()
            };
            _keys.Add(H);

            I = new Key()
            {
                KeyCodeValue = (int)Keys.I,
                KeyCode = Keys.I,
                Name = Keys.I.ToString()
            };
            _keys.Add(I);

            J = new Key()
            {
                KeyCodeValue = (int)Keys.J,
                KeyCode = Keys.J,
                Name = Keys.J.ToString()
            };
            _keys.Add(J);

            K = new Key()
            {
                KeyCodeValue = (int)Keys.K,
                KeyCode = Keys.K,
                Name = Keys.K.ToString()
            };
            _keys.Add(K);

            L = new Key()
            {
                KeyCodeValue = (int)Keys.L,
                KeyCode = Keys.L,
                Name = Keys.L.ToString()
            };
            _keys.Add(L);

            M = new Key()
            {
                KeyCodeValue = (int)Keys.M,
                KeyCode = Keys.M,
                Name = Keys.M.ToString()
            };
            _keys.Add(M);

            N = new Key()
            {
                KeyCodeValue = (int)Keys.N,
                KeyCode = Keys.N,
                Name = Keys.N.ToString()
            };
            _keys.Add(N);

            O = new Key()
            {
                KeyCodeValue = (int)Keys.O,
                KeyCode = Keys.O,
                Name = Keys.O.ToString()
            };
            _keys.Add(O);

            P = new Key()
            {
                KeyCodeValue = (int)Keys.P,
                KeyCode = Keys.P,
                Name = Keys.P.ToString()
            };
            _keys.Add(P);

            Q = new Key()
            {
                KeyCodeValue = (int)Keys.Q,
                KeyCode = Keys.Q,
                Name = Keys.Q.ToString()
            };
            _keys.Add(Q);

            R = new Key()
            {
                KeyCodeValue = (int)Keys.R,
                KeyCode = Keys.R,
                Name = Keys.R.ToString()
            };
            _keys.Add(R);

            S = new Key()
            {
                KeyCodeValue = (int)Keys.S,
                KeyCode = Keys.S,
                Name = Keys.S.ToString()
            };
            _keys.Add(S);

            T = new Key()
            {
                KeyCodeValue = (int)Keys.T,
                KeyCode = Keys.T,
                Name = Keys.T.ToString()
            };
            _keys.Add(T);

            U = new Key()
            {
                KeyCodeValue = (int)Keys.U,
                KeyCode = Keys.U,
                Name = Keys.U.ToString()
            };
            _keys.Add(U);

            V = new Key()
            {
                KeyCodeValue = (int)Keys.V,
                KeyCode = Keys.V,
                Name = Keys.V.ToString()
            };
            _keys.Add(V);

            W = new Key()
            {
                KeyCodeValue = (int)Keys.W,
                KeyCode = Keys.W,
                Name = Keys.W.ToString()
            };
            _keys.Add(W);

            X = new Key()
            {
                KeyCodeValue = (int)Keys.X,
                KeyCode = Keys.X,
                Name = Keys.X.ToString()
            };
            _keys.Add(X);

            Y = new Key()
            {
                KeyCodeValue = (int)Keys.Y,
                KeyCode = Keys.Y,
                Name = Keys.Y.ToString()
            };
            _keys.Add(Y);

            Z = new Key()
            {
                KeyCodeValue = (int)Keys.Z,
                KeyCode = Keys.Z,
                Name = Keys.Z.ToString()
            };
            _keys.Add(Z);

            LeftWindows = new Key()
            {
                KeyCodeValue = (int)Keys.LWin,
                KeyCode = Keys.LWin,
                Name = Keys.LWin.ToString()
            };
            _keys.Add(LeftWindows);

            RightWindows = new Key()
            {
                KeyCodeValue = (int)Keys.RWin,
                KeyCode = Keys.RWin,
                Name = Keys.RWin.ToString()
            };
            _keys.Add(RightWindows);

            Applications = new Key()
            {
                KeyCodeValue = (int)Keys.Apps,
                KeyCode = Keys.Apps,
                Name = Keys.Apps.ToString()
            };
            _keys.Add(Applications);

            Sleep = new Key()
            {
                KeyCodeValue = (int)Keys.Sleep,
                KeyCode = Keys.Sleep,
                Name = Keys.Sleep.ToString()
            };
            _keys.Add(Sleep);

            NumPad0 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad0,
                KeyCode = Keys.NumPad0,
                Name = Keys.NumPad0.ToString()
            };
            _keys.Add(NumPad0);

            NumPad1 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad1,
                KeyCode = Keys.NumPad1,
                Name = Keys.NumPad1.ToString()
            };
            _keys.Add(NumPad1);

            NumPad2 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad2,
                KeyCode = Keys.NumPad2,
                Name = Keys.NumPad2.ToString()
            };
            _keys.Add(NumPad2);

            NumPad3 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad3,
                KeyCode = Keys.NumPad3,
                Name = Keys.NumPad3.ToString()
            };
            _keys.Add(NumPad3);

            NumPad4 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad4,
                KeyCode = Keys.NumPad4,
                Name = Keys.NumPad4.ToString()
            };
            _keys.Add(NumPad4);

            NumPad5 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad5,
                KeyCode = Keys.NumPad5,
                Name = Keys.NumPad5.ToString()
            };
            _keys.Add(NumPad5);

            NumPad6 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad6,
                KeyCode = Keys.NumPad6,
                Name = Keys.NumPad6.ToString()
            };
            _keys.Add(NumPad6);

            NumPad7 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad7,
                KeyCode = Keys.NumPad7,
                Name = Keys.NumPad7.ToString()
            };
            _keys.Add(NumPad7);

            NumPad8 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad8,
                KeyCode = Keys.NumPad8,
                Name = Keys.NumPad8.ToString()
            };
            _keys.Add(NumPad8);

            NumPad9 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad9,
                KeyCode = Keys.NumPad9,
                Name = Keys.NumPad9.ToString()
            };
            _keys.Add(NumPad9);

            Multiply = new Key()
            {
                KeyCodeValue = (int)Keys.Multiply,
                KeyCode = Keys.Multiply,
                Name = Keys.Multiply.ToString()
            };
            _keys.Add(Multiply);

            Add = new Key()
            {
                KeyCodeValue = (int)Keys.Add,
                KeyCode = Keys.Add,
                Name = Keys.Add.ToString()
            };
            _keys.Add(Add);

            Separator = new Key()
            {
                KeyCodeValue = (int)Keys.Separator,
                KeyCode = Keys.Separator,
                Name = Keys.Separator.ToString()
            };
            _keys.Add(Separator);

            Subtract = new Key()
            {
                KeyCodeValue = (int)Keys.Subtract,
                KeyCode = Keys.Subtract,
                Name = Keys.Subtract.ToString()
            };
            _keys.Add(Subtract);

            Decimal = new Key()
            {
                KeyCodeValue = (int)Keys.Decimal,
                KeyCode = Keys.Decimal,
                Name = Keys.Decimal.ToString()
            };
            _keys.Add(Decimal);

            Divide = new Key()
            {
                KeyCodeValue = (int)Keys.Divide,
                KeyCode = Keys.Divide,
                Name = Keys.Divide.ToString()
            };
            _keys.Add(Divide);

            F1 = new Key()
            {
                KeyCodeValue = (int)Keys.F1,
                KeyCode = Keys.F1,
                Name = Keys.F1.ToString()
            };
            _keys.Add(F1);

            F2 = new Key()
            {
                KeyCodeValue = (int)Keys.F2,
                KeyCode = Keys.F2,
                Name = Keys.F2.ToString()
            };
            _keys.Add(F2);

            F3 = new Key()
            {
                KeyCodeValue = (int)Keys.F3,
                KeyCode = Keys.F3,
                Name = Keys.F3.ToString()
            };
            _keys.Add(F3);

            F4 = new Key()
            {
                KeyCodeValue = (int)Keys.F4,
                KeyCode = Keys.F4,
                Name = Keys.F4.ToString()
            };
            _keys.Add(F4);

            F5 = new Key()
            {
                KeyCodeValue = (int)Keys.F5,
                KeyCode = Keys.F5,
                Name = Keys.F5.ToString()
            };
            _keys.Add(F5);

            F6 = new Key()
            {
                KeyCodeValue = (int)Keys.F6,
                KeyCode = Keys.F6,
                Name = Keys.F6.ToString()
            };
            _keys.Add(F6);

            F7 = new Key()
            {
                KeyCodeValue = (int)Keys.F7,
                KeyCode = Keys.F7,
                Name = Keys.F7.ToString()
            };
            _keys.Add(F7);

            F8 = new Key()
            {
                KeyCodeValue = (int)Keys.F8,
                KeyCode = Keys.F8,
                Name = Keys.F8.ToString()
            };
            _keys.Add(F8);

            F9 = new Key()
            {
                KeyCodeValue = (int)Keys.F9,
                KeyCode = Keys.F9,
                Name = Keys.F9.ToString()
            };
            _keys.Add(F9);

            F10 = new Key()
            {
                KeyCodeValue = (int)Keys.F10,
                KeyCode = Keys.F10,
                Name = Keys.F10.ToString()
            };
            _keys.Add(F10);

            F11 = new Key()
            {
                KeyCodeValue = (int)Keys.F11,
                KeyCode = Keys.F11,
                Name = Keys.F11.ToString()
            };
            _keys.Add(F11);

            F12 = new Key()
            {
                KeyCodeValue = (int)Keys.F12,
                KeyCode = Keys.F12,
                Name = Keys.F12.ToString()
            };
            _keys.Add(F12);

            F13 = new Key()
            {
                KeyCodeValue = (int)Keys.F13,
                KeyCode = Keys.F13,
                Name = Keys.F13.ToString()
            };
            _keys.Add(F13);

            F14 = new Key()
            {
                KeyCodeValue = (int)Keys.F14,
                KeyCode = Keys.F14,
                Name = Keys.F14.ToString()
            };
            _keys.Add(F14);

            F15 = new Key()
            {
                KeyCodeValue = (int)Keys.F15,
                KeyCode = Keys.F15,
                Name = Keys.F15.ToString()
            };
            _keys.Add(F15);

            F16 = new Key()
            {
                KeyCodeValue = (int)Keys.F16,
                KeyCode = Keys.F16,
                Name = Keys.F16.ToString()
            };
            _keys.Add(F16);

            F17 = new Key()
            {
                KeyCodeValue = (int)Keys.F17,
                KeyCode = Keys.F17,
                Name = Keys.F17.ToString()
            };
            _keys.Add(F17);

            F18 = new Key()
            {
                KeyCodeValue = (int)Keys.F18,
                KeyCode = Keys.F18,
                Name = Keys.F18.ToString()
            };
            _keys.Add(F18);

            F19 = new Key()
            {
                KeyCodeValue = (int)Keys.F19,
                KeyCode = Keys.F19,
                Name = Keys.F19.ToString()
            };
            _keys.Add(F19);

            F20 = new Key()
            {
                KeyCodeValue = (int)Keys.F20,
                KeyCode = Keys.F20,
                Name = Keys.F20.ToString()
            };
            _keys.Add(F20);

            F21 = new Key()
            {
                KeyCodeValue = (int)Keys.F21,
                KeyCode = Keys.F21,
                Name = Keys.F21.ToString()
            };
            _keys.Add(F21);

            F22 = new Key()
            {
                KeyCodeValue = (int)Keys.F22,
                KeyCode = Keys.F22,
                Name = Keys.F22.ToString()
            };
            _keys.Add(F22);

            F23 = new Key()
            {
                KeyCodeValue = (int)Keys.F23,
                KeyCode = Keys.F23,
                Name = Keys.F23.ToString()
            };
            _keys.Add(F23);

            F24 = new Key()
            {
                KeyCodeValue = (int)Keys.F24,
                KeyCode = Keys.F24,
                Name = Keys.F24.ToString()
            };
            _keys.Add(F24);

            NumLock = new Key()
            {
                KeyCodeValue = (int)Keys.NumLock,
                KeyCode = Keys.NumLock,
                Name = Keys.NumLock.ToString()
            };
            _keys.Add(NumLock);

            ScrollLock = new Key()
            {
                KeyCodeValue = (int)Keys.Scroll,
                KeyCode = Keys.Scroll,
                Name = Keys.Scroll.ToString()
            };
            _keys.Add(ScrollLock);

            LeftShift = new Key()
            {
                KeyCodeValue = (int)Keys.LShiftKey,
                KeyCode = Keys.LShiftKey,
                Name = Keys.LShiftKey.ToString()
            };
            _keys.Add(LeftShift);

            RightShift = new Key()
            {
                KeyCodeValue = (int)Keys.RShiftKey,
                KeyCode = Keys.RShiftKey,
                Name = Keys.RShiftKey.ToString()
            };
            _keys.Add(RightShift);

            LeftControl = new Key()
            {
                KeyCodeValue = (int)Keys.LControlKey,
                KeyCode = Keys.LControlKey,
                Name = Keys.LControlKey.ToString()
            };
            _keys.Add(LeftControl);

            RightControl = new Key()
            {
                KeyCodeValue = (int)Keys.RControlKey,
                KeyCode = Keys.RControlKey,
                Name = Keys.RControlKey.ToString()
            };
            _keys.Add(RightControl);

            LeftAlt = new Key()
            {
                KeyCodeValue = (int)Keys.LMenu,
                KeyCode = Keys.LMenu,
                Name = Keys.LMenu.ToString()
            };
            _keys.Add(LeftAlt);

            RightAlt = new Key()
            {
                KeyCodeValue = (int)Keys.RMenu,
                KeyCode = Keys.RMenu,
                Name = Keys.RMenu.ToString()
            };
            _keys.Add(RightAlt);

            BrowserBack = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserBack,
                KeyCode = Keys.BrowserBack,
                Name = Keys.BrowserBack.ToString()
            };
            _keys.Add(BrowserBack);

            BrowserForward = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserForward,
                KeyCode = Keys.BrowserForward,
                Name = Keys.BrowserForward.ToString()
            };
            _keys.Add(BrowserForward);

            BrowserRefresh = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserRefresh,
                KeyCode = Keys.BrowserRefresh,
                Name = Keys.BrowserRefresh.ToString()
            };
            _keys.Add(BrowserRefresh);

            BrowserStop = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserStop,
                KeyCode = Keys.BrowserStop,
                Name = Keys.BrowserStop.ToString()
            };
            _keys.Add(BrowserStop);

            BrowserSearch = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserSearch,
                KeyCode = Keys.BrowserSearch,
                Name = Keys.BrowserSearch.ToString()
            };
            _keys.Add(BrowserSearch);

            BrowserFavorites = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserFavorites,
                KeyCode = Keys.BrowserFavorites,
                Name = Keys.BrowserFavorites.ToString()
            };
            _keys.Add(BrowserFavorites);

            BrowserHome = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserHome,
                KeyCode = Keys.BrowserHome,
                Name = Keys.BrowserHome.ToString()
            };
            _keys.Add(BrowserHome);

            VolumeMute = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeMute,
                KeyCode = Keys.VolumeMute,
                Name = Keys.VolumeMute.ToString()
            };
            _keys.Add(VolumeMute);

            VolumeDown = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeDown,
                KeyCode = Keys.VolumeDown,
                Name = Keys.VolumeDown.ToString()
            };
            _keys.Add(VolumeDown);

            VolumeUp = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeUp,
                KeyCode = Keys.VolumeUp,
                Name = Keys.VolumeUp.ToString()
            };
            _keys.Add(VolumeUp);

            MediaNextTrack = new Key()
            {
                KeyCodeValue = (int)Keys.MediaNextTrack,
                KeyCode = Keys.MediaNextTrack,
                Name = Keys.MediaNextTrack.ToString()
            };
            _keys.Add(MediaNextTrack);

            MediaPreviousTrack = new Key()
            {
                KeyCodeValue = (int)Keys.MediaPreviousTrack,
                KeyCode = Keys.MediaPreviousTrack,
                Name = Keys.MediaPreviousTrack.ToString()
            };
            _keys.Add(MediaPreviousTrack);

            MediaStop = new Key()
            {
                KeyCodeValue = (int)Keys.MediaStop,
                KeyCode = Keys.MediaStop,
                Name = Keys.MediaStop.ToString()
            };
            _keys.Add(MediaStop);

            MediaPlayPause = new Key()
            {
                KeyCodeValue = (int)Keys.MediaPlayPause,
                KeyCode = Keys.MediaPlayPause,
                Name = Keys.MediaPlayPause.ToString()
            };
            _keys.Add(MediaPlayPause);

            LaunchMail = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchMail,
                KeyCode = Keys.LaunchMail,
                Name = Keys.LaunchMail.ToString()
            };
            _keys.Add(LaunchMail);

            SelectMedia = new Key()
            {
                KeyCodeValue = (int)Keys.SelectMedia,
                KeyCode = Keys.SelectMedia,
                Name = Keys.SelectMedia.ToString()
            };
            _keys.Add(SelectMedia);

            LaunchApplication1 = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchApplication1,
                KeyCode = Keys.LaunchApplication1,
                Name = Keys.LaunchApplication1.ToString()
            };
            _keys.Add(LaunchApplication1);

            LaunchApplication2 = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchApplication2,
                KeyCode = Keys.LaunchApplication2,
                Name = Keys.LaunchApplication2.ToString()
            };
            _keys.Add(LaunchApplication2);

            Oem1 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem1,
                KeyCode = Keys.Oem1,
                Name = Keys.Oem1.ToString()
            };
            _keys.Add(Oem1);

            OemPlus = new Key()
            {
                KeyCodeValue = (int)Keys.Oemplus,
                KeyCode = Keys.Oemplus,
                Name = Keys.Oemplus.ToString()
            };
            _keys.Add(OemPlus);

            OemComma = new Key()
            {
                KeyCodeValue = (int)Keys.Oemcomma,
                KeyCode = Keys.Oemcomma,
                Name = Keys.Oemcomma.ToString()
            };
            _keys.Add(OemComma);

            OemMinus = new Key()
            {
                KeyCodeValue = (int)Keys.OemMinus,
                KeyCode = Keys.OemMinus,
                Name = Keys.OemMinus.ToString()
            };
            _keys.Add(OemMinus);

            OemPeriod = new Key()
            {
                KeyCodeValue = (int)Keys.OemPeriod,
                KeyCode = Keys.OemPeriod,
                Name = Keys.OemPeriod.ToString()
            };
            _keys.Add(OemPeriod);

            Oem2 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem2,
                KeyCode = Keys.Oem2,
                Name = Keys.Oem2.ToString()
            };
            _keys.Add(Oem2);

            OemTilde = new Key()
            {
                KeyCodeValue = (int)Keys.Oemtilde,
                KeyCode = Keys.Oemtilde,
                Name = Keys.Oemtilde.ToString()
            };
            _keys.Add(OemTilde);

            Oem4 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem4,
                KeyCode = Keys.Oem4,
                Name = Keys.Oem4.ToString()
            };
            _keys.Add(Oem4);

            Oem5 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem5,
                KeyCode = Keys.Oem5,
                Name = Keys.Oem5.ToString()
            };
            _keys.Add(Oem5);

            Oem6 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem6,
                KeyCode = Keys.Oem6,
                Name = Keys.Oem6.ToString()
            };
            _keys.Add(Oem6);

            Oem7 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem7,
                KeyCode = Keys.Oem7,
                Name = Keys.Oem7.ToString()
            };
            _keys.Add(Oem7);

            Oem8 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem8,
                KeyCode = Keys.Oem8,
                Name = Keys.Oem8.ToString()
            };
            _keys.Add(Oem8);

            Oem102 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem102,
                KeyCode = Keys.Oem102,
                Name = Keys.Oem102.ToString()
            };
            _keys.Add(Oem102);

            ProcessKey = new Key()
            {
                KeyCodeValue = (int)Keys.ProcessKey,
                KeyCode = Keys.ProcessKey,
                Name = Keys.ProcessKey.ToString()
            };
            _keys.Add(ProcessKey);

            Packet = new Key()
            {
                KeyCodeValue = (int)Keys.Packet,
                KeyCode = Keys.Packet,
                Name = Keys.Packet.ToString()
            };
            _keys.Add(Packet);

            Attn = new Key()
            {
                KeyCodeValue = (int)Keys.Attn,
                KeyCode = Keys.Attn,
                Name = Keys.Attn.ToString()
            };
            _keys.Add(Attn);

            Crsel = new Key()
            {
                KeyCodeValue = (int)Keys.Crsel,
                KeyCode = Keys.Crsel,
                Name = Keys.Crsel.ToString()
            };
            _keys.Add(Crsel);

            Exsel = new Key()
            {
                KeyCodeValue = (int)Keys.Exsel,
                KeyCode = Keys.Exsel,
                Name = Keys.Exsel.ToString()
            };
            _keys.Add(Exsel);

            EraseEof = new Key()
            {
                KeyCodeValue = (int)Keys.EraseEof,
                KeyCode = Keys.EraseEof,
                Name = Keys.EraseEof.ToString()
            };
            _keys.Add(EraseEof);

            Play = new Key()
            {
                KeyCodeValue = (int)Keys.Play,
                KeyCode = Keys.Play,
                Name = Keys.Play.ToString()
            };
            _keys.Add(Play);

            Zoom = new Key()
            {
                KeyCodeValue = (int)Keys.Zoom,
                KeyCode = Keys.Zoom,
                Name = Keys.Zoom.ToString()
            };
            _keys.Add(Zoom);

            Pa1 = new Key()
            {
                KeyCodeValue = (int)Keys.Pa1,
                KeyCode = Keys.Pa1,
                Name = Keys.Pa1.ToString()
            };
            _keys.Add(Pa1);

            OemClear = new Key()
            {
                KeyCodeValue = (int)Keys.OemClear,
                KeyCode = Keys.OemClear,
                Name = Keys.OemClear.ToString()
            };
            _keys.Add(OemClear);

            SetDefaultTextValues();
        }

        public static void SetDefaultTextValues()
        {
            var regex = new Regex("(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])");
            foreach (var key in _keys)
            {
                key.Text = regex.Replace(key.Name, " ");
            }

            Back.Text = "←";
            Tab.Text = "⭾";
            Enter.Text = "Enter";
            KanaMode.Text = @"Kana/Hangul/Hanguel Mode";
            HangulMode.Text = @"Kana/Hangul/Hanguel Mode";
            HanguelMode.Text = @"Kana/Hangul/Hanguel Mode";
            HanjaMode.Text = @"Hanja/Kanji Mode";
            KanjiMode.Text = @"Hanja/Kanji Mode";
            Escape.Text = "Esc";
            LeftArrow.Text = "←";
            UpArrow.Text = "↑";
            RightArrow.Text = "→";
            DownArrow.Text = "↓";
            D0.Text = "0";
            D1.Text = "1";
            D2.Text = "2";
            D3.Text = "3";
            D4.Text = "4";
            D5.Text = "5";
            D6.Text = "6";
            D7.Text = "7";
            D8.Text = "8";
            D9.Text = "9";
            LeftWindows.Text = "⊞";
            RightWindows.Text = "⊞";
            Applications.Text = "≣";
            NumPad0.Text = "0";
            NumPad1.Text = "1";
            NumPad2.Text = "2";
            NumPad3.Text = "3";
            NumPad4.Text = "4";
            NumPad5.Text = "5";
            NumPad6.Text = "6";
            NumPad7.Text = "7";
            NumPad8.Text = "8";
            NumPad9.Text = "9";
            Multiply.Text = "*";
            Add.Text = "+";
            Subtract.Text = "-";
            Decimal.Text = ",";
            Divide.Text = "/";
            LeftShift.Text = "⇧";
            RightShift.Text = "⇧";
            LeftControl.Text = "Ctrl";
            RightControl.Text = "Ctrl";
            LeftAlt.Text = "Alt";
            RightAlt.Text = "AltGr";
            Oem1.Text = "^";
            OemPlus.Text = "+";
            OemComma.Text = ";\n,";
            OemMinus.Text = "_\n-";
            OemPeriod.Text = ":\n.";
            Oem2.Text = "*";
            OemTilde.Text = "Ö";
            Oem4.Text = @"\";
            Oem5.Text = "§½";
            Oem6.Text = "Å";
            Oem7.Text = "Ä";
            Oem102.Text = ">\n<";
        }
    }
}