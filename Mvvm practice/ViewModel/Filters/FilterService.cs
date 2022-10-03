using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm_practice.ViewModel.Filters
{
    internal class FilterService
    {
        public IDictionary<string, IFilter> FilterCollection { get; }
        public FilterService()
        {
            FilterCollection = new Dictionary<string, IFilter>();
            FillUpFilterList();
        }

        private void FillUpFilterList()
        {
            IFilter evenNumberFilter = new EvenNumberFilter();
            IFilter newLessThanFilter = new LessThanFilter();
            IFilter containNumberFilter = new ContainNumberFilter();

            FilterCollection.Add(evenNumberFilter.FilterName, evenNumberFilter);
            FilterCollection.Add(newLessThanFilter.FilterName, newLessThanFilter);
            FilterCollection.Add(containNumberFilter.FilterName, containNumberFilter);
        }
    }
}
