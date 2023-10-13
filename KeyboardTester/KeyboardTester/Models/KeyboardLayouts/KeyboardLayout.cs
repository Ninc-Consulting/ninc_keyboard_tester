namespace KeyboardTester.Models.KeyboardLayouts
{
    public class KeyboardLayout
    {
        public static int BaseKeyWidth { get; private set; }
        public Dictionary<int, Key> LayoutKeys { get; private set; } = new Dictionary<int, Key>();
        public Size Size { get; private set; }
        public KeyboardLayoutType KeyboardLayoutType { get; protected set; }

        public KeyboardLayout(int baseKeyWidth)
        {
            BaseKeyWidth = baseKeyWidth;
        }

        protected void AddKeyToLayout(Key key)
        {
            LayoutKeys.Add(key.KeyCodeValue, key);
        }

        protected void SetCommonAttributes()
        {
            foreach (var key in LayoutKeys.Values)
            {
                key.TabStop = false;
                key.Font = KeyboardTesterForm.ScaledFont;
                key.BackColor = SystemColors.ControlLight;
                key.ForeColor = Color.Black;
            }
        }

        protected void SetKeyboardLayoutSize()
        {
            var maxX = 0;
            var maxY = 0;

            foreach (var key in LayoutKeys.Values)
            {
                maxX = Math.Max(maxX, key.Location.X + key.Width);
                maxY = Math.Max(maxY, key.Location.Y + key.Height);
            }

            maxX += BaseKeyWidth;
            maxY += BaseKeyWidth;
            Size = new Size(maxX, maxY);
        }
    }
}