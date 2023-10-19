namespace KeyboardTesterApp.Services
{
    public class InformationBoxService
    {
        public void SetTextBoxValues(InformationBox informationBox, KeyboardHookEventArgs e)
        {
            informationBox.KeyCodeValue.Text = "0x" + Convert.ToString(e.KeyCode, 16).PadLeft(2, '0').ToUpper();
            informationBox.KeyNameValue.Text = e.KeyName;
            informationBox.KeyFlagsValue.Text = Convert.ToString(e.KeyFlags, 2).PadLeft(8, '0');
        }

        public void ResetLayout(KeyboardTesterForm form)
        {
            form.InformationBox.KeyCodeValue.Text = string.Empty;
            form.InformationBox.KeyNameValue.Text = string.Empty;
            form.InformationBox.KeyFlagsValue.Text = string.Empty;

            foreach (var key in form.KeyboardLayout.LayoutKeys.Values)
            {
                key.BackColor = Resources.Colors.DefaultKeyBackground;
                key.ForeColor = Resources.Colors.Black;
                key.FlatStyle = FlatStyle.Standard;
            }
        }

        public void Exit(KeyboardTesterForm form)
        {
            form.Close();
        }
    }
}