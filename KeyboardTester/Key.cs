namespace KeyboardTester
{
    public class Key : Button
    {
        public Key(int keyValue = 0, string keyCode = "", string keyData = "")
        {
            KeyValue = keyValue;
            KeyCode = keyCode;
            KeyData = keyData;
        }
        public int KeyValue { get; set; }
        public string KeyCode { get; set; }
        public string KeyData { get; set; }
    }
}