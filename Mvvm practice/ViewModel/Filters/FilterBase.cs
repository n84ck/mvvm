using Mvvm_practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    internal abstract class FilterBase : IFilter
    {
        public abstract string FilterName { get; }

        public abstract FilterInputType FilterInputType { get; }

        public virtual List<int>? SelectableNumbers => null;

        public abstract int ApplyFilter(IList<int> numbers, int? filterParameter);
    }
}
