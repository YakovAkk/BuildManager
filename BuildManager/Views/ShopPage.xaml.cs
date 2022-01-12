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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for ShopMaterialPage.xaml
    /// </summary>
    public partial class ShopMaterialPage : Page
    {
        public static ListView AllMaterialsView;
        public ShopMaterialPage()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
            AllMaterialsView = ViewMaterials;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
