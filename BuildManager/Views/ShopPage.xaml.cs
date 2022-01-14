using BuildManager.ViewModels;
using System.Windows.Controls;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for ShopMaterialPage.xaml
    /// </summary>
    public partial class ShopMaterialPage : Page
    {
        public static ListView AllMaterialsView;
        public static ListView AllJobbersView;
        public ShopMaterialPage()
        {
            InitializeComponent();
            DataContext = new ShopViewModel();
            AllMaterialsView = ViewMaterials;
            AllJobbersView = ViewJobbers;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
