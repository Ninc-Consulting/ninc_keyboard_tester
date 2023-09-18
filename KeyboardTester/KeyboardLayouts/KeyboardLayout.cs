using static System.Windows.Forms.Control;

namespace KeyboardTester.KeyboardLayouts
{
    public class KeyboardLayout
    {
        public Dictionary<int, Key> Keys { get; set; } = new Dictionary<int, Key>();

        public Size KeyboardLayoutSize;

        protected void AddControls(ControlCollection controls)
        {
            foreach (var key in Keys)
            {
                controls.Add(key.Value);
            }
        }
    }
}
