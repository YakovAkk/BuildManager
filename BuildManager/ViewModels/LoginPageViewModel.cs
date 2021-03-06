using BuildManager.Commands;
using BuildManager.Commands.LoginPageCommand;
using BuildManager.Data.DataBase;
using BuildManager.GeneralFunk;
using BuildManager.GeneralFunk.Repos;
using BuildManager.GeneralFunk.SingletonForActiveUser;
using BuildManager.ViewModels.Base;
using BuildManager.Views;
using System.Linq;
using System.Windows;

namespace BuildManager.ViewModels
{
    public class LoginPageViewModel : ViewModel
    {
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";

        #region Command
        public BackFromLoginApplicationCommand backFromLoginApplicationCommand { get; }
        public RegisterApplicationCommand registerAppCommand { get; }

        private UsersCabinetCommand usersBuildingObjectCabinetCommand { get; }

        public UsersCabinetCommand UsersBuildingObjectCabinetCommand
        {
            get
            {
                return usersBuildingObjectCabinetCommand ?? (new UsersCabinetCommand(obj =>
                {
                    bool flag = false;
                    using (AppDBContent DB = new AppDBContent())
                    {
                        var User = DB.Users.Where(u => u.Login == Login && u.Pass == Password).FirstOrDefault();
                        if (User != null)
                        {
                            SingletonActiveUser.GetInstance().SetUser(User);
                            new GenerateFunk().ChangePageForMainWindow(new UsersBildingObjectPage());
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Login or password incorrect");
                        }
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
