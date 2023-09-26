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
        public void SendA_ToKeyDownEvent_ReturnsTrue()
        {
            // Arrange
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, (int)Keys.A, _noFlag);
            var keyboardLayout = new CherryKeyboardLayout(100);

            // Act
            var result = keyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SendLControlWithAltFlag_ToKeyDownEvent_ReturnsFalse()
        {
            // Arrange
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, (int)Keys.LControlKey, _altFlag);
            var keyboardLayout = new CherryKeyboardLayout(100);

            // Act
            var result = keyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        [DataRow(_extendedFlag, true)]
        [DataRow(_noFlag, false)]
        public void SendDeleteWithAndWithoutExtendedFlag_ToKeyDownEvent_ReturnCorrectResult(byte flag, bool expectedResult)
        {
            // Arrange
            var keyEventArgs = new KeyboardHookEventArgs(_keyDownEvent, (int)Keys.Delete, flag);
            var keyboardLayout = new CherryKeyboardLayout(100);

            // Act
            var result = keyboardLayout.KeyDownEvent(keyEventArgs);

            // Assert
            Assert.IsTrue(expectedResult == result);
        }
    }
}