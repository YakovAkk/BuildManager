using BuildManager.Commands;
using BuildManager.Commands.LoginPageCommand;
using BuildManager.ViewModels.Base;


namespace BuildManager.ViewModels
{
    public class LoginPageViewModel : ViewModel
    {
        #region Command
        public BackFromLoginApplicationCommand backFromLoginApplicationCommand { get; }
        public RegisterApplicationCommand registerAppCommand { get; }
        #endregion

        public LoginPageViewModel()
        {
            backFromLoginApplicationCommand = new BackFromLoginApplicationCommand();
            registerAppCommand = new RegisterApplicationCommand();
        }
    }
}
