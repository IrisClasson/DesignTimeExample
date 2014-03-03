using DesignTimeExample.ViewModels;

namespace DesignTimeExample
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }
}
