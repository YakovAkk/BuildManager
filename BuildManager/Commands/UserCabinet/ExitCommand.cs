using BuildManager.Commands.Base;
using BuildManager.GeneralFunk;
using BuildManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BuildManager.Commands.UserCabinet
{
    public class ExitCommand : Command
    {
        public ICommand AppCommand { get; }
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var changePage = new GenerateFunk();
            changePage.ChangePageForMainWindow(new MainPage());
        }

        public ExitCommand()
        {
            AppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
