using BuildManager.Commands.Base;
using BuildManager.GeneralFunk;
using BuildManager.Views;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands
{
    public class LoginApplicationCommand : Command
    {
        public ICommand AppCommand { get; }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var changePage = new ChangePage();
            changePage.ChangePageForMainWindow(new LoginPage());
        }

        public LoginApplicationCommand()
        {
            AppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
