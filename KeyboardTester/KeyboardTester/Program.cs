namespace KeyboardTester
{
    internal static class Program
    {
        // Using a custom keyboard hook to trap keystrokes before any other application can process them since the .NET Framework is anable to do so.
        // This prevents, for example, the windows menu to open when the windows key is spressed.
        public static KeyboardHook? KeyboardHook { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledExceptionHandler);
            using (KeyboardHook = new KeyboardHook())
            {
                Application.Run(new KeyboardTesterForm());
            }
        }

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            Logger.Write($"ERROR: {exception.Message}");

            // Asks the user if they want to restart the application when an unhandled exception has been thrown
            var caption = "Fatal error!";
            var message = $"{exception.Message}\n\nThe application is shutting down, do you want to restart the application?";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}