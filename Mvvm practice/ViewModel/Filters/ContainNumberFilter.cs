using Mvvm_practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    internal class ContainNumberFilter : FilterBase
    {
        public override string FilterName => "Contain number";

        public override FilterInputType FilterInputType => FilterInputType.ComboBox;

        public override List<int>? SelectableNumbers => new() { 1, 2, 3 };

        public override int ApplyFilter(IList<int> numbers, int? filterParameter)
        {
            throw new NotImplementedException();
        }
    }
}
