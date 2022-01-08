using BuildManager.Commands;
using BuildManager.Commands.LoginPageCommand;
using BuildManager.Data.DataBase;
using BuildManager.GeneralFunk;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Linq;
using System.Windows;

namespace BuildManager.ViewModels
{
    public class LoginPageViewModel : ViewModel
    {
        private AppDBContent DB { get; }

        public string Login { get; set; }
        public string Password { get; set; }

        #region Command
        public BackFromLoginApplicationCommand backFromLoginApplicationCommand { get; }
        public RegisterApplicationCommand registerAppCommand { get; }

        private UsersCabinetCommand usersCabinetCommand { get; }

        public UsersCabinetCommand UsersCabinetCommand
        {
            get
            {
                return usersCabinetCommand ?? (new UsersCabinetCommand(obj =>
                {
                    var Users = DB.Users;
                    var User = Users.Where(u => u.login == Login && u.pass == Password).FirstOrDefault();
                    if(User != null)
                    {
                        var changePage = new ChangePage();
                        changePage.ChangePageForMainWindow(new UsersCabinetPage());
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Login or password incorrect");
                    }
                }));
            }
        }

        #endregion

        public LoginPageViewModel()
        {
            backFromLoginApplicationCommand = new BackFromLoginApplicationCommand();
            registerAppCommand = new RegisterApplicationCommand();
            DB = new AppDBContent();
        }
    }
}
