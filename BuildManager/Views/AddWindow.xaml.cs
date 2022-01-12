using BuildManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BuildManager.Views;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
            DataContext = new AddWindowViewModel();
        }

        public void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
