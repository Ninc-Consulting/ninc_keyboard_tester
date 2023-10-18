using Forms = System.Windows.Forms;

namespace KeyboardTester.Util
{
    public static class Resources
    {
        public static class Keys
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

            static Keys()
            {
                Back = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Back,
                    KeyCode = Forms.Keys.Back,
                    Name = Forms.Keys.Back.ToString()
                };
                _keys.Add(Back);

                Tab = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Tab,
                    KeyCode = Forms.Keys.Tab,
                    Name = Forms.Keys.Tab.ToString()
                };
                _keys.Add(Tab);

                Clear = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Clear,
                    KeyCode = Forms.Keys.Clear,
                    Name = Forms.Keys.Clear.ToString()
                };
                _keys.Add(Clear);

                Return = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Return,
                    KeyCode = Forms.Keys.Return,
                    Name = Forms.Keys.Return.ToString()
                };
                _keys.Add(Return);

                Enter = new Key()
                {
                    KeyCodeValue = -(int)Forms.Keys.Enter,    // Inverting the KeyCodeValue to distinguish between Return and Enter since they both have the same values in the Keys enumerator
                    KeyCode = Forms.Keys.Enter,
                    Name = Forms.Keys.Enter.ToString()
                };
                _keys.Add(Enter);

                Shift = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.ShiftKey,
                    KeyCode = Forms.Keys.ShiftKey,
                    Name = Forms.Keys.ShiftKey.ToString()
                };
                _keys.Add(Shift);

                Control = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.ControlKey,
                    KeyCode = Forms.Keys.ControlKey,
                    Name = Forms.Keys.ControlKey.ToString()
                };
                _keys.Add(Control);

                Alt = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Alt,
                    KeyCode = Forms.Keys.Alt,
                    Name = Forms.Keys.Alt.ToString()
                };
                _keys.Add(Alt);

                Pause = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Pause,
                    KeyCode = Forms.Keys.Pause,
                    Name = Forms.Keys.Pause.ToString()
                };
                _keys.Add(Pause);

                CapsLock = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.CapsLock,
                    KeyCode = Forms.Keys.CapsLock,
                    Name = Forms.Keys.CapsLock.ToString()
                };
                _keys.Add(CapsLock);

                KanaMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.KanaMode,
                    KeyCode = Forms.Keys.KanaMode,
                    Name = Forms.Keys.KanaMode.ToString()
                };
                _keys.Add(KanaMode);

                HangulMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.HangulMode,
                    KeyCode = Forms.Keys.HangulMode,
                    Name = Forms.Keys.HangulMode.ToString()
                };
                _keys.Add(HangulMode);

                HanguelMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.HanguelMode,
                    KeyCode = Forms.Keys.HanguelMode,
                    Name = Forms.Keys.HanguelMode.ToString()
                };
                _keys.Add(HanguelMode);

                JunjaMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.JunjaMode,
                    KeyCode = Forms.Keys.JunjaMode,
                    Name = Forms.Keys.JunjaMode.ToString()
                };
                _keys.Add(JunjaMode);

                FinalMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.FinalMode,
                    KeyCode = Forms.Keys.FinalMode,
                    Name = Forms.Keys.FinalMode.ToString()
                };
                _keys.Add(FinalMode);

                HanjaMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.HanjaMode,
                    KeyCode = Forms.Keys.HanjaMode,
                    Name = Forms.Keys.HanjaMode.ToString()
                };
                _keys.Add(HanjaMode);

                KanjiMode = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.KanjiMode,
                    KeyCode = Forms.Keys.KanjiMode,
                    Name = Forms.Keys.KanjiMode.ToString()
                };
                _keys.Add(KanjiMode);

                Escape = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Escape,
                    KeyCode = Forms.Keys.Escape,
                    Name = Forms.Keys.Escape.ToString()
                };
                _keys.Add(Escape);

                ImeConvert = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.IMEConvert,
                    KeyCode = Forms.Keys.IMEConvert,
                    Name = Forms.Keys.IMEConvert.ToString()
                };
                _keys.Add(ImeConvert);

                ImeNonConvert = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.IMENonconvert,
                    KeyCode = Forms.Keys.IMENonconvert,
                    Name = Forms.Keys.IMENonconvert.ToString()
                };
                _keys.Add(ImeNonConvert);

                ImeAccept = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.IMEAccept,
                    KeyCode = Forms.Keys.IMEAccept,
                    Name = Forms.Keys.IMEAccept.ToString()
                };
                _keys.Add(ImeAccept);

                ImeModeChange = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.IMEModeChange,
                    KeyCode = Forms.Keys.IMEModeChange,
                    Name = Forms.Keys.IMEModeChange.ToString()
                };
                _keys.Add(ImeModeChange);

                Spacebar = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Space,
                    KeyCode = Forms.Keys.Space,
                    Name = Forms.Keys.Space.ToString()
                };
                _keys.Add(Spacebar);

                PageUp = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.PageUp,
                    KeyCode = Forms.Keys.PageUp,
                    Name = Forms.Keys.PageUp.ToString()
                };
                _keys.Add(PageUp);

                PageDown = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.PageDown,
                    KeyCode = Forms.Keys.PageDown,
                    Name = "Page Down"
                };
                _keys.Add(PageDown);

                End = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.End,
                    KeyCode = Forms.Keys.End,
                    Name = Forms.Keys.End.ToString()
                };
                _keys.Add(End);

                Home = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Home,
                    KeyCode = Forms.Keys.Home,
                    Name = Forms.Keys.Home.ToString()
                };
                _keys.Add(Home);

                LeftArrow = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Left,
                    KeyCode = Forms.Keys.Left,
                    Name = Forms.Keys.Left.ToString()
                };
                _keys.Add(LeftArrow);

                UpArrow = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Up,
                    KeyCode = Forms.Keys.Up,
                    Name = Forms.Keys.Up.ToString()
                };
                _keys.Add(UpArrow);

                RightArrow = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Right,
                    KeyCode = Forms.Keys.Right,
                    Name = Forms.Keys.Right.ToString()
                };
                _keys.Add(RightArrow);

                DownArrow = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Down,
                    KeyCode = Forms.Keys.Down,
                    Name = Forms.Keys.Down.ToString()
                };
                _keys.Add(DownArrow);

                Select = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Select,
                    KeyCode = Forms.Keys.Select,
                    Name = Forms.Keys.Select.ToString()
                };
                _keys.Add(Select);

                Print = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Print,
                    KeyCode = Forms.Keys.Print,
                    Name = Forms.Keys.Print.ToString()
                };
                _keys.Add(Print);

                Execute = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Execute,
                    KeyCode = Forms.Keys.Execute,
                    Name = Forms.Keys.Execute.ToString()
                };
                _keys.Add(Execute);

                PrintScreen = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.PrintScreen,
                    KeyCode = Forms.Keys.PrintScreen,
                    Name = Forms.Keys.PrintScreen.ToString()
                };
                _keys.Add(PrintScreen);

                Insert = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Insert,
                    KeyCode = Forms.Keys.Insert,
                    Name = Forms.Keys.Insert.ToString()
                };
                _keys.Add(Insert);

                Delete = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Delete,
                    KeyCode = Forms.Keys.Delete,
                    Name = Forms.Keys.Delete.ToString()
                };
                _keys.Add(Delete);

                Help = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Help,
                    KeyCode = Forms.Keys.Help,
                    Name = Forms.Keys.Help.ToString()
                };
                _keys.Add(Help);

                D0 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D0,
                    KeyCode = Forms.Keys.D0,
                    Name = Forms.Keys.D0.ToString()
                };
                _keys.Add(D0);

                D1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D1,
                    KeyCode = Forms.Keys.D1,
                    Name = Forms.Keys.D1.ToString()
                };
                _keys.Add(D1);

                D2 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D2,
                    KeyCode = Forms.Keys.D2,
                    Name = Forms.Keys.D2.ToString()
                };
                _keys.Add(D2);

                D3 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D3,
                    KeyCode = Forms.Keys.D3,
                    Name = Forms.Keys.D3.ToString()
                };
                _keys.Add(D3);

                D4 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D4,
                    KeyCode = Forms.Keys.D4,
                    Name = Forms.Keys.D4.ToString()
                };
                _keys.Add(D4);

                D5 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D5,
                    KeyCode = Forms.Keys.D5,
                    Name = Forms.Keys.D5.ToString()
                };
                _keys.Add(D5);

                D6 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D6,
                    KeyCode = Forms.Keys.D6,
                    Name = Forms.Keys.D6.ToString()
                };
                _keys.Add(D6);

                D7 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D7,
                    KeyCode = Forms.Keys.D7,
                    Name = Forms.Keys.D7.ToString()
                };
                _keys.Add(D7);

                D8 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D8,
                    KeyCode = Forms.Keys.D8,
                    Name = Forms.Keys.D8.ToString()
                };
                _keys.Add(D8);

                D9 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D9,
                    KeyCode = Forms.Keys.D9,
                    Name = Forms.Keys.D9.ToString()
                };
                _keys.Add(D9);

                A = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.A,
                    KeyCode = Forms.Keys.A,
                    Name = Forms.Keys.A.ToString()
                };
                _keys.Add(A);

                B = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.B,
                    KeyCode = Forms.Keys.B,
                    Name = Forms.Keys.B.ToString()
                };
                _keys.Add(B);

                C = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.C,
                    KeyCode = Forms.Keys.C,
                    Name = Forms.Keys.C.ToString()
                };
                _keys.Add(C);

                D = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.D,
                    KeyCode = Forms.Keys.D,
                    Name = Forms.Keys.D.ToString()
                };
                _keys.Add(D);

                E = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.E,
                    KeyCode = Forms.Keys.E,
                    Name = Forms.Keys.E.ToString()
                };
                _keys.Add(E);

                F = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F,
                    KeyCode = Forms.Keys.F,
                    Name = Forms.Keys.F.ToString()
                };
                _keys.Add(F);

                G = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.G,
                    KeyCode = Forms.Keys.G,
                    Name = Forms.Keys.G.ToString()
                };
                _keys.Add(G);

                H = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.H,
                    KeyCode = Forms.Keys.H,
                    Name = Forms.Keys.H.ToString()
                };
                _keys.Add(H);

                I = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.I,
                    KeyCode = Forms.Keys.I,
                    Name = Forms.Keys.I.ToString()
                };
                _keys.Add(I);

                J = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.J,
                    KeyCode = Forms.Keys.J,
                    Name = Forms.Keys.J.ToString()
                };
                _keys.Add(J);

                K = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.K,
                    KeyCode = Forms.Keys.K,
                    Name = Forms.Keys.K.ToString()
                };
                _keys.Add(K);

                L = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.L,
                    KeyCode = Forms.Keys.L,
                    Name = Forms.Keys.L.ToString()
                };
                _keys.Add(L);

                M = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.M,
                    KeyCode = Forms.Keys.M,
                    Name = Forms.Keys.M.ToString()
                };
                _keys.Add(M);

                N = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.N,
                    KeyCode = Forms.Keys.N,
                    Name = Forms.Keys.N.ToString()
                };
                _keys.Add(N);

                O = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.O,
                    KeyCode = Forms.Keys.O,
                    Name = Forms.Keys.O.ToString()
                };
                _keys.Add(O);

                P = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.P,
                    KeyCode = Forms.Keys.P,
                    Name = Forms.Keys.P.ToString()
                };
                _keys.Add(P);

                Q = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Q,
                    KeyCode = Forms.Keys.Q,
                    Name = Forms.Keys.Q.ToString()
                };
                _keys.Add(Q);

                R = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.R,
                    KeyCode = Forms.Keys.R,
                    Name = Forms.Keys.R.ToString()
                };
                _keys.Add(R);

                S = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.S,
                    KeyCode = Forms.Keys.S,
                    Name = Forms.Keys.S.ToString()
                };
                _keys.Add(S);

                T = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.T,
                    KeyCode = Forms.Keys.T,
                    Name = Forms.Keys.T.ToString()
                };
                _keys.Add(T);

                U = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.U,
                    KeyCode = Forms.Keys.U,
                    Name = Forms.Keys.U.ToString()
                };
                _keys.Add(U);

                V = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.V,
                    KeyCode = Forms.Keys.V,
                    Name = Forms.Keys.V.ToString()
                };
                _keys.Add(V);

                W = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.W,
                    KeyCode = Forms.Keys.W,
                    Name = Forms.Keys.W.ToString()
                };
                _keys.Add(W);

                X = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.X,
                    KeyCode = Forms.Keys.X,
                    Name = Forms.Keys.X.ToString()
                };
                _keys.Add(X);

                Y = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Y,
                    KeyCode = Forms.Keys.Y,
                    Name = Forms.Keys.Y.ToString()
                };
                _keys.Add(Y);

                Z = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Z,
                    KeyCode = Forms.Keys.Z,
                    Name = Forms.Keys.Z.ToString()
                };
                _keys.Add(Z);

                LeftWindows = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LWin,
                    KeyCode = Forms.Keys.LWin,
                    Name = Forms.Keys.LWin.ToString()
                };
                _keys.Add(LeftWindows);

                RightWindows = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.RWin,
                    KeyCode = Forms.Keys.RWin,
                    Name = Forms.Keys.RWin.ToString()
                };
                _keys.Add(RightWindows);

                Applications = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Apps,
                    KeyCode = Forms.Keys.Apps,
                    Name = Forms.Keys.Apps.ToString()
                };
                _keys.Add(Applications);

                Sleep = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Sleep,
                    KeyCode = Forms.Keys.Sleep,
                    Name = Forms.Keys.Sleep.ToString()
                };
                _keys.Add(Sleep);

                NumPad0 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad0,
                    KeyCode = Forms.Keys.NumPad0,
                    Name = Forms.Keys.NumPad0.ToString()
                };
                _keys.Add(NumPad0);

                NumPad1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad1,
                    KeyCode = Forms.Keys.NumPad1,
                    Name = Forms.Keys.NumPad1.ToString()
                };
                _keys.Add(NumPad1);

                NumPad2 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad2,
                    KeyCode = Forms.Keys.NumPad2,
                    Name = Forms.Keys.NumPad2.ToString()
                };
                _keys.Add(NumPad2);

                NumPad3 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad3,
                    KeyCode = Forms.Keys.NumPad3,
                    Name = Forms.Keys.NumPad3.ToString()
                };
                _keys.Add(NumPad3);

                NumPad4 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad4,
                    KeyCode = Forms.Keys.NumPad4,
                    Name = Forms.Keys.NumPad4.ToString()
                };
                _keys.Add(NumPad4);

                NumPad5 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad5,
                    KeyCode = Forms.Keys.NumPad5,
                    Name = Forms.Keys.NumPad5.ToString()
                };
                _keys.Add(NumPad5);

                NumPad6 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad6,
                    KeyCode = Forms.Keys.NumPad6,
                    Name = Forms.Keys.NumPad6.ToString()
                };
                _keys.Add(NumPad6);

                NumPad7 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad7,
                    KeyCode = Forms.Keys.NumPad7,
                    Name = Forms.Keys.NumPad7.ToString()
                };
                _keys.Add(NumPad7);

                NumPad8 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad8,
                    KeyCode = Forms.Keys.NumPad8,
                    Name = Forms.Keys.NumPad8.ToString()
                };
                _keys.Add(NumPad8);

                NumPad9 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumPad9,
                    KeyCode = Forms.Keys.NumPad9,
                    Name = Forms.Keys.NumPad9.ToString()
                };
                _keys.Add(NumPad9);

                Multiply = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Multiply,
                    KeyCode = Forms.Keys.Multiply,
                    Name = Forms.Keys.Multiply.ToString()
                };
                _keys.Add(Multiply);

                Add = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Add,
                    KeyCode = Forms.Keys.Add,
                    Name = Forms.Keys.Add.ToString()
                };
                _keys.Add(Add);

                Separator = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Separator,
                    KeyCode = Forms.Keys.Separator,
                    Name = Forms.Keys.Separator.ToString()
                };
                _keys.Add(Separator);

                Subtract = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Subtract,
                    KeyCode = Forms.Keys.Subtract,
                    Name = Forms.Keys.Subtract.ToString()
                };
                _keys.Add(Subtract);

                Decimal = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Decimal,
                    KeyCode = Forms.Keys.Decimal,
                    Name = Forms.Keys.Decimal.ToString()
                };
                _keys.Add(Decimal);

                Divide = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Divide,
                    KeyCode = Forms.Keys.Divide,
                    Name = Forms.Keys.Divide.ToString()
                };
                _keys.Add(Divide);

                F1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F1,
                    KeyCode = Forms.Keys.F1,
                    Name = Forms.Keys.F1.ToString()
                };
                _keys.Add(F1);

                F2 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F2,
                    KeyCode = Forms.Keys.F2,
                    Name = Forms.Keys.F2.ToString()
                };
                _keys.Add(F2);

                F3 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F3,
                    KeyCode = Forms.Keys.F3,
                    Name = Forms.Keys.F3.ToString()
                };
                _keys.Add(F3);

                F4 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F4,
                    KeyCode = Forms.Keys.F4,
                    Name = Forms.Keys.F4.ToString()
                };
                _keys.Add(F4);

                F5 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F5,
                    KeyCode = Forms.Keys.F5,
                    Name = Forms.Keys.F5.ToString()
                };
                _keys.Add(F5);

                F6 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F6,
                    KeyCode = Forms.Keys.F6,
                    Name = Forms.Keys.F6.ToString()
                };
                _keys.Add(F6);

                F7 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F7,
                    KeyCode = Forms.Keys.F7,
                    Name = Forms.Keys.F7.ToString()
                };
                _keys.Add(F7);

                F8 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F8,
                    KeyCode = Forms.Keys.F8,
                    Name = Forms.Keys.F8.ToString()
                };
                _keys.Add(F8);

                F9 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F9,
                    KeyCode = Forms.Keys.F9,
                    Name = Forms.Keys.F9.ToString()
                };
                _keys.Add(F9);

                F10 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F10,
                    KeyCode = Forms.Keys.F10,
                    Name = Forms.Keys.F10.ToString()
                };
                _keys.Add(F10);

                F11 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F11,
                    KeyCode = Forms.Keys.F11,
                    Name = Forms.Keys.F11.ToString()
                };
                _keys.Add(F11);

                F12 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F12,
                    KeyCode = Forms.Keys.F12,
                    Name = Forms.Keys.F12.ToString()
                };
                _keys.Add(F12);

                F13 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F13,
                    KeyCode = Forms.Keys.F13,
                    Name = Forms.Keys.F13.ToString()
                };
                _keys.Add(F13);

                F14 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F14,
                    KeyCode = Forms.Keys.F14,
                    Name = Forms.Keys.F14.ToString()
                };
                _keys.Add(F14);

                F15 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F15,
                    KeyCode = Forms.Keys.F15,
                    Name = Forms.Keys.F15.ToString()
                };
                _keys.Add(F15);

                F16 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F16,
                    KeyCode = Forms.Keys.F16,
                    Name = Forms.Keys.F16.ToString()
                };
                _keys.Add(F16);

                F17 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F17,
                    KeyCode = Forms.Keys.F17,
                    Name = Forms.Keys.F17.ToString()
                };
                _keys.Add(F17);

                F18 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F18,
                    KeyCode = Forms.Keys.F18,
                    Name = Forms.Keys.F18.ToString()
                };
                _keys.Add(F18);

                F19 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F19,
                    KeyCode = Forms.Keys.F19,
                    Name = Forms.Keys.F19.ToString()
                };
                _keys.Add(F19);

                F20 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F20,
                    KeyCode = Forms.Keys.F20,
                    Name = Forms.Keys.F20.ToString()
                };
                _keys.Add(F20);

                F21 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F21,
                    KeyCode = Forms.Keys.F21,
                    Name = Forms.Keys.F21.ToString()
                };
                _keys.Add(F21);

                F22 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F22,
                    KeyCode = Forms.Keys.F22,
                    Name = Forms.Keys.F22.ToString()
                };
                _keys.Add(F22);

                F23 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F23,
                    KeyCode = Forms.Keys.F23,
                    Name = Forms.Keys.F23.ToString()
                };
                _keys.Add(F23);

                F24 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.F24,
                    KeyCode = Forms.Keys.F24,
                    Name = Forms.Keys.F24.ToString()
                };
                _keys.Add(F24);

                NumLock = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.NumLock,
                    KeyCode = Forms.Keys.NumLock,
                    Name = Forms.Keys.NumLock.ToString()
                };
                _keys.Add(NumLock);

                ScrollLock = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Scroll,
                    KeyCode = Forms.Keys.Scroll,
                    Name = Forms.Keys.Scroll.ToString()
                };
                _keys.Add(ScrollLock);

                LeftShift = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LShiftKey,
                    KeyCode = Forms.Keys.LShiftKey,
                    Name = Forms.Keys.LShiftKey.ToString()
                };
                _keys.Add(LeftShift);

                RightShift = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.RShiftKey,
                    KeyCode = Forms.Keys.RShiftKey,
                    Name = Forms.Keys.RShiftKey.ToString()
                };
                _keys.Add(RightShift);

                LeftControl = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LControlKey,
                    KeyCode = Forms.Keys.LControlKey,
                    Name = Forms.Keys.LControlKey.ToString()
                };
                _keys.Add(LeftControl);

                RightControl = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.RControlKey,
                    KeyCode = Forms.Keys.RControlKey,
                    Name = Forms.Keys.RControlKey.ToString()
                };
                _keys.Add(RightControl);

                LeftAlt = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LMenu,
                    KeyCode = Forms.Keys.LMenu,
                    Name = Forms.Keys.LMenu.ToString()
                };
                _keys.Add(LeftAlt);

                RightAlt = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.RMenu,
                    KeyCode = Forms.Keys.RMenu,
                    Name = Forms.Keys.RMenu.ToString()
                };
                _keys.Add(RightAlt);

                BrowserBack = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserBack,
                    KeyCode = Forms.Keys.BrowserBack,
                    Name = Forms.Keys.BrowserBack.ToString()
                };
                _keys.Add(BrowserBack);

                BrowserForward = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserForward,
                    KeyCode = Forms.Keys.BrowserForward,
                    Name = Forms.Keys.BrowserForward.ToString()
                };
                _keys.Add(BrowserForward);

                BrowserRefresh = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserRefresh,
                    KeyCode = Forms.Keys.BrowserRefresh,
                    Name = Forms.Keys.BrowserRefresh.ToString()
                };
                _keys.Add(BrowserRefresh);

                BrowserStop = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserStop,
                    KeyCode = Forms.Keys.BrowserStop,
                    Name = Forms.Keys.BrowserStop.ToString()
                };
                _keys.Add(BrowserStop);

                BrowserSearch = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserSearch,
                    KeyCode = Forms.Keys.BrowserSearch,
                    Name = Forms.Keys.BrowserSearch.ToString()
                };
                _keys.Add(BrowserSearch);

                BrowserFavorites = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserFavorites,
                    KeyCode = Forms.Keys.BrowserFavorites,
                    Name = Forms.Keys.BrowserFavorites.ToString()
                };
                _keys.Add(BrowserFavorites);

                BrowserHome = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.BrowserHome,
                    KeyCode = Forms.Keys.BrowserHome,
                    Name = Forms.Keys.BrowserHome.ToString()
                };
                _keys.Add(BrowserHome);

                VolumeMute = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.VolumeMute,
                    KeyCode = Forms.Keys.VolumeMute,
                    Name = Forms.Keys.VolumeMute.ToString()
                };
                _keys.Add(VolumeMute);

                VolumeDown = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.VolumeDown,
                    KeyCode = Forms.Keys.VolumeDown,
                    Name = Forms.Keys.VolumeDown.ToString()
                };
                _keys.Add(VolumeDown);

                VolumeUp = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.VolumeUp,
                    KeyCode = Forms.Keys.VolumeUp,
                    Name = Forms.Keys.VolumeUp.ToString()
                };
                _keys.Add(VolumeUp);

                MediaNextTrack = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.MediaNextTrack,
                    KeyCode = Forms.Keys.MediaNextTrack,
                    Name = Forms.Keys.MediaNextTrack.ToString()
                };
                _keys.Add(MediaNextTrack);

                MediaPreviousTrack = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.MediaPreviousTrack,
                    KeyCode = Forms.Keys.MediaPreviousTrack,
                    Name = Forms.Keys.MediaPreviousTrack.ToString()
                };
                _keys.Add(MediaPreviousTrack);

                MediaStop = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.MediaStop,
                    KeyCode = Forms.Keys.MediaStop,
                    Name = Forms.Keys.MediaStop.ToString()
                };
                _keys.Add(MediaStop);

                MediaPlayPause = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.MediaPlayPause,
                    KeyCode = Forms.Keys.MediaPlayPause,
                    Name = Forms.Keys.MediaPlayPause.ToString()
                };
                _keys.Add(MediaPlayPause);

                LaunchMail = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LaunchMail,
                    KeyCode = Forms.Keys.LaunchMail,
                    Name = Forms.Keys.LaunchMail.ToString()
                };
                _keys.Add(LaunchMail);

                SelectMedia = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.SelectMedia,
                    KeyCode = Forms.Keys.SelectMedia,
                    Name = Forms.Keys.SelectMedia.ToString()
                };
                _keys.Add(SelectMedia);

                LaunchApplication1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LaunchApplication1,
                    KeyCode = Forms.Keys.LaunchApplication1,
                    Name = Forms.Keys.LaunchApplication1.ToString()
                };
                _keys.Add(LaunchApplication1);

                LaunchApplication2 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.LaunchApplication2,
                    KeyCode = Forms.Keys.LaunchApplication2,
                    Name = Forms.Keys.LaunchApplication2.ToString()
                };
                _keys.Add(LaunchApplication2);

                Oem1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem1,
                    KeyCode = Forms.Keys.Oem1,
                    Name = Forms.Keys.Oem1.ToString()
                };
                _keys.Add(Oem1);

                OemPlus = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oemplus,
                    KeyCode = Forms.Keys.Oemplus,
                    Name = Forms.Keys.Oemplus.ToString()
                };
                _keys.Add(OemPlus);

                OemComma = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oemcomma,
                    KeyCode = Forms.Keys.Oemcomma,
                    Name = Forms.Keys.Oemcomma.ToString()
                };
                _keys.Add(OemComma);

                OemMinus = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.OemMinus,
                    KeyCode = Forms.Keys.OemMinus,
                    Name = Forms.Keys.OemMinus.ToString()
                };
                _keys.Add(OemMinus);

                OemPeriod = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.OemPeriod,
                    KeyCode = Forms.Keys.OemPeriod,
                    Name = Forms.Keys.OemPeriod.ToString()
                };
                _keys.Add(OemPeriod);

                Oem2 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem2,
                    KeyCode = Forms.Keys.Oem2,
                    Name = Forms.Keys.Oem2.ToString()
                };
                _keys.Add(Oem2);

                OemTilde = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oemtilde,
                    KeyCode = Forms.Keys.Oemtilde,
                    Name = Forms.Keys.Oemtilde.ToString()
                };
                _keys.Add(OemTilde);

                Oem4 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem4,
                    KeyCode = Forms.Keys.Oem4,
                    Name = Forms.Keys.Oem4.ToString()
                };
                _keys.Add(Oem4);

                Oem5 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem5,
                    KeyCode = Forms.Keys.Oem5,
                    Name = Forms.Keys.Oem5.ToString()
                };
                _keys.Add(Oem5);

                Oem6 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem6,
                    KeyCode = Forms.Keys.Oem6,
                    Name = Forms.Keys.Oem6.ToString()
                };
                _keys.Add(Oem6);

                Oem7 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem7,
                    KeyCode = Forms.Keys.Oem7,
                    Name = Forms.Keys.Oem7.ToString()
                };
                _keys.Add(Oem7);

                Oem8 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem8,
                    KeyCode = Forms.Keys.Oem8,
                    Name = Forms.Keys.Oem8.ToString()
                };
                _keys.Add(Oem8);

                Oem102 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Oem102,
                    KeyCode = Forms.Keys.Oem102,
                    Name = Forms.Keys.Oem102.ToString()
                };
                _keys.Add(Oem102);

                ProcessKey = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.ProcessKey,
                    KeyCode = Forms.Keys.ProcessKey,
                    Name = Forms.Keys.ProcessKey.ToString()
                };
                _keys.Add(ProcessKey);

                Packet = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Packet,
                    KeyCode = Forms.Keys.Packet,
                    Name = Forms.Keys.Packet.ToString()
                };
                _keys.Add(Packet);

                Attn = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Attn,
                    KeyCode = Forms.Keys.Attn,
                    Name = Forms.Keys.Attn.ToString()
                };
                _keys.Add(Attn);

                Crsel = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Crsel,
                    KeyCode = Forms.Keys.Crsel,
                    Name = Forms.Keys.Crsel.ToString()
                };
                _keys.Add(Crsel);

                Exsel = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Exsel,
                    KeyCode = Forms.Keys.Exsel,
                    Name = Forms.Keys.Exsel.ToString()
                };
                _keys.Add(Exsel);

                EraseEof = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.EraseEof,
                    KeyCode = Forms.Keys.EraseEof,
                    Name = Forms.Keys.EraseEof.ToString()
                };
                _keys.Add(EraseEof);

                Play = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Play,
                    KeyCode = Forms.Keys.Play,
                    Name = Forms.Keys.Play.ToString()
                };
                _keys.Add(Play);

                Zoom = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Zoom,
                    KeyCode = Forms.Keys.Zoom,
                    Name = Forms.Keys.Zoom.ToString()
                };
                _keys.Add(Zoom);

                Pa1 = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.Pa1,
                    KeyCode = Forms.Keys.Pa1,
                    Name = Forms.Keys.Pa1.ToString()
                };
                _keys.Add(Pa1);

                OemClear = new Key()
                {
                    KeyCodeValue = (int)Forms.Keys.OemClear,
                    KeyCode = Forms.Keys.OemClear,
                    Name = Forms.Keys.OemClear.ToString()
                };
                _keys.Add(OemClear);

                SetDefaultValues();
            }

            public static void SetDefaultValues()
            {
                var regex = new Regex("(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])");
                foreach (var key in _keys)
                {
                    key.Text = regex.Replace(key.Name, " ");
                    key.Size = new Size(1, 1);
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

        public static class Colors
        {
            public static Color White { get; private set; } = Color.White;
            public static Color Black { get; private set; } = Color.Black;
            public static Color Red { get; private set; } = Color.Red;
            public static Color NincPurple { get; private set; } = ColorTranslator.FromHtml("#6c3891");
            public static Color DefaultKeyBackground { get; private set; } = SystemColors.ControlLight;
            public static Color DefaultControlBackground { get; private set; } = SystemColors.Control;
        }
    }
}