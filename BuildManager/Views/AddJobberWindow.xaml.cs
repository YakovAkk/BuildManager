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
    /// Interaction logic for AddJobberWindow.xaml
    /// </summary>
    public partial class AddJobberWindow : Window
    {
        public AddJobberWindow()
        {
            InitializeComponent();
            DataContext = new AddJobberViewModel();
        }
        public void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
