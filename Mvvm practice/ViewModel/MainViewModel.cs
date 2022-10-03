using Mvvm_practice.Model;
using Mvvm_practice.ViewModel.Commands;
using Mvvm_practice.ViewModel.Filters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<FilterListElement> ElementCollection { get; set; }
        public IDictionary<string, IFilter> FilterCollection { get; set; }

        public AddElementCommand AddElementCommand { get; set; }

        public MainViewModel()
        {
            AddElementCommand = new AddElementCommand(this);
            ElementCollection = new ObservableCollection<FilterListElement>();
            FilterCollection = new FilterService().FilterCollection;
        }


        public void AddElement(bool andOperation)
        {
            ElementCollection.Add(new FilterListElement { IsAndOperation = andOperation});
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
