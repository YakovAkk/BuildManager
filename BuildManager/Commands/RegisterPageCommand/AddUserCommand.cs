using BuildManager.Commands.Base;
using BuildManager.Views;
using System;
using System.Windows;
using System.Windows.Input;

namespace BuildManager.Commands.RegisterPageCommand
{
    public class AddUserCommand : Command
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
 
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
 
        public AddUserCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public override bool CanExecute(object? parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
