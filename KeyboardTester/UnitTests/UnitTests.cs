namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private const int _keyDownEvent = 0x0100;

        private const byte _extendedFlag = 0b1;
        private const byte _altFlag = 0b100000;
        private const byte _noFlag = 0;

        [TestMethod]
        public void A010_SendA_ToKeyDownEvent_ColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.A);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A020_SendLControlWithAltFlag_ToKeyDownEvent_ColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);

            // Act
            form.KeyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A030_SendDeleteWithExtendedFlag_ToKeyDownEvent_ColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _extendedFlag);

            // Act
            form.KeyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A040_SendDeleteWithoutExtendedFlag_ToKeyDownEvent_ColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A050_SendControlWithAltFlag_ToSetTextBoxValues_TextChangesToCorrectValues()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);
            var initialKeyCode = form.InformationLayout.KeyCodeValue.Text;
            var initialKeyName = form.InformationLayout.KeyNameValue.Text;
            var initialKeyFlags = form.InformationLayout.KeyFlagsValue.Text;

            // Act
            form.InformationLayout.SetTextBoxValues(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: initialKeyCode,
                actual: form.InformationLayout.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyName,
                actual: form.InformationLayout.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyFlags,
                actual: form.InformationLayout.KeyFlagsValue.Text);

            Assert.AreEqual(
                expected: "0x" + Convert.ToString((int)Keys.LControlKey, 16).PadLeft(2, '0').ToUpper(),
                actual: form.InformationLayout.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: Keys.LControlKey.ToString(),
                actual: form.InformationLayout.KeyNameValue.Text);
            Assert.AreEqual(
                expected: Convert.ToString(_altFlag, 2).PadLeft(8, '0'),
                actual: form.InformationLayout.KeyFlagsValue.Text);
        }

        [TestMethod]
        public void A060_SendKeyboardLayout_ToResetLayouts_LayoutsAreReset()
        {
            // Arrange
            var defaultColor = Color.FromArgb(0, 250, 250, 250);
            var purpleColor = ColorTranslator.FromHtml("#6c3891");
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var previousCode = form.InformationLayout.KeyCodeValue.Text = "0x41";
            var previousName = form.InformationLayout.KeyNameValue.Text = "A";
            var previousFlag = form.InformationLayout.KeyFlagsValue.Text = "00000000";
            form.KeyboardLayout.LayoutKeys
                .Select(dict => dict.Value)
                .Single(key => key.KeyCode == Keys.A)
                .BackColor = purpleColor;

            // Act
            form.InformationLayout.ResetLayouts(form.KeyboardLayout);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousCode,
                actual: form.InformationLayout.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: previousName,
                actual: form.InformationLayout.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: previousFlag,
                actual: form.InformationLayout.KeyFlagsValue.Text);
            Assert.AreNotEqual(
                notExpected: purpleColor,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);

            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationLayout.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationLayout.KeyNameValue.Text);
            Assert.AreEqual(
                expected: string.Empty,
                actual: form.InformationLayout.KeyFlagsValue.Text);
            Assert.AreEqual(
                expected: defaultColor,
                actual: form.KeyboardLayout.LayoutKeys.Select(dict => dict.Value).Single(key => key.KeyCode == Keys.A).BackColor);
        }

        [TestMethod]
        public void A070_SendNewKeyboardLayoutType_ToChangeLayout_LayoutIsChanged()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.Cherry);
            var previousKeyboardLayoutType = form.KeyboardLayout.KeyboardLayoutType;
            form.DropDownMenu.SelectedValue = KeyboardLayoutType.Toughbook;

            // Act
            form.InformationLayout.ChangeLayout(form);

            // Assert
            Assert.AreEqual(
                expected: KeyboardLayoutType.Cherry,
                actual: previousKeyboardLayoutType);
            Assert.AreEqual(
                expected: KeyboardLayoutType.Toughbook,
                actual: form.KeyboardLayout.KeyboardLayoutType);
        }
    }
}