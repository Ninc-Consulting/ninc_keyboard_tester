namespace KeyboardTester
{
    public class KeyboardKeys
    {
        public Key Back { get; private set; }
        public Key Tab { get; private set; }
        public Key Clear { get; private set; }
        public Key Return { get; private set; }
        public Key Enter { get; private set; }
        public Key Shift { get; private set; }
        public Key Control { get; private set; }
        public Key Alt { get; private set; }
        public Key Pause { get; private set; }
        public Key CapsLock { get; private set; }
        public Key Escape { get; private set; }
        public Key Spacebar { get; private set; }
        public Key PageUp { get; private set; }
        public Key PageDown { get; private set; }
        public Key End { get; private set; }
        public Key Home { get; private set; }
        public Key LeftArrow { get; private set; }
        public Key UpArrow { get; private set; }
        public Key RightArrow { get; private set; }
        public Key DownArrow { get; private set; }
        public Key Print { get; private set; }
        public Key PrintScreen { get; private set; }
        public Key Insert { get; private set; }
        public Key Delete { get; private set; }
        public Key D0 { get; private set; }
        public Key D1 { get; private set; }
        public Key D2 { get; private set; }
        public Key D3 { get; private set; }
        public Key D4 { get; private set; }
        public Key D5 { get; private set; }
        public Key D6 { get; private set; }
        public Key D7 { get; private set; }
        public Key D8 { get; private set; }
        public Key D9 { get; private set; }
        public Key A { get; private set; }
        public Key B { get; private set; }
        public Key C { get; private set; }
        public Key D { get; private set; }
        public Key E { get; private set; }
        public Key F { get; private set; }
        public Key G { get; private set; }
        public Key H { get; private set; }
        public Key I { get; private set; }
        public Key J { get; private set; }
        public Key K { get; private set; }
        public Key L { get; private set; }
        public Key M { get; private set; }
        public Key N { get; private set; }
        public Key O { get; private set; }
        public Key P { get; private set; }
        public Key Q { get; private set; }
        public Key R { get; private set; }
        public Key S { get; private set; }
        public Key T { get; private set; }
        public Key U { get; private set; }
        public Key V { get; private set; }
        public Key W { get; private set; }
        public Key X { get; private set; }
        public Key Y { get; private set; }
        public Key Z { get; private set; }
        public Key LeftWindows { get; private set; }
        public Key RightWindows { get; private set; }
        public Key Applications { get; private set; }
        public Key Sleep { get; private set; }
        public Key NumPad0 { get; private set; }
        public Key NumPad1 { get; private set; }
        public Key NumPad2 { get; private set; }
        public Key NumPad3 { get; private set; }
        public Key NumPad4 { get; private set; }
        public Key NumPad5 { get; private set; }
        public Key NumPad6 { get; private set; }
        public Key NumPad7 { get; private set; }
        public Key NumPad8 { get; private set; }
        public Key NumPad9 { get; private set; }
        public Key Multiply { get; private set; }
        public Key Add { get; private set; }
        public Key Separator { get; private set; }
        public Key Subtract { get; private set; }
        public Key Decimal { get; private set; }
        public Key Divide { get; private set; }
        public Key F1 { get; private set; }
        public Key F2 { get; private set; }
        public Key F3 { get; private set; }
        public Key F4 { get; private set; }
        public Key F5 { get; private set; }
        public Key F6 { get; private set; }
        public Key F7 { get; private set; }
        public Key F8 { get; private set; }
        public Key F9 { get; private set; }
        public Key F10 { get; private set; }
        public Key F11 { get; private set; }
        public Key F12 { get; private set; }
        public Key NumLock { get; private set; }
        public Key ScrollLock { get; private set; }
        public Key LeftShift { get; private set; }
        public Key RightShift { get; private set; }
        public Key LeftControl { get; private set; }
        public Key RightControl { get; private set; }
        public Key LeftAlt { get; private set; }
        public Key RightAlt { get; private set; }
        public Key BrowserHome { get; private set; }
        public Key VolumeMute { get; private set; }
        public Key VolumeDown { get; private set; }
        public Key VolumeUp { get; private set; }
        public Key LaunchMail { get; private set; }
        public Key LaunchApplication1 { get; private set; }
        public Key LaunchApplication2 { get; private set; }
        public Key Oem1 { get; private set; }
        public Key OemPlus { get; private set; }
        public Key OemComma { get; private set; }
        public Key OemMinus { get; private set; }
        public Key OemPeriod { get; private set; }
        public Key Oem2 { get; private set; }
        public Key Oem3 { get; private set; }
        public Key Oem4 { get; private set; }
        public Key Oem5 { get; private set; }
        public Key Oem6 { get; private set; }
        public Key Oem7 { get; private set; }
        public Key Oem8 { get; private set; }
        public Key Oem102 { get; private set; }
        public Key Fn { get; private set; }

        public KeyboardKeys()
        {
            Back = new Key()
            {
                KeyCodeValue = (int)Keys.Back,
                KeyCode = Keys.Back,
                Name = Keys.Back.ToString()
            };
            Tab = new Key()
            {
                KeyCodeValue = (int)Keys.Tab,
                KeyCode = Keys.Tab,
                Name = Keys.Tab.ToString()
            };
            Clear = new Key()
            {
                KeyCodeValue = (int)Keys.Clear,
                KeyCode = Keys.Clear,
                Name = Keys.Clear.ToString()
            };
            Return = new Key()
            {
                KeyCodeValue = (int)Keys.Return,
                KeyCode = Keys.Return,
                Name = Keys.Return.ToString()
            };
            Enter = new Key()
            {
                KeyCodeValue = -(int)Keys.Enter,    // Inverting the KeyCodeValue to distinguish between Return and Enter since they both have the same values in the Keys enumerator
                KeyCode = Keys.Enter,
                Name = Keys.Enter.ToString()
            };
            Shift = new Key()
            {
                KeyCodeValue = (int)Keys.ShiftKey,
                KeyCode = Keys.ShiftKey,
                Name = Keys.ShiftKey.ToString()
            };
            Control = new Key()
            {
                KeyCodeValue = (int)Keys.ControlKey,
                KeyCode = Keys.ControlKey,
                Name = Keys.ControlKey.ToString()
            };
            Alt = new Key()
            {
                KeyCodeValue = (int)Keys.Alt,
                KeyCode = Keys.Alt,
                Name = Keys.Alt.ToString()
            };
            Pause = new Key()
            {
                KeyCodeValue = (int)Keys.Pause,
                KeyCode = Keys.Pause,
                Name = Keys.Pause.ToString()
            };
            CapsLock = new Key()
            {
                KeyCodeValue = (int)Keys.CapsLock,
                KeyCode = Keys.CapsLock,
                Name = Keys.CapsLock.ToString()
            };
            Escape = new Key()
            {
                KeyCodeValue = (int)Keys.Escape,
                KeyCode = Keys.Escape,
                Name = Keys.Escape.ToString()
            };
            Spacebar = new Key()
            {
                KeyCodeValue = (int)Keys.Space,
                KeyCode = Keys.Space,
                Name = Keys.Space.ToString()
            };
            PageUp = new Key()
            {
                KeyCodeValue = (int)Keys.PageUp,
                KeyCode = Keys.PageUp,
                Name = Keys.PageUp.ToString()
            };
            PageDown = new Key()
            {
                KeyCodeValue = (int)Keys.PageDown,
                KeyCode = Keys.PageDown,
                Name = Keys.PageDown.ToString()
            };
            End = new Key()
            {
                KeyCodeValue = (int)Keys.End,
                KeyCode = Keys.End,
                Name = Keys.End.ToString()
            };
            Home = new Key()
            {
                KeyCodeValue = (int)Keys.Home,
                KeyCode = Keys.Home,
                Name = Keys.Home.ToString()
            };
            LeftArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Left,
                KeyCode = Keys.Left,
                Name = Keys.Left.ToString()
            };
            UpArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Up,
                KeyCode = Keys.Up,
                Name = Keys.Up.ToString()
            };
            RightArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Right,
                KeyCode = Keys.Right,
                Name = Keys.Right.ToString()
            };
            DownArrow = new Key()
            {
                KeyCodeValue = (int)Keys.Down,
                KeyCode = Keys.Down,
                Name = Keys.Down.ToString()
            };
            Print = new Key()
            {
                KeyCodeValue = (int)Keys.Print,
                KeyCode = Keys.Print,
                Name = Keys.Print.ToString()
            };
            PrintScreen = new Key()
            {
                KeyCodeValue = (int)Keys.PrintScreen,
                KeyCode = Keys.PrintScreen,
                Name = Keys.PrintScreen.ToString()
            };
            Insert = new Key()
            {
                KeyCodeValue = (int)Keys.Insert,
                KeyCode = Keys.Insert,
                Name = Keys.Insert.ToString()
            };
            Delete = new Key()
            {
                KeyCodeValue = (int)Keys.Delete,
                KeyCode = Keys.Delete,
                Name = Keys.Delete.ToString()
            };
            D0 = new Key()
            {
                KeyCodeValue = (int)Keys.D0,
                KeyCode = Keys.D0,
                Name = Keys.D0.ToString()
            };
            D1 = new Key()
            {
                KeyCodeValue = (int)Keys.D1,
                KeyCode = Keys.D1,
                Name = Keys.D1.ToString()
            };
            D2 = new Key()
            {
                KeyCodeValue = (int)Keys.D2,
                KeyCode = Keys.D2,
                Name = Keys.D2.ToString()
            };
            D3 = new Key()
            {
                KeyCodeValue = (int)Keys.D3,
                KeyCode = Keys.D3,
                Name = Keys.D3.ToString()
            };
            D4 = new Key()
            {
                KeyCodeValue = (int)Keys.D4,
                KeyCode = Keys.D4,
                Name = Keys.D4.ToString()
            };
            D5 = new Key()
            {
                KeyCodeValue = (int)Keys.D5,
                KeyCode = Keys.D5,
                Name = Keys.D5.ToString()
            };
            D6 = new Key()
            {
                KeyCodeValue = (int)Keys.D6,
                KeyCode = Keys.D6,
                Name = Keys.D6.ToString()
            };
            D7 = new Key()
            {
                KeyCodeValue = (int)Keys.D7,
                KeyCode = Keys.D7,
                Name = Keys.D7.ToString()
            };
            D8 = new Key()
            {
                KeyCodeValue = (int)Keys.D8,
                KeyCode = Keys.D8,
                Name = Keys.D8.ToString()
            };
            D9 = new Key()
            {
                KeyCodeValue = (int)Keys.D9,
                KeyCode = Keys.D9,
                Name = Keys.D9.ToString()
            };
            A = new Key()
            {
                KeyCodeValue = (int)Keys.A,
                KeyCode = Keys.A,
                Name = Keys.A.ToString()
            };
            B = new Key()
            {
                KeyCodeValue = (int)Keys.B,
                KeyCode = Keys.B,
                Name = Keys.B.ToString()
            };
            C = new Key()
            {
                KeyCodeValue = (int)Keys.C,
                KeyCode = Keys.C,
                Name = Keys.C.ToString()
            };
            D = new Key()
            {
                KeyCodeValue = (int)Keys.D,
                KeyCode = Keys.D,
                Name = Keys.D.ToString()
            };
            E = new Key()
            {
                KeyCodeValue = (int)Keys.E,
                KeyCode = Keys.E,
                Name = Keys.E.ToString()
            };
            F = new Key()
            {
                KeyCodeValue = (int)Keys.F,
                KeyCode = Keys.F,
                Name = Keys.F.ToString()
            };
            G = new Key()
            {
                KeyCodeValue = (int)Keys.G,
                KeyCode = Keys.G,
                Name = Keys.G.ToString()
            };
            H = new Key()
            {
                KeyCodeValue = (int)Keys.H,
                KeyCode = Keys.H,
                Name = Keys.H.ToString()
            };
            I = new Key()
            {
                KeyCodeValue = (int)Keys.I,
                KeyCode = Keys.I,
                Name = Keys.I.ToString()
            };
            J = new Key()
            {
                KeyCodeValue = (int)Keys.J,
                KeyCode = Keys.J,
                Name = Keys.J.ToString()
            };
            K = new Key()
            {
                KeyCodeValue = (int)Keys.K,
                KeyCode = Keys.K,
                Name = Keys.K.ToString()
            };
            L = new Key()
            {
                KeyCodeValue = (int)Keys.L,
                KeyCode = Keys.L,
                Name = Keys.L.ToString()
            };
            M = new Key()
            {
                KeyCodeValue = (int)Keys.M,
                KeyCode = Keys.M,
                Name = Keys.M.ToString()
            };
            N = new Key()
            {
                KeyCodeValue = (int)Keys.N,
                KeyCode = Keys.N,
                Name = Keys.N.ToString()
            };
            O = new Key()
            {
                KeyCodeValue = (int)Keys.O,
                KeyCode = Keys.O,
                Name = Keys.O.ToString()
            };
            P = new Key()
            {
                KeyCodeValue = (int)Keys.P,
                KeyCode = Keys.P,
                Name = Keys.P.ToString()
            };
            Q = new Key()
            {
                KeyCodeValue = (int)Keys.Q,
                KeyCode = Keys.Q,
                Name = Keys.Q.ToString()
            };
            R = new Key()
            {
                KeyCodeValue = (int)Keys.R,
                KeyCode = Keys.R,
                Name = Keys.R.ToString()
            };
            S = new Key()
            {
                KeyCodeValue = (int)Keys.S,
                KeyCode = Keys.S,
                Name = Keys.S.ToString()
            };
            T = new Key()
            {
                KeyCodeValue = (int)Keys.T,
                KeyCode = Keys.T,
                Name = Keys.T.ToString()
            };
            U = new Key()
            {
                KeyCodeValue = (int)Keys.U,
                KeyCode = Keys.U,
                Name = Keys.U.ToString()
            };
            V = new Key()
            {
                KeyCodeValue = (int)Keys.V,
                KeyCode = Keys.V,
                Name = Keys.V.ToString()
            };
            W = new Key()
            {
                KeyCodeValue = (int)Keys.W,
                KeyCode = Keys.W,
                Name = Keys.W.ToString()
            };
            X = new Key()
            {
                KeyCodeValue = (int)Keys.X,
                KeyCode = Keys.X,
                Name = Keys.X.ToString()
            };
            Y = new Key()
            {
                KeyCodeValue = (int)Keys.Y,
                KeyCode = Keys.Y,
                Name = Keys.Y.ToString()
            };
            Z = new Key()
            {
                KeyCodeValue = (int)Keys.Z,
                KeyCode = Keys.Z,
                Name = Keys.Z.ToString()
            };
            LeftWindows = new Key()
            {
                KeyCodeValue = (int)Keys.LWin,
                KeyCode = Keys.LWin,
                Name = Keys.LWin.ToString()
            };
            RightWindows = new Key()
            {
                KeyCodeValue = (int)Keys.RWin,
                KeyCode = Keys.RWin,
                Name = Keys.RWin.ToString()
            };
            Applications = new Key()
            {
                KeyCodeValue = (int)Keys.Apps,
                KeyCode = Keys.Apps,
                Name = Keys.Apps.ToString()
            };
            Sleep = new Key()
            {
                KeyCodeValue = (int)Keys.Sleep,
                KeyCode = Keys.Sleep,
                Name = Keys.Sleep.ToString()
            };
            NumPad0 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad0,
                KeyCode = Keys.NumPad0,
                Name = Keys.NumPad0.ToString()
            };
            NumPad1 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad1,
                KeyCode = Keys.NumPad1,
                Name = Keys.NumPad1.ToString()
            };
            NumPad2 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad2,
                KeyCode = Keys.NumPad2,
                Name = Keys.NumPad2.ToString()
            };
            NumPad3 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad3,
                KeyCode = Keys.NumPad3,
                Name = Keys.NumPad3.ToString()
            };
            NumPad4 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad4,
                KeyCode = Keys.NumPad4,
                Name = Keys.NumPad4.ToString()
            };
            NumPad5 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad5,
                KeyCode = Keys.NumPad5,
                Name = Keys.NumPad5.ToString()
            };
            NumPad6 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad6,
                KeyCode = Keys.NumPad6,
                Name = Keys.NumPad6.ToString()
            };
            NumPad7 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad7,
                KeyCode = Keys.NumPad7,
                Name = Keys.NumPad7.ToString()
            };
            NumPad8 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad8,
                KeyCode = Keys.NumPad8,
                Name = Keys.NumPad8.ToString()
            };
            NumPad9 = new Key()
            {
                KeyCodeValue = (int)Keys.NumPad9,
                KeyCode = Keys.NumPad9,
                Name = Keys.NumPad9.ToString()
            };
            Multiply = new Key()
            {
                KeyCodeValue = (int)Keys.Multiply,
                KeyCode = Keys.Multiply,
                Name = Keys.Multiply.ToString()
            };
            Add = new Key()
            {
                KeyCodeValue = (int)Keys.Add,
                KeyCode = Keys.Add,
                Name = Keys.Add.ToString()
            };
            Separator = new Key()
            {
                KeyCodeValue = (int)Keys.Separator,
                KeyCode = Keys.Separator,
                Name = Keys.Separator.ToString()
            };
            Subtract = new Key()
            {
                KeyCodeValue = (int)Keys.Subtract,
                KeyCode = Keys.Subtract,
                Name = Keys.Subtract.ToString()
            };
            Decimal = new Key()
            {
                KeyCodeValue = (int)Keys.Decimal,
                KeyCode = Keys.Decimal,
                Name = Keys.Decimal.ToString()
            };
            Divide = new Key()
            {
                KeyCodeValue = (int)Keys.Divide,
                KeyCode = Keys.Divide,
                Name = Keys.Divide.ToString()
            };
            Divide = new Key()
            {
                KeyCodeValue = (int)Keys.Divide,
                KeyCode = Keys.Divide,
                Name = Keys.Divide.ToString()
            };
            F1 = new Key()
            {
                KeyCodeValue = (int)Keys.F1,
                KeyCode = Keys.F1,
                Name = Keys.F1.ToString()
            };
            F2 = new Key()
            {
                KeyCodeValue = (int)Keys.F2,
                KeyCode = Keys.F2,
                Name = Keys.F2.ToString()
            };
            F3 = new Key()
            {
                KeyCodeValue = (int)Keys.F3,
                KeyCode = Keys.F3,
                Name = Keys.F3.ToString()
            };
            F4 = new Key()
            {
                KeyCodeValue = (int)Keys.F4,
                KeyCode = Keys.F4,
                Name = Keys.F4.ToString()
            };
            F5 = new Key()
            {
                KeyCodeValue = (int)Keys.F5,
                KeyCode = Keys.F5,
                Name = Keys.F5.ToString()
            };
            F6 = new Key()
            {
                KeyCodeValue = (int)Keys.F6,
                KeyCode = Keys.F6,
                Name = Keys.F6.ToString()
            };
            F7 = new Key()
            {
                KeyCodeValue = (int)Keys.F7,
                KeyCode = Keys.F7,
                Name = Keys.F7.ToString()
            };
            F8 = new Key()
            {
                KeyCodeValue = (int)Keys.F8,
                KeyCode = Keys.F8,
                Name = Keys.F8.ToString()
            };
            F9 = new Key()
            {
                KeyCodeValue = (int)Keys.F9,
                KeyCode = Keys.F9,
                Name = Keys.F9.ToString()
            };
            F10 = new Key()
            {
                KeyCodeValue = (int)Keys.F10,
                KeyCode = Keys.F10,
                Name = Keys.F10.ToString()
            };
            F11 = new Key()
            {
                KeyCodeValue = (int)Keys.F11,
                KeyCode = Keys.F11,
                Name = Keys.F11.ToString()
            };
            F12 = new Key()
            {
                KeyCodeValue = (int)Keys.F12,
                KeyCode = Keys.F12,
                Name = Keys.F12.ToString()
            };
            NumLock = new Key()
            {
                KeyCodeValue = (int)Keys.NumLock,
                KeyCode = Keys.NumLock,
                Name = Keys.NumLock.ToString()
            };
            ScrollLock = new Key()
            {
                KeyCodeValue = (int)Keys.Scroll,
                KeyCode = Keys.Scroll,
                Name = Keys.Scroll.ToString()
            };
            LeftShift = new Key()
            {
                KeyCodeValue = (int)Keys.LShiftKey,
                KeyCode = Keys.LShiftKey,
                Name = Keys.LShiftKey.ToString()
            };
            RightShift = new Key()
            {
                KeyCodeValue = (int)Keys.RShiftKey,
                KeyCode = Keys.RShiftKey,
                Name = Keys.RShiftKey.ToString()
            };
            LeftControl = new Key()
            {
                KeyCodeValue = (int)Keys.LControlKey,
                KeyCode = Keys.LControlKey,
                Name = Keys.LControlKey.ToString()
            };
            RightControl = new Key()
            {
                KeyCodeValue = (int)Keys.RControlKey,
                KeyCode = Keys.RControlKey,
                Name = Keys.RControlKey.ToString()
            };
            LeftAlt = new Key()
            {
                KeyCodeValue = (int)Keys.LMenu,
                KeyCode = Keys.LMenu,
                Name = Keys.LMenu.ToString()
            };
            RightAlt = new Key()
            {
                KeyCodeValue = (int)Keys.RMenu,
                KeyCode = Keys.RMenu,
                Name = Keys.RMenu.ToString()
            };
            BrowserHome = new Key()
            {
                KeyCodeValue = (int)Keys.BrowserHome,
                KeyCode = Keys.BrowserHome,
                Name = Keys.BrowserHome.ToString()
            };
            VolumeMute = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeMute,
                KeyCode = Keys.RMenu,
                Name = Keys.RMenu.ToString()
            };
            VolumeDown = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeDown,
                KeyCode = Keys.VolumeDown,
                Name = Keys.VolumeDown.ToString()
            };
            VolumeUp = new Key()
            {
                KeyCodeValue = (int)Keys.VolumeUp,
                KeyCode = Keys.VolumeUp,
                Name = Keys.VolumeUp.ToString()
            };
            LaunchMail = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchMail,
                KeyCode = Keys.LaunchMail,
                Name = Keys.LaunchMail.ToString()
            };
            LaunchApplication1 = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchApplication1,
                KeyCode = Keys.LaunchApplication1,
                Name = Keys.LaunchApplication1.ToString()
            };
            LaunchApplication2 = new Key()
            {
                KeyCodeValue = (int)Keys.LaunchApplication2,
                KeyCode = Keys.LaunchApplication2,
                Name = Keys.LaunchApplication2.ToString()
            };
            Oem1 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem1,
                KeyCode = Keys.Oem1,
                Name = Keys.Oem1.ToString()
            };
            OemPlus = new Key()
            {
                KeyCodeValue = (int)Keys.Oemplus,
                KeyCode = Keys.Oemplus,
                Name = Keys.Oemplus.ToString()
            };
            OemComma = new Key()
            {
                KeyCodeValue = (int)Keys.Oemcomma,
                KeyCode = Keys.Oemcomma,
                Name = Keys.Oemcomma.ToString()
            };
            OemMinus = new Key()
            {
                KeyCodeValue = (int)Keys.OemMinus,
                KeyCode = Keys.OemMinus,
                Name = Keys.OemMinus.ToString()
            };
            OemPeriod = new Key()
            {
                KeyCodeValue = (int)Keys.OemPeriod,
                KeyCode = Keys.OemPeriod,
                Name = Keys.OemPeriod.ToString()
            };
            Oem2 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem2,
                KeyCode = Keys.Oem2,
                Name = Keys.Oem2.ToString()
            };
            Oem3 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem3,
                KeyCode = Keys.Oem3,
                Name = Keys.Oem3.ToString()
            };
            Oem4 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem4,
                KeyCode = Keys.Oem4,
                Name = Keys.Oem4.ToString()
            };
            Oem5 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem5,
                KeyCode = Keys.Oem5,
                Name = Keys.Oem5.ToString()
            };
            Oem6 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem6,
                KeyCode = Keys.Oem6,
                Name = Keys.Oem6.ToString()
            };
            Oem7 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem7,
                KeyCode = Keys.Oem7,
                Name = Keys.Oem7.ToString()
            };
            Oem8 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem8,
                KeyCode = Keys.Oem8,
                Name = Keys.Oem8.ToString()
            };
            Oem102 = new Key()
            {
                KeyCodeValue = (int)Keys.Oem102,
                KeyCode = Keys.Oem102,
                Name = Keys.Oem102.ToString()
            };

            // There is no KeyCodeValue for Fn button since it doesn't trigger any key event.
            // Fn only alters the values of other keys when they are pressed.
            Fn = new Key()
            {
                KeyCodeValue = -1,
                KeyCode = Keys.None,
                Name = "Fn"
            };
        }
    }
}