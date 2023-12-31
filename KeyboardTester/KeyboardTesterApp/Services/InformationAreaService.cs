﻿namespace KeyboardTesterApp.Services
{
    public class InformationAreaService
    {
        public void SetTextBoxValues(InformationArea informationArea, KeyboardHookEventArgs e)
        {
            informationArea.KeyCodeValue.Text = "0x" + Convert.ToString(e.KeyCode, 16).PadLeft(2, '0').ToUpper();
            informationArea.KeyNameValue.Text = e.KeyName;
            informationArea.KeyFlagsValue.Text = Convert.ToString(e.KeyFlags, 2).PadLeft(8, '0');
        }

        public void ResetLayout(KeyboardTesterForm form)
        {
            form.InformationArea.KeyCodeValue.Text = string.Empty;
            form.InformationArea.KeyNameValue.Text = string.Empty;
            form.InformationArea.KeyFlagsValue.Text = string.Empty;

            foreach (var key in form.KeyboardLayout.LayoutKeys.Values)
            {
                key.BackColor = Resources.Colors.DefaultKeyBackground;
                key.ForeColor = Resources.Colors.Black;
                key.FlatStyle = FlatStyle.Standard;
            }
        }

        public void ShowAboutMessageBox()
        {
            var title = "About Ninc Keyboard Tester";
            var message = $"Copyright © 2023 Ninc-Consulting\nLicense: MIT\nVersion: {KeyboardTesterForm.Version}\nRuntime identifier: {RuntimeInformation.RuntimeIdentifier}\n\nSource code: https://github.com/Ninc-Consulting/ninc_keyboard_tester";
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        public void Exit(KeyboardTesterForm form)
        {
            form.Close();
        }
    }
}