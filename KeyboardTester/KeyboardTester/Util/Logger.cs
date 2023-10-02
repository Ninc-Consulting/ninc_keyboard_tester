namespace KeyboardTester.Util
{
    public static class Logger
    {
        public static void Write(string msg)
        {
            //var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly()?.Location);
            //var path = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName;
            const string path = @"C:\Users\Moth\source\repos";
            using StreamWriter w = File.AppendText(Path.Combine(path, "log.txt"));
            Log(msg, w);
        }

        private static void Log(string msg, TextWriter w)
        {
            w.Write(Environment.NewLine);
            w.Write("[{0} {1}]", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.Write("\t");
            w.WriteLine(" {0}", msg);
            w.WriteLine("-----------------------");
        }
    }
}
