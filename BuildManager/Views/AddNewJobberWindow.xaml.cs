using BuildManager.ViewModels;
using System.Windows;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for AddNewJobberWindow.xaml
    /// </summary>
    public partial class AddNewJobberWindow : Window
    {
        public AddNewJobberWindow()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
        }
    }
}
