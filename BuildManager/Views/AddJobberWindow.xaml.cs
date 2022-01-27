using BuildManager.ViewModels;
using System;
using System.Windows;

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
            DataContext = StaticViewModel.GetInstance();
            StaticViewModel.GetInstance().SalaryJobber = "1";
        }
        public void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
