namespace UITests
{
    public class TestSession
    {
        protected static WindowsDriver<WindowsElement>? Session { get; private set; }

        private const string _windowsApplicationDriverUrl = "http://127.0.0.1:4723";

        protected TestSession()
        {
        }

        protected static void Setup()
        {
            if (Session == null)
            {
                TearDown();

                var solutionDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName;
                if (!Directory.Exists(solutionDirectory))
                {
                    return;
                }

                var testApp = $@"{solutionDirectory}/KeyboardTesterApp/bin/Debug/net6.0-windows/KeyboardTesterApp.exe";
                if (!File.Exists(testApp))
                {
                    return;
                }

                var options = new AppiumOptions();
                options.AddAdditionalCapability("app", testApp);
                options.AddAdditionalCapability("deviceName", "WindowsPC");
                options.AddAdditionalCapability("platformName", "Windows");

                Session = new WindowsDriver<WindowsElement>(new Uri(_windowsApplicationDriverUrl), options);
                Assert.IsNotNull(Session);
                Assert.IsNotNull(Session.SessionId);

                // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
                Session.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);
            }
        }

        protected static void TearDown()
        {
            if (Session != null)
            {
                Session.Quit();
                Session = null;
            }
        }
    }
}