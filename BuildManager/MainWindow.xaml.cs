using BuildManager.Data.DataBase;
using BuildManager.Views;
using System.Windows;

namespace BuildManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new MainPage();


            //DataForDatabase db = new DataForDatabase();

            //db.AddData();
        }
    }
}
