namespace KeyboardTester.Services
{
    public class DropDownMenuService
    {
        private readonly InformationBoxService _informationBoxService;

        public DropDownMenuService()
        {
            _informationBoxService = new InformationBoxService();
        }

        public void ChangeLayout(KeyboardTesterForm form)
        {
            var selectedValue = (KeyboardLayoutType)form.DropDownMenu.SelectedValue;

            if (selectedValue == KeyboardLayoutType.None)
            {
                return;
            }

            foreach (var keyControl in form.Controls.OfType<Button>().ToList())
            {
                form.Controls.Remove(keyControl);
            }

            foreach (var textBoxControl in form.Controls.OfType<TextBox>().ToList())
            {
                form.Controls.Remove(textBoxControl);
            }

            KeyResource.SetDefaultTextValues();
            form.ReInitializeComponent(selectedValue);
            _informationBoxService.ResetLayout(form);
            form.ActiveControl = null;
        }
    }
}
