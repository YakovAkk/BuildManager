using BuildManager.Commands.Base;
using BuildManager.GeneralFunk;
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
        public ICommand AppCommand { get; }
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            var changePage = new ChangePage();
            changePage.ChangePageForMainWindow(new MainPage());
        }

        public BackFromAboutApplicationCommand()
        {
            AppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
