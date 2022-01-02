using BuildManager.ViewModels;
using System.Windows.Controls;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
            DataContext = new AboutPageViewModel();
        }
    }
}
