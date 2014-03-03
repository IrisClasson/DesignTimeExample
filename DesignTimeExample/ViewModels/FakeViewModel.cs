using Windows.UI;

namespace DesignTimeExample.ViewModels
{
    public class FakeViewModel : IViewModel
    {
        public string Data
        {
            get { return "Fake data"; }
        }

        public string Color
        {
            get { return "#FF00D0"; }
        }
    }
}

