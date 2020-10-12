using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.Commands
{
    public class DelegateCommandClass : ICommand
    {
        Action<object> _executeMethodAddress;
        Func<object, bool> _canExecuteMethodAddress;

        public DelegateCommandClass(Action<object> executeMethodAddress,Func<object,bool> canExecuteMethodAddress)
        {
            this._executeMethodAddress = executeMethodAddress;
            this._canExecuteMethodAddress = canExecuteMethodAddress;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this._canExecuteMethodAddress.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this._executeMethodAddress.Invoke(parameter);
        }
    }
}
