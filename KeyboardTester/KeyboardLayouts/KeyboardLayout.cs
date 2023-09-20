using static System.Windows.Forms.Control;

namespace KeyboardTester.KeyboardLayouts
{
    public class KeyboardLayout
    {
        public Dictionary<int, Key> Keys { get; } = new Dictionary<int, Key>();
        public Size KeyboardLayoutSize { get; private set; }
        protected static int BaseLength { get; private set; }

        private static ControlCollection? _controls;
        private static Font? _font;

        public KeyboardLayout(ControlCollection controls, int baseLength)
        {
            BaseLength = baseLength;
            _controls = controls;
            _font = new("Segoe UI", Convert.ToInt32(BaseLength * 0.10));
        }

        protected void AddKeysToBaseClass(List<Key> keys)
        {
            foreach (var key in keys)
            {
                Keys.Add(key.KeyValue, key);
            }
            SetCommonAttributes();
            SetKeyboardLayoutSize();
            AddKeysToControls();
        }

        private void SetCommonAttributes()
        {
            foreach (var key in Keys.Values)
            {
                key.TabStop = false;
                key.Font = _font;
                key.BackColor = Color.FromArgb(0, 250, 250, 250);
                key.ForeColor = Color.Black;
            }
        }

        private void SetKeyboardLayoutSize()
        {
            var maxX = 0;
            var maxY = 0;

            foreach (var key in Keys.Values)
            {
                maxX = Math.Max(maxX, key.Location.X + key.Width);
                maxY = Math.Max(maxY, key.Location.Y + key.Height);
            }

            maxX += BaseLength;
            maxY += BaseLength;
            KeyboardLayoutSize = new Size(maxX, maxY);
        }

        private void AddKeysToControls()
        {
            foreach (var key in Keys)
            {
                _controls?.Add(key.Value);
            }
        }
    }
}
