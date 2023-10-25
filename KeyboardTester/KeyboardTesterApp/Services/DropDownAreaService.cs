namespace KeyboardTesterApp.Services
{
    public class DropDownAreaService
    {
        private readonly InformationAreaService _informationAreaService;

        public DropDownAreaService()
        {
            _informationAreaService = new InformationAreaService();
        }

        public void ChangeLayout(KeyboardTesterForm form)
        {
            var selectedValue = (KeyboardLayoutType)form.DropDownArea.DropDownMenu.SelectedValue;

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

            Resources.Keys.SetDefaultValues();
            form.ReInitializeComponent(selectedValue);
            _informationAreaService.ResetLayout(form);
            form.ActiveControl = null;
        }
    }
}