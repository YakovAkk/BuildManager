using BuildManager.Commands;
using BuildManager.Commands.LoginPageCommand;
using BuildManager.Data.DataBase;
using BuildManager.GeneralFunk;
using BuildManager.GeneralFunk.Repos;
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
                return usersBuildingObjectCabinetCommand ?? (new UsersCabinetCommand(async obj =>
                {
                    var userRep = new UserRepos();
                    var User = (await userRep.GetAll()).Where(u => u.Login == Login && u.Pass == Password).FirstOrDefault();
                    if (User != null)
                    {

                        await userRep.ChangeAllActiveFalse();
                        await userRep.ChangeActiveOnTrue(Login, Password);
                        new GenerateFunk().ChangePageForMainWindow(new UsersBildingObjectPage());
                    }
                    else
                    {
                        MessageBox.Show("Login or password incorrect");
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
