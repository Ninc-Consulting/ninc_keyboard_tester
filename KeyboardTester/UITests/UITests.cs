namespace UITests
{
    [TestClass]
    public class UITests : TestSession
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
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
    }
}