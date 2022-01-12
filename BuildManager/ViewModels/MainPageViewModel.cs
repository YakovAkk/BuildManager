using BuildManager.Commands;
using BuildManager.ViewModels.Base;

namespace BuildManager.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        #region Command
        public LoginApplicationCommand LoginAppCommand { get; }
        public CloseApplicationCommand CloseAppCommand { get; }
        public AboutApplicationCommand AboutAppCommand { get; }
        #endregion

        public MainPageViewModel()
        {
            AboutAppCommand = new AboutApplicationCommand();
            CloseAppCommand = new CloseApplicationCommand();
            LoginAppCommand = new LoginApplicationCommand();
        }
    }
}
