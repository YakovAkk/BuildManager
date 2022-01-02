using BuildManager.Commands.Base;
using BuildManager.Views;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands
{
    public class AboutApplicationCommand : Command
    {
        public ICommand AboutAppCommand { get; }
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
                    (window as MainWindow).MainFrame.Content = new AboutPage();
                }
            }
        }

        public AboutApplicationCommand()
        {
            AboutAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
