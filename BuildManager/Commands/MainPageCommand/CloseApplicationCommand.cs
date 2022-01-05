using BuildManager.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands
{
    public class CloseApplicationCommand : Command
    {
        public ICommand CloseAppCommand { get; }
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }

        public CloseApplicationCommand()
        {
            CloseAppCommand = new LamdaCommand(Execute, CanExecute);
        }
    }
}
