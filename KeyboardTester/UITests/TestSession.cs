namespace UITests
{
    public class TestSession
    {
        public static WindowsDriver<WindowsElement>? DesktopSession { get; private set; }

        protected static WindowsDriver<WindowsElement>? Session { get; private set; }

        private const string _windowsApplicationDriverUrl = "http://127.0.0.1:4723";

        protected TestSession()
        {
        }

        public static void Setup(TestContext context)
        {
            // Launch application if it is not yet launched
            if (Session == null || DesktopSession == null)
            {
                TearDown();

                var testApp = @$"C:\Users\{Environment.UserName}\source\repos\ninc_keyboard_tester\KeyboardTester\KeyboardTester\bin\Debug\net6.0-windows\KeyboardTester.exe";

                // Create a new session to bring up the test application
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalCapability("app", testApp);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                options.AddAdditionalCapability("platformName", "Windows");

                Session = new WindowsDriver<WindowsElement>(new Uri(_windowsApplicationDriverUrl), options);
                Assert.IsNotNull(Session);
                Assert.IsNotNull(Session.SessionId);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                Session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", "Root");
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                appiumOptions.AddAdditionalCapability("ms:experimental-webdriver", true);
                DesktopSession = new WindowsDriver<WindowsElement>(new Uri(_windowsApplicationDriverUrl), appiumOptions);
            }
        }

        public static void TearDown()
        {
            if (Session != null)
            {
                Session.Quit();
                Session = null;
            }

            if (DesktopSession != null)
            {
                DesktopSession.Quit();
                DesktopSession = null;
            }
        }
    }
}
