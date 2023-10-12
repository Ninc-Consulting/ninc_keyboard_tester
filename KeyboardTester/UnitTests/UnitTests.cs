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

        [TestMethod]
        public void A010_SendKeyDownA_ToKeyEvent_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.A);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A020_SendKeyUpA_ToKeyEvent_BorderColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.A);
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void A030_SendKeyDownLControlWithAltFlag_ToKeyEvent_BackColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A040_SendKeyUpLControlWithAltFlag_ToKeyEvent_BorderColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);

            // Send AltGr to store as latest key down value
            var altGr = form.KeyboardLayout.LayoutKeys
               .Select(x => x.Value)
               .Single(x => x.KeyCode == Keys.RMenu);
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, altGr.KeyCodeValue, _altFlag);
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Send left control key up
            var leftControlKey = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var previousBorderColor = leftControlKey.FlatAppearance.BorderColor;
            keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, leftControlKey.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBorderColor,
                actual: leftControlKey.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void A050_SendKeyDownDeleteWithExtendedFlag_ToKeyEvent_BackColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _extendedFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A060_SendKeyUpDeleteWithExtendedFlag_ToKeyEvent_BorderColorChanges()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _extendedFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void A070_SendKeyDownDeleteWithoutExtendedFlag_ToKeyEvent_BackColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBackColor = key.BackColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBackColor,
                actual: key.BackColor);
        }

        [TestMethod]
        public void A080_SendKeyUpDeleteWithoutExtendedFlag_ToKeyEvent_BorderColorDoesNotChange()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.Delete);
            var previousBorderColor = key.FlatAppearance.BorderColor;
            var keyEventArgs = new KeyboardHookEventArgs(_keyUpEvent, key.KeyCodeValue, _noFlag);

            // Act
            form.KeyboardLayout.KeyEvent(keyEventArgs);

            // Assert
            Assert.AreEqual(
                expected: previousBorderColor,
                actual: key.FlatAppearance.BorderColor);
        }

        [TestMethod]
        public void A090_SendKeyDownControlWithAltFlag_ToSetTextBoxValues_TextChangesToCorrectValues()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
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
        public void A100_SendKeyboardLayout_ToResetLayouts_LayoutsAreReset()
        {
            // Arrange
            var defaultColor = SystemColors.ControlLight;
            var purpleColor = ColorTranslator.FromHtml("#6c3891");
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
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
        public void A110_SendNewKeyboardLayoutType_ToChangeLayout_LayoutIsChanged()
        {
            // Arrange
            var form = new KeyboardTesterForm(KeyboardLayoutType.ISO_105);
            var previousKeyboardLayoutType = form.KeyboardLayout.KeyboardLayoutType;
            form.DropDownMenu.SelectedValue = KeyboardLayoutType.AllKeys;

            // Act
            form.InformationLayout.ChangeLayout(form);

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