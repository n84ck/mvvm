using Mvvm_practice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    internal class EvenNumberFilter : FilterBase
    {
        public override string FilterName => "Even numbers";
        public override FilterInputType FilterInputType => FilterInputType.Nothing;

        public override int ApplyFilter(IList<int> numbers, int? filterParameter)
        {
            throw new NotImplementedException();
        }
    }
}
