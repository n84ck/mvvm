using Mvvm_practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    public interface IFilter
    {
        string FilterName { get; }
        FilterInputType FilterInputType { get; }
        List<int>? SelectableNumbers { get; }
        int ApplyFilter(IList<int> numbers, int? filterParameter);
    }
}
