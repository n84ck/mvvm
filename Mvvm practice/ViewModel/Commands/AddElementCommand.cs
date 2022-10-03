using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mvvm_practice.ViewModel.Commands
{
    internal class AddElementCommand : ICommand
    {
        private readonly MainViewModel vm;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddElementCommand(MainViewModel vm)
        {
            this.vm = vm;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            bool andOperation = false;
            if (parameter is bool boolean)
            {
                andOperation = boolean;
            }

            vm.AddElement(andOperation);
        }
    }
}
