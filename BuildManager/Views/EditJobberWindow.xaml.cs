using BuildManager.Data.Models;
using BuildManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using System.Windows.Shapes;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for EditJobberWindow.xaml
    /// </summary>
    public partial class EditJobberWindow : Window
    {
        public EditJobberWindow(JobPerson jobberToEdit)
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
            ShopViewModel.SelectedJobber = jobberToEdit;
            ShopViewModel.JobberName = jobberToEdit.name;
            ShopViewModel.JobberSurname = jobberToEdit.Surname;
            ShopViewModel.JobberPhone = jobberToEdit.Phone;
        }
    }
}
