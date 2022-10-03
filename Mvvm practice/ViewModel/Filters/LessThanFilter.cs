using Mvvm_practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    internal class LessThanFilter : FilterBase
    {
        public override string FilterName => "Less than";
        public override FilterInputType FilterInputType => FilterInputType.Input;

        public override List<int>? SelectableNumbers => null;

        public override int ApplyFilter(IList<int> numbers, int? filterParameter)
        {
            throw new NotImplementedException();
        }
    }
}
