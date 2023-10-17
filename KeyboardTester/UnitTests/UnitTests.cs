namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private const int _keyDownEvent = 0x0100;
        private const int _keyUpEvent = 0x0101;

        private const byte _extendedFlag = 0b1;
        private const byte _altFlag = 0b100000;
        private const byte _noFlag = 0;

        private readonly KeyboardLayoutService _keyboardLayoutService = new KeyboardLayoutService();
        private readonly InformationBoxService _informationBoxService = new InformationBoxService();
        private readonly DropDownMenuService _downMenuService = new DropDownMenuService();

        [TestMethod]
        public void U010_SendKeyDownA_ToKeyEvent_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.A);
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
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.A);
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
        public void U030_SendKeyDownLControlWithAltFlag_ToKeyEvent_BackColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
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
        public void U040_SendKeyUpLControlWithAltFlag_ToKeyEvent_BorderColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);

            // Send AltGr to store as latest key down value
            var altGr = form.KeyboardLayout.LayoutKeys
               .Select(x => x.Value)
               .Single(x => x.KeyCode == Keys.RMenu);
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, altGr.KeyCodeValue, _altFlag);
            _keyboardLayoutService.KeyEvent(form.KeyboardLayout, keyEventArgs);

            // Send left control key up
            var leftControlKey = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
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
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
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
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
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
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
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
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
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
        public void U090_SendKeyDownControlWithAltFlag_ToSetTextBoxValues_TextChangesToCorrectValues()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);
            var initialKeyCode = form.InformationBox.KeyCodeValue.Text;
            var initialKeyName = form.InformationBox.KeyNameValue.Text;
            var initialKeyFlags = form.InformationBox.KeyFlagsValue.Text;

            // Act
            _informationBoxService.SetTextBoxValues(form.InformationBox, keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: initialKeyCode,
                actual: form.InformationBox.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyName,
                actual: form.InformationBox.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyFlags,
                actual: form.InformationBox.KeyFlagsValue.Text);

            Assert.AreEqual(
                expected: "0x" + Convert.ToString((int)Keys.LControlKey, 16).PadLeft(2, '0').ToUpper(),
                actual: form.InformationBox.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: Keys.LControlKey.ToString(),
                actual: form.InformationBox.KeyNameValue.Text);
            Assert.AreEqual(
                expected: Convert.ToString(_altFlag, 2).PadLeft(8, '0'),
                actual: form.InformationBox.KeyFlagsValue.Text);
        }

        [TestMethod]
        public void U100_SendKeyboardLayout_ToResetLayouts_LayoutsAreReset()
        {
            // Arrange
            var defaultColor = SystemColors.ControlLight;
            var purpleColor = ColorTranslator.FromHtml("#6c3891");
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var previousCode = form.InformationBox.KeyCodeValue.Text = "0x41";
            var previousName = form.InformationBox.KeyNameValue.Text = "A";
            var previousFlag = form.InformationBox.KeyFlagsValue.Text = "00000000";
            form.KeyboardLayout.LayoutKeys
                .Select(dict => dict.Value)
                .Single(key => key.KeyCode == Keys.A)
                .BackColor = purpleColor;

            // Act
            _informationBoxService.ResetLayout(form);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousCode,
                actual: form.InformationBox.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: previousName,
                actual: form.InformationBox.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: previousFlag,
                actual: form.InformationBox.KeyFlagsValue.Text);
            Assert.AreNotEqual(
                notExpected: purpleColor,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);

            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationBox.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationBox.KeyNameValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationBox.KeyFlagsValue.Text);
            Assert.AreEqual(
                expected: defaultColor,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);
        }

        [TestMethod]
        public void U110_SendNewKeyboardLayoutType_ToChangeLayout_LayoutIsChanged()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var previousKeyboardLayoutType = form.KeyboardLayout.KeyboardLayoutType;
            form.DropDownMenu.SelectedValue = KeyboardLayoutType.AllKeys;

            // Act
            _downMenuService.ChangeLayout(form);

            // Assert
            Assert.AreEqual(
                expected: KeyboardLayoutType.ISO_105,
                actual: previousKeyboardLayoutType);
            Assert.AreEqual(
                expected: KeyboardLayoutType.AllKeys,
                actual: form.KeyboardLayout.KeyboardLayoutType);
        }
    }
}