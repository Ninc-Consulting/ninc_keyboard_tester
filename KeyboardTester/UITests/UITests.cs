namespace UITests
{
    [TestClass]
    public class UITests : TestSession
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Setup();

            var messageDialogs = Session?.FindElementsByName("Key not found!");
            if (messageDialogs != null && messageDialogs.Any())
            {
                foreach (var messageDialog in messageDialogs)
                {
                    var okButton = messageDialog.FindElementsByName("OK").Single();
                    okButton.Click();
                }
            }
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            TearDown();

            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KeyboardTester");
            var file = Path.Combine(folderPath, "KeyboardLayoutState.txt");
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        [TestMethod]
        public void A010_ChangeLayout_WithDropDownMenu()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var numPad5CountBefore = Session.FindElementsByAccessibilityId("NumPad5").Count;

            // Act
            var comboBoxElement = Session.FindElementByAccessibilityId("DropDownMenu");
            comboBoxElement.Click();
            comboBoxElement.FindElementByName("Keyboard layout: 'Cherry'").Click();

            // Assert
            Assert.AreEqual(
                expected: 1,
                actual: Session.FindElementsByAccessibilityId("NumPad5").Count,
                message: "Could not find NumPad5. The layout has not changed!");
            Assert.AreEqual(
                expected: 0,
                actual: numPad5CountBefore,
                message: "NumPad5 should not be found before the layout is changed!");
        }

        [TestMethod]
        public void A020_InCherryLayout_PressAndReleaseKeyA_BackColorIsPurple()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var comboBoxElement = Session.FindElementByAccessibilityId("DropDownMenu");
            comboBoxElement.Click();
            comboBoxElement.FindElementByName("Keyboard layout: 'Cherry'").Click();
            var key = Keys.A;

            var keyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNull(keyboardLayoutDto);

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
            keyboardLayoutDto = GetKeyboardLayoutState();
            Assert.IsNotNull(keyboardLayoutDto);
            Assert.AreEqual("ff6c3891", keyboardLayoutDto.LayoutKeys.Single(keyDto => keyDto.KeyCode == key).BackColor.Name);
        }

        [TestMethod]
        public void A030_ClickResetButton_TextBoxesAreReset()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var keyCodeValueElement = Session.FindElementByAccessibilityId("KeyCodeValue");
            var keyNameValueElement = Session.FindElementByAccessibilityId("KeyNameValue");
            var keyFlagValueElement = Session.FindElementByAccessibilityId("KeyFlagsValue");
            var resetButtonElement = Session.FindElementByAccessibilityId("ResetButton");

            Logger.Write("before key stroke: " + keyCodeValueElement.Text);

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

            Logger.Write("after key stroke: " + keyCodeValueElement.Text);

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