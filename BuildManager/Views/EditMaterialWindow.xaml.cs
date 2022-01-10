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
    /// Interaction logic for EditMaterialWindow.xaml
    /// </summary>
    public partial class EditMaterialWindow : Window
    {
        public EditMaterialWindow(Material materialToEdit)
        {
            InitializeComponent();

            DataContext = new ShopViewModel();

            ShopViewModel.SelectedMaterial = materialToEdit;
            ShopViewModel.materialName = materialToEdit.name;
            ShopViewModel.materialPrice = materialToEdit.price; 
            ShopViewModel.materialMesurableValue = materialToEdit.mesurableValue;

        }
    }
}
