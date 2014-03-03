namespace DesignTimeExample.ViewModels
{
    public class Locator
    {
        public IViewModel ViewModel { get; set; }

        public Locator()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                ViewModel = new FakeViewModel();
            else
                ViewModel = new ViewModel();
        }
    }
}
