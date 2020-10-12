using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.Commands
{
    public class AddCommandClass : ICommand
    {
        ViewModels.CalculatorViewModel _viewModel;
        public AddCommandClass(ViewModels.CalculatorViewModel viewModel)
        {
            this._viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // ViewModel
            this._viewModel.Add();
        }
    }
}
