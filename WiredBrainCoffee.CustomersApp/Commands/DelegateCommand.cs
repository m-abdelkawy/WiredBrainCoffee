using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WiredBrainCoffee.CustomersApp.Commands
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canexecute;


        public DelegateCommand(Action<object> execute,Func<object,bool> canExecute = null)
        {
            if(execute == null)
            {
                throw new ArgumentNullException(nameof(execute));
            }
            _execute = execute;
            _canexecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
        public bool CanExecute(object parameter)
        {
            return _canexecute == null || _canexecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
