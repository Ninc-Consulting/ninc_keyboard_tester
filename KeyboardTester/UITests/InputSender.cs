namespace UITests
{
    public static class InputSender
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput
        {
            public ushort Wvk;
            public ushort WScan;
            public uint DwFlags;
            public uint Time;
            public IntPtr DwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int Dx;
            public int Dy;
            public uint MouseData;
            public uint DwFlags;
            public uint Time;
            public IntPtr DwExtraInfo;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public uint UMsg;
            public ushort WParamL;
            public ushort WParamH;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)]
            public MouseInput Mi;
            [FieldOffset(0)]
            public KeyboardInput Ki;
            [FieldOffset(0)]
            public HardwareInput Hi;
        }

        public struct Input
        {
            public int Type;
            public InputUnion U;
        }

        [Flags]
        public enum InputType
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }

        [Flags]
        public enum KeyEventF
        {
            KeyDown = 0x0000,
            ExtendedKey = 0x0001,
            KeyUp = 0x0002,
            Unicode = 0x0004,
            Scancode = 0x0008
        }

        public static void SendKeyboardInput(KeyboardInput[] kbInputs)
        {
            Input[] inputs = new Input[kbInputs.Length];

            for (int i = 0; i < kbInputs.Length; i++)
            {
                inputs[i] = new Input
                {
                    Type = (int)InputType.Keyboard,
                    U = new InputUnion
                    {
                        Ki = kbInputs[i]
                    }
                };
            }

            _ = NativeMethods.SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        private static class NativeMethods
        {
            [DllImport("user32.dll", SetLastError = true)]
            public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);
        }
    }
}