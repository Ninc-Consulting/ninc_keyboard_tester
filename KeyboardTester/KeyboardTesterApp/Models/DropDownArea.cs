namespace KeyboardTesterApp.Models
{
    public class DropDownArea
    {
        public Label DropDownLabel { get; private set; }
        public ComboBox DropDownMenu { get; private set; }
        public Size Size { get; private set; }
        public Point Location { get; private set; }

        public DropDownArea(int baseKeyWidth, Font font)
        {
            var offset = baseKeyWidth / 20;
            var yMargin = baseKeyWidth / 4;
            var xMargin = baseKeyWidth / 2;

            DropDownLabel = new()
            {
                Text = "Choose a keyboard layout",
                Font = font,
                Size = TextRenderer.MeasureText("Choose a keyboard layout", font),
                BorderStyle = BorderStyle.None,
                BackColor = Resources.Colors.DefaultControlBackground,
                TabStop = false,
                Location = new Point(xMargin, yMargin)
            };

            var comboBoxItems = CreateComboBoxItemList();
            DropDownMenu = new()
            {
                DataSource = comboBoxItems,
                Font = font,
                DisplayMember = "KeyboardLayoutText",
                ValueMember = "KeyboardLayoutType",
                SelectedItem = comboBoxItems.Single(item => item.KeyboardLayoutType == KeyboardLayoutType.Toughbook),
                Name = "DropDownMenu",
                Location = new Point(DropDownLabel.Location.X, DropDownLabel.Location.Y + DropDownLabel.Height + offset),
                DropDownStyle = ComboBoxStyle.DropDownList,
                TabStop = false,
                Width = GetDropDownWidth(comboBoxItems.Select(item => item.KeyboardLayoutText), baseKeyWidth, font)
            };

            Location = new Point(0, 0);
            Size = new Size(Math.Max(DropDownMenu.Width, DropDownLabel.Width) + xMargin, DropDownMenu.Height + DropDownLabel.Height + yMargin);
        }

        private List<ComboBoxItem> CreateComboBoxItemList()
        {
            var comboBoxItemList = new List<ComboBoxItem>();
            var toughbookItem = new ComboBoxItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.Toughbook,
                KeyboardLayoutText = "Toughbook CF-31"
            };
            comboBoxItemList.Add(toughbookItem);
            var iso105Item = new ComboBoxItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.ISO_105_SE,
                KeyboardLayoutText = "ISO 105 - SE"
            };
            comboBoxItemList.Add(iso105Item);
            var allKeys = new ComboBoxItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.AllKeys,
                KeyboardLayoutText = "All Keys"
            };
            comboBoxItemList.Add(allKeys);

            return comboBoxItemList;
        }

        private int GetDropDownWidth(IEnumerable<string> comboBoxItemTexts, int baseKeyWidth, Font font)
        {
            var maxWidth = 0;

            foreach (var text in comboBoxItemTexts)
            {
                Size size = TextRenderer.MeasureText(text, font);
                if (size.Width > maxWidth)
                {
                    maxWidth = size.Width;
                }
            }

            maxWidth += Convert.ToInt32(baseKeyWidth / 2); // Add baseKeyWidth divided by 2 to account for the width of the dropdown button

            if (DropDownLabel.Width > maxWidth)
            {
                maxWidth = DropDownLabel.Width;
            }

            return maxWidth;
        }
    }
}