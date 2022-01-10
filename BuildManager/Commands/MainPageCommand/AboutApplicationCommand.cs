using BuildManager.Commands.Base;
using BuildManager.GeneralFunk;
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
            var changePage = new GenerateFunk();
            changePage.ChangePageForMainWindow(new AboutPage());
        }

        public AboutApplicationCommand()
        {
            AboutAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
