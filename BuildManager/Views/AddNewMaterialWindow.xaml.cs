using BuildManager.ViewModels;
using System.Windows;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for AddNewMaterialWindow.xaml
    /// </summary>
    public partial class AddNewMaterialWindow : Window
    {
        public AddNewMaterialWindow()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
        }
    }
}
