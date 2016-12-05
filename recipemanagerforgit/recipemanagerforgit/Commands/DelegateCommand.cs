using System;
using System.Windows.Input;

namespace recipemanagerforgit.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action myAction;

        public DelegateCommand(Action action)
        {
            myAction = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            myAction.Invoke();
        }
    }
}