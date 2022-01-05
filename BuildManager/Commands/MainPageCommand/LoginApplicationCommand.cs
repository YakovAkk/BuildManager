using BuildManager.Commands.Base;
using BuildManager.Views;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands
{
    public class LoginApplicationCommand : Command
    {
        public ICommand CloseAppCommand { get; }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new LoginPage();
                }
            }
        }

        public LoginApplicationCommand()
        {
            CloseAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
