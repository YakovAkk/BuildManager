using BuildManager.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BuildManager.Views
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
            DataContext = new RegistrationPageViewModel();

            //textPass.Password.ToString();
            //textPass2.Password.ToString();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).password = ((PasswordBox)sender).Password; }
        }

        private void PasswordBox_PasswordChanged2(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).password2 = ((PasswordBox)sender).Password; }
        }
    }
}
