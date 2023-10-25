namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private const int _keyDownEvent = 0x0100;
        private const int _keyUpEvent = 0x0101;

        private const byte _noFlag = 0;
        private const byte _extendedFlag = 0b1;
        private const byte _injectedFlag = 0b10000;
        private const byte _altFlag = 0b100000;

        private readonly KeyboardLayoutService _keyboardLayoutService = new();
        private readonly ToughbookService _toughbookService = new();
        private readonly InformationAreaService _informationAreaService = new();
        private readonly DropDownAreaService _dropDownAreaService = new();

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            // Delete KeyboardLayoutState.txt after all tests are done
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KeyboardTester");
            var file = Path.Combine(folderPath, "KeyboardLayoutState.txt");
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Resources.Keys.ResetToDefaultValues();
        }

        [TestMethod]
        public void U010_SendKeyDownA_ToKeyEvent_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.A;
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void U020_SendKeyUpA_ToKeyEvent_BorderColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.A;
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _noFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void U030_SendKeyDownLeftControlWithAltFlag_ToKeyEvent_BackColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.LeftControl;
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void U040_SendKeyUpLeftControlWithAltFlag_ToKeyEvent_BorderColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);

            // Send AltGr to store as latest key down value
            var altGr = Resources.Keys.RightAlt;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, altGr.KeyCodeValue, _altFlag);
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Send left control key up
            var leftControlKey = Resources.Keys.LeftControl;
            var previousBorderColor = leftControlKey.FlatAppearance.BorderColor;
            keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, leftControlKey.KeyCodeValue, _noFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBorderColor,
                actual: leftControlKey.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void U050_SendKeyDownDeleteWithExtendedFlag_ToKeyEvent_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.Delete;
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _extendedFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void U060_SendKeyUpDeleteWithExtendedFlag_ToKeyEvent_BorderColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.Delete;
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _extendedFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void U070_SendKeyDownDeleteWithoutExtendedFlag_ToKeyEvent_BackColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.Delete;
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void U080_SendKeyUpDeleteWithoutExtendedFlag_ToKeyEvent_BorderColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.Delete;
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _noFlag);

            // Act
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void U090_SendKeyDownVolumeMute_ToKeyEventForToughbookLayout_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Toughbook);
            var volumeKey = Resources.Keys.VolumeMute;
            var f4Key = Resources.Keys.F4;
            var fnKey = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.Name == "Fn");
            var volumePreviousBackColor = volumeKey.BackColor;
            var f4PreviousBackColor = f4Key.BackColor;
            var fnPreviousBackColor = fnKey.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, volumeKey.KeyCodeValue, _injectedFlag | _extendedFlag);

            // Act
            _toughbookService.HandleFnKey(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: typeof(ToughbookKeyboardLayout),
                actual: form.KeyboardLayout.GetType());
            Assert.AreEqual(
                expected: volumePreviousBackColor,
                actual: volumeKey.BackColor);
            Assert.AreNotEqual(
                notExpected: f4PreviousBackColor,
                actual: f4Key.BackColor);
            Assert.AreNotEqual(
                notExpected: fnPreviousBackColor,
                actual: fnKey.BackColor);
        }

        [TestMethod]
        public void U100_SendKeyUpVolumeMute_ToKeyEventForToughbookLayout_BorderColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Toughbook);
            var volumeKey = Resources.Keys.VolumeMute;
            var f4Key = Resources.Keys.F4;
            var fnKey = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.Name == "Fn");
            var volumePreviousBorderColor = volumeKey.FlatAppearance.BorderColor;
            var f4PreviousBorderColor = f4Key.FlatAppearance.BorderColor;
            var fnPreviousBorderColor = fnKey.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, volumeKey.KeyCodeValue, _injectedFlag | _extendedFlag);

            // Act
            _toughbookService.HandleFnKey(form.KeyboardLayout, keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: typeof(ToughbookKeyboardLayout),
                actual: form.KeyboardLayout.GetType());
            Assert.AreEqual(
                expected: volumePreviousBorderColor,
                actual: volumeKey.FlatAppearance.BorderColor);
            Assert.AreNotEqual(
                notExpected: f4PreviousBorderColor,
                actual: f4Key.FlatAppearance.BorderColor);
            Assert.AreNotEqual(
                notExpected: fnPreviousBorderColor,
                actual: fnKey.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void U110_SendKeyDownControlWithAltFlag_ToSetTextBoxValues_TextChangesToCorrectValues()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var key = Resources.Keys.LeftControl;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);
            var initialKeyCode = form.InformationArea.KeyCodeValue.Text;
            var initialKeyName = form.InformationArea.KeyNameValue.Text;
            var initialKeyFlags = form.InformationArea.KeyFlagsValue.Text;

            // Act
            _informationAreaService.SetTextBoxValues(form.InformationArea, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: initialKeyCode,
                actual: form.InformationArea.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyName,
                actual: form.InformationArea.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyFlags,
                actual: form.InformationArea.KeyFlagsValue.Text);

            Assert.AreEqual(
                expected: "0x" + Convert.ToString((int)Keys.LControlKey, 16).PadLeft(2, '0').ToUpper(),
                actual: form.InformationArea.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: Keys.LControlKey.ToString(),
                actual: form.InformationArea.KeyNameValue.Text);
            Assert.AreEqual(
                expected: Convert.ToString(_altFlag, 2).PadLeft(8, '0'),
                actual: form.InformationArea.KeyFlagsValue.Text);
        }

        [TestMethod]
        public void U120_SendKeyboardLayout_ToResetLayouts_LayoutsAreReset()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var previousCode = form.InformationArea.KeyCodeValue.Text = "0x41";
            var previousName = form.InformationArea.KeyNameValue.Text = "A";
            var previousFlag = form.InformationArea.KeyFlagsValue.Text = "00000000";
            form.KeyboardLayout.LayoutKeys
                .Select(dict => dict.Value)
                .Single(key => key.KeyCode == Keys.A)
                .BackColor = Resources.Colors.NincPurple;

            // Act
            _informationAreaService.ResetLayout(form);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousCode,
                actual: form.InformationArea.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: previousName,
                actual: form.InformationArea.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: previousFlag,
                actual: form.InformationArea.KeyFlagsValue.Text);
            Assert.AreNotEqual(
                notExpected: Resources.Colors.NincPurple,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);

            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationArea.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationArea.KeyNameValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationArea.KeyFlagsValue.Text);
            Assert.AreEqual(
                expected: Resources.Colors.DefaultKeyBackground,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);
        }

        [TestMethod]
        public void U130_SendNewKeyboardLayoutType_ToChangeLayout_LayoutIsChanged()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105_SE);
            var previousKeyboardLayoutType = form.KeyboardLayout.KeyboardLayoutType;
            PopulateDropDownMenu(form.DropDownArea.DropDownMenu);
            form.DropDownArea.DropDownMenu.SelectedValue = KeyboardLayoutType.AllKeys;

            // Act
            _dropDownAreaService.ChangeLayout(form);

            // Assert
            Assert.AreEqual(
                expected: KeyboardLayoutType.ISO_105_SE,
                actual: previousKeyboardLayoutType);
            Assert.AreEqual(
                expected: KeyboardLayoutType.AllKeys,
                actual: form.KeyboardLayout.KeyboardLayoutType);
        }

        private void PopulateDropDownMenu(ComboBox dropDownMenu)
        {
            var comboBoxItemList = new List<ComboBoxItem>();
            var toughbookItem = new ComboBoxItem()
            {
                KeyboardLayoutType = KeyboardLayoutType.Toughbook,
                KeyboardLayoutText = "Toughbook"
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

            dropDownMenu.DataSource = comboBoxItemList;
            dropDownMenu.SelectedItem = iso105Item;
        }
    }
}