using BuildManager.Commands.Base;
using BuildManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands
{
    public class BackFromAboutApplicationCommand : Command
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
                    (window as MainWindow).MainFrame.Content = new MainPage();
                }
            }
        }

        public BackFromAboutApplicationCommand()
        {
            CloseAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
