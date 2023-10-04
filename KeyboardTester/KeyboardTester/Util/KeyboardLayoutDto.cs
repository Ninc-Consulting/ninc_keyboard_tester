namespace KeyboardTester.Util
{
    public class KeyboardLayoutDto
    {
        public List<KeyDto> LayoutKeys { get; set; } = new List<KeyDto>();
        public KeyboardLayoutType KeyboardLayoutType { get; set; }

        public void Map(KeyboardLayout keyboardLayout)
        {
            KeyboardLayoutType = keyboardLayout.KeyboardLayoutType;

            foreach (var key in keyboardLayout.LayoutKeys.Values.ToList())
            {
                LayoutKeys.Add(
                    new KeyDto()
                    {
                        KeyCodeValue = key.KeyCodeValue,
                        KeyCode = key.KeyCode,
                        BackColor = key.BackColor
                    });
            }
        }
    }
}