namespace KeyboardTester.Util
{
    public class KeyboardLayoutDto
    {
        public List<KeyDto> LayoutKeys { get;  set; } = new List<KeyDto>();
        public KeyboardLayoutType KeyboardLayoutType { get; set; }

        public KeyboardLayoutDto()
        {
        }

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
                        BackColorHtml = key.BackColor.Name,
                        BackColorRgb = key.BackColor,
                        Name = key.Name
                    });
            }
        }
    }

    public class KeyDto
    {
        public int KeyCodeValue { get; set; }
        public Keys KeyCode { get; set; }
        public string BackColorHtml { get; set; } = string.Empty;
        public Color BackColorRgb { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
