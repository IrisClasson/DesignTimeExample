using Windows.UI;

namespace DesignTimeExample.ViewModels
{
    public class OtherViewModel:IViewModel
    {
        public string Data { get; private set; }
        public string Color { get; private set; }

        public OtherViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                SetData("Fake data", "#FF00D0");
            else
                SetData("Real data", "#5EFF00");
        }

        // Abstract away with interface and use IoC to deliver right data
        void SetData(string str, string color)
        {
            Data = str;
            Color = color;
        }
    }
}
