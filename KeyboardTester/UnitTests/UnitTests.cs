using KeyboardTester.Util;

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
            var form = new KeyboardTesterForm(KeyboarLayoutType.Cherry);
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
            var form = new KeyboardTesterForm(KeyboarLayoutType.Cherry);
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
            var form = new KeyboardTesterForm(KeyboarLayoutType.Cherry);
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
            var form = new KeyboardTesterForm(KeyboarLayoutType.Cherry);
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
            var form = new KeyboardTesterForm(KeyboarLayoutType.Cherry);
            var key = form.KeyboardLayout.LayoutKeys
                .Select(x => x.Value)
                .Single(x => x.KeyCode == Keys.LControlKey);
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, key.KeyCodeValue, _altFlag);
            var initialKeyCode = form.TextLayout.KeyCodeValue.Text;
            var initialKeyName = form.TextLayout.KeyNameValue.Text;
            var initialKeyFlags = form.TextLayout.KeyFlagValue.Text;

            // Act
            form.TextLayout.SetTextBoxValues(keyEventArgs);

            // Assert
            Assert.AreNotEqual(
                notExpected: initialKeyCode,
                actual: form.TextLayout.KeyCodeValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyName,
                actual: form.TextLayout.KeyNameValue.Text);
            Assert.AreNotEqual(
                notExpected: initialKeyFlags,
                actual: form.TextLayout.KeyFlagValue.Text);

            Assert.AreEqual(
                expected: "0x" + Convert.ToString((int)Keys.LControlKey, 16).PadLeft(2, '0').ToUpper(),
                actual: form.TextLayout.KeyCodeValue.Text);
            Assert.AreEqual(
                expected: Keys.LControlKey.ToString(),
                actual: form.TextLayout.KeyNameValue.Text);
            Assert.AreEqual(
                expected: Convert.ToString(_altFlag, 2).PadLeft(8, '0'),
                actual: form.TextLayout.KeyFlagValue.Text);
        }
    }
}