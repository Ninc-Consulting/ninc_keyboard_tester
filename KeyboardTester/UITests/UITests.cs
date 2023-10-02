namespace UITests
{
    [TestClass]
    public class UITests : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        //[TestInitialize]
        //public void TestInitialize()
        //{
        //    Assert.IsNotNull(Session);
        //    var okButtons = Session.FindElementsByAccessibilityId("2");
        //    foreach (var button in okButtons)
        //    {
        //        button.Click();
        //    }
        //}

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
        public void A020_PressAndReleaseAllKeysInCherryLayout()
        {
            // Arrange
            Assert.IsNotNull(Session);
            var tempForm = new KeyboardTesterForm(KeyboardLayoutType.Toughbook);
            var extendedKeys = new List<int>()
            {
                (int)Keys.Home,
                (int)Keys.PageUp,
                (int)Keys.PageDown,
                (int)Keys.End,
                (int)Keys.Insert,
                (int)Keys.Delete,
                (int)Keys.Up,
                (int)Keys.Left,
                (int)Keys.Down,
                (int)Keys.Right
            };

            var comboBoxElement = Session.FindElementByAccessibilityId("DropDownMenu");
            comboBoxElement.Click();
            comboBoxElement.FindElementByName("Keyboard layout: 'Toughbook'").Click();
            Thread.Sleep(500);

            // Act
            foreach (var key in tempForm.KeyboardLayout.LayoutKeys.Values)
            {
                if (key.Name == "Fn")
                {
                    continue;
                }

                InputSender.SendKeyboardInput(
                    new InputSender.KeyboardInput[]
                    {
                        new InputSender.KeyboardInput
                        {
                            wVk = (ushort)key.KeyCode,
                            dwFlags = extendedKeys.Contains(key.KeyCodeValue) ? (uint)KeyEventF.ExtendedKey : 0
                        },
                        new InputSender.KeyboardInput
                        {
                            wVk = (ushort)key.KeyCode,
                            dwFlags = extendedKeys.Contains(key.KeyCodeValue) ? (uint)(KeyEventF.KeyUp | KeyEventF.ExtendedKey) : (uint)KeyEventF.KeyUp
                        }
                    });
                if (key.KeyCode == Keys.NumLock)
                {
                    InputSender.SendKeyboardInput(
                    new InputSender.KeyboardInput[]
                    {
                        new InputSender.KeyboardInput
                        {
                            wVk = (ushort)key.KeyCode
                        },
                        new InputSender.KeyboardInput
                        {
                            wVk = (ushort)key.KeyCode,
                            dwFlags = (uint)KeyEventF.KeyUp
                        }
                    });
                }

                Thread.Sleep(20);
            }

            Thread.Sleep(500);

            // Assert
        }
    }
}