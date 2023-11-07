namespace KeyboardTesterApp.Util
{
    public static class Logger
    {
        public static void Write(string msg)
        {
            var file = GetFullFilePath("log.txt");
            using StreamWriter w = File.AppendText(file);
            Log(msg, w);
        }

        public static void LogKeyboardLayoutState(KeyboardLayout keyboardLayout)
        {
            var filePath = GetFullFilePath("KeyboardLayoutState.txt");
            var keyboardLayoutDto = new KeyboardLayoutDto();
            keyboardLayoutDto.Map(keyboardLayout);
            var keyboardLayoutJson = JsonConvert.SerializeObject(keyboardLayoutDto, Formatting.Indented);
            File.WriteAllText(filePath, keyboardLayoutJson);
        }

        private static void Log(string msg, TextWriter w)
        {
            w.Write(Environment.NewLine);
            w.Write("[{0} {1}]", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            w.Write("\t");
            w.WriteLine(" {0}", msg);
            w.WriteLine("-----------------------");
        }

        private static string GetFullFilePath(string fileName)
        {
            var folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "KeyboardTester");
            Directory.CreateDirectory(folderPath);
            return Path.Combine(folderPath, fileName);
        }
    }
}