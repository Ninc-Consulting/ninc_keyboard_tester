using KeyboardTester;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private const int _keyDownEvent = 0x0100;

        private const int _extendedFlag = 0b1;
        private const int _altFlag = 0b100000;
        private const int _noFlag = 0;

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
            Assert.AreNotEqual(previousBackColor, key.BackColor);
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
            Assert.AreEqual(previousBackColor, key.BackColor);
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
            Assert.AreNotEqual(previousBackColor, key.BackColor);
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
            Assert.AreEqual(previousBackColor, key.BackColor);
        }
    }
}