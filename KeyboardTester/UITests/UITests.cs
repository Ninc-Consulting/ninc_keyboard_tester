namespace UITests
{
    [TestClass]
    public class UITests : TestSession
    {
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
            Setup();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            TearDown();
        }

        [TestMethod]
        public void UI010_ChangeLayout_ToAllKeys_LayoutIsChanged()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var initialKeyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(initialKeyboardLayoutDto);

            // Act
            var comboBoxElement = Session.FindElementByAccessibilityId("DropDownMenu");
            comboBoxElement.Click();
            comboBoxElement.FindElementByName("All Keys").Click();
            Thread.Sleep(500);

            // Assert
            var currentKeyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(currentKeyboardLayoutDto);
            Assert.AreEqual(
                expected: KeyboardLayoutType.AllKeys,
                actual: currentKeyboardLayoutDto.KeyboardLayoutType,
                message: "The layout should have changed to 'All Keys'!");
            Assert.AreNotEqual(
                notExpected: initialKeyboardLayoutDto.KeyboardLayoutType,
                actual: currentKeyboardLayoutDto.KeyboardLayoutType,
                message: "The layout was already 'All Keys' at the start of the test!");
        }

        [TestMethod]
        public void UI020_ClickResetButton_TextBoxesAreReset()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var keyCodeValueElement = Session.FindElementByAccessibilityId("KeyCodeValue");
            var keyNameValueElement = Session.FindElementByAccessibilityId("KeyNameValue");
            var keyFlagValueElement = Session.FindElementByAccessibilityId("KeyFlagsValue");
            var resetButtonElement = Session.FindElementByAccessibilityId("ResetButton");

            SendKeyAsKeyDownAndKeyUp(Keys.B);

            Assert.IsFalse(string.IsNullOrEmpty(keyCodeValueElement.Text));
            Assert.IsFalse(string.IsNullOrEmpty(keyNameValueElement.Text));
            Assert.IsFalse(string.IsNullOrEmpty(keyFlagValueElement.Text));

            // Act
            resetButtonElement.Click();

            // Assert
            Assert.IsTrue(string.IsNullOrEmpty(keyCodeValueElement.Text));
            Assert.IsTrue(string.IsNullOrEmpty(keyNameValueElement.Text));
            Assert.IsTrue(string.IsNullOrEmpty(keyFlagValueElement.Text));
        }

        [TestMethod]
        [DataRow(Keys.A, 0)]
        [DataRow(Keys.B, 0)]
        [DataRow(Keys.C, 0)]
        [DataRow(Keys.D, 0)]
        [DataRow(Keys.E, 0)]
        public void UI030_InCherryLayout_PressAndReleaseKey_BackColorAndBorderColorIsCorrect(Keys key, int flags)
        {
            // Arrange
            Assert.IsNotNull(Session);

            // Act
            SendKeyAsKeyDownAndKeyUp(key, flags);

            // Assert
            var keyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(keyboardLayoutDto);

            var keyDto = keyboardLayoutDto.LayoutKeys.Single(keyDto => keyDto.KeyCode == key);
            Assert.AreEqual(
                expected: Resources.Colors.NincPurple,
                actual: keyDto.BackColor,
                message: $"Input:<{key}>");
            Assert.AreEqual(
                expected: Resources.Colors.Red,
                actual: keyDto.BorderColor,
                message: $"Input:<{key}>");
        }

        private static KeyboardLayoutDto? GetKeyboardLayoutState()
        {
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KeyboardTester");
            Directory.CreateDirectory(folderPath);
            var filePath = Path.Combine(folderPath, "KeyboardLayoutState.txt");
            if (!File.Exists(filePath))
            {
                return null;
            }

            var jsonText = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<KeyboardLayoutDto>(jsonText);
        }

        private void SendKeyAsKeyDownAndKeyUp(Keys key, int flags = 0)
        {
            SendKeyboardInput(
               new KeyboardInput[]
               {
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                        DwFlags = (uint)flags
                    },
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                        DwFlags = (uint)flags | (uint)KeyEventF.KeyUp
                    }
               });
        }
    }
}