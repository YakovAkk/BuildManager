using BuildManager.Commands.Base;
using BuildManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands.LoginPageCommand
{
    public class RegisterApplicationCommand : Command
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
                    (window as MainWindow).MainFrame.Content = new Registration();
                }
            }
        }

        public RegisterApplicationCommand()
        {
            CloseAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
