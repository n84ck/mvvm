using Mvvm_practice.ViewModel.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.Model
{
    internal class FilterListElement: INotifyPropertyChanged
    {
        private IFilter? filter;
        private bool isAndOperation;
        private int filterParameterValue;

        public bool IsAndOperation
        { 
            get { return isAndOperation; }
            set 
            { 
                isAndOperation = value;
                OnPropertyChanged();
            }
        }

        public int FilterParameterValue
        {
            get { return filterParameterValue; }
            set
            {
                filterParameterValue = value;
                OnPropertyChanged();
            }
        }

        public IFilter? SelectedFilter
        {
            get { return filter; }
            set
            {
                filter = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
