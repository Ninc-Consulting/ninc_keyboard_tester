namespace KeyboardTester.Util
{
    public static class Logger
    {
        private const string _path = @"C:\Users\Moth\source\repos";
        public static void Write(string msg)
        {
            //var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly()?.Location);
            //var path = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName;
            using StreamWriter w = File.AppendText(Path.Combine(_path, "log.txt"));
            Log(msg, w);
        }

        public static void LogKeyboardLayoutState(KeyboardLayout keyboardLayout)
        {
            //var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly()?.Location);
            //var path = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent?.FullName;
            var keyboardLayoutDto = new KeyboardLayoutDto();
            keyboardLayoutDto.Map(keyboardLayout);
            var keyboardLayoutJson = JsonConvert.SerializeObject(keyboardLayoutDto, Formatting.Indented);
            File.WriteAllText(Path.Combine(_path, "KeyboardLayoutState.txt"), keyboardLayoutJson);
        }

        public static KeyboardLayoutDto? GetKeyboardLayoutState()
        {
            var textFile = Path.Combine(_path, "KeyboardLayoutState.txt");
            if (!File.Exists(textFile))
            {
                return null;
            }

            var jsonText = File.ReadAllText(textFile);
            return JsonConvert.DeserializeObject<KeyboardLayoutDto>(jsonText);
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