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
        

        public static string UsersLogin { get; set; }
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
                    bool flag = false;
                    using(AppDBContent DB = new AppDBContent())
                    {
                        var Users = DB.Users;
                        var User = Users.Where(u => u.login == Login && u.pass == Password).FirstOrDefault();
                        if (User != null)
                        {
                            UsersLogin = Login;
                            flag = true;
                        }
                    }

                    if (flag)
                    {
                        var changePage = new GenerateFunk();
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
        }
    }
}
