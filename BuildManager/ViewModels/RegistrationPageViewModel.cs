using BuildManager.Commands;
using BuildManager.Commands.RegisterPageCommand;
using BuildManager.Data.DataBase;
using BuildManager.Data.Models;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BuildManager.ViewModels
{
    public class RegistrationPageViewModel : ViewModel
    {
        public string login { get; set; } = "";
        public string password { get; set; } = "";
        public string password2 { get; set; } = "";
        public string email { get; set; } = "";

        AppDBContent DB { get; set; }



        #region Command

        public BackFromRegistrationApplicationCommand backFromRegistration { get; }

        private AddUserCommand _addCommand;
        public AddUserCommand AddCommand
        {
            get
            {
                return _addCommand ?? (new AddUserCommand(obj =>
                {
                    if (login.Length > 0 && password == password2 &&
                    email.Contains("@") && email.Contains(".") && email.Length > 0)
                    {
                        addUser();
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Something incorrect");
                    }
                }));
            }
        }

        public void addUser()
        {
            User user = new User(login, email, password);
            DB.Users.Add(user);

            DB.SaveChanges();

            MessageBoxResult result = MessageBox.Show("Register was Succeed. Don't forget you password)");

            var changePage = new ChangePage();
            changePage.ChangePageForMainWindow(new UsersCabinetPage());

        }

        #endregion

        public RegistrationPageViewModel()
        {
            backFromRegistration = new BackFromRegistrationApplicationCommand();

            DB = new AppDBContent();

        }
    }
}
