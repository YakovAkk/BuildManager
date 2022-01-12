using BuildManager.Data.Models;
using BuildManager.ViewModels;
using System.Windows.Controls;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for UsersItemPage.xaml
    /// </summary>
    public partial class UsersItemPage : Page
    {
        private Material materialToEdit;

        public UsersItemPage()
        {
            InitializeComponent();
            DataContext = new UsersItemViewModel();
        }
    }
}
