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
        public void A010_ChangeLayout_WithDropDownMenu_LayoutIsChanged()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var key = Keys.Space;

            // Send key to create file for initial KeyboardState
            SendKeyboardInput(
                new KeyboardInput[]
                {
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                    },
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                        DwFlags = (uint)KeyEventF.KeyUp
                    }
                });
            var initialKeyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(initialKeyboardLayoutDto);

            // Act
            var comboBoxElement = Session.FindElementByAccessibilityId("DropDownMenu");
            comboBoxElement.Click();
            comboBoxElement.FindElementByName("Keyboard layout: 'All Keys'").Click();

            // Send key to update file with current KeyboardState
            SendKeyboardInput(
                new KeyboardInput[]
                {
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                    },
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                        DwFlags = (uint)KeyEventF.KeyUp
                    }
                });

            // Assert
            var currentKeyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(currentKeyboardLayoutDto);
            Assert.AreNotEqual(
                notExpected: initialKeyboardLayoutDto.KeyboardLayoutType,
                actual: currentKeyboardLayoutDto.KeyboardLayoutType,
                message: "The layout has not changed!");
        }

        [TestMethod]
        public void A020_ClickResetButton_TextBoxesAreReset()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var keyCodeValueElement = Session.FindElementByAccessibilityId("KeyCodeValue");
            var keyNameValueElement = Session.FindElementByAccessibilityId("KeyNameValue");
            var keyFlagValueElement = Session.FindElementByAccessibilityId("KeyFlagsValue");
            var resetButtonElement = Session.FindElementByAccessibilityId("ResetButton");

            SendKeyboardInput(
                new KeyboardInput[]
                {
                    new KeyboardInput
                    {
                        Wvk = (ushort)Keys.B,
                    },
                    new KeyboardInput
                    {
                        Wvk = (ushort)Keys.B,
                        DwFlags = (uint)KeyEventF.KeyUp
                    }
                });

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
        [DataRow(Keys.A)]
        [DataRow(Keys.B)]
        [DataRow(Keys.C)]
        [DataRow(Keys.D)]
        [DataRow(Keys.E)]
        public void A030_InCherryLayout_PressAndReleaseKey_BackColorAndBorderColorIsCorrect(Keys key)
        {
            // Arrange
            Assert.IsNotNull(Session);

            // Act
            SendKeyboardInput(
                new KeyboardInput[]
                {
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                    },
                    new KeyboardInput
                    {
                        Wvk = (ushort)key,
                        DwFlags = (uint)KeyEventF.KeyUp
                    }
                });

            // Assert
            var keyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(keyboardLayoutDto);

            var keyDto = keyboardLayoutDto.LayoutKeys.Single(keyDto => keyDto.KeyCode == key);
            Assert.AreEqual(
                expected: "ff6c3891",
                actual: keyDto.BackColor.Name,
                message: $"Input:<{key}>");
            Assert.AreEqual(
                expected: Color.Red,
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
    }
}