using Mvvm_practice.ViewModel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mvvm_practice.View.Controls
{
    /// <summary>
    /// Interaction logic for FilterListRow.xaml
    /// </summary>
    public partial class FilterListRowControl : UserControl
    {
        public static readonly DependencyProperty FilterListProperty = DependencyProperty.Register(
            nameof(FilterList), typeof(Dictionary<string, IFilter>), typeof(FilterListRowControl), new PropertyMetadata(new Dictionary<string, IFilter>(), onChanged));

        public Dictionary<string, IFilter> FilterList
        {
            get { return (Dictionary<string, IFilter>)GetValue(FilterListProperty); }
            set
            {
                SetValue(FilterListProperty, value);
            }
        }

        public FilterListRowControl()
        {
            InitializeComponent();
        }

        private static void onChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            FilterListRowControl control = (FilterListRowControl)d;
            if(e.Property.Name == nameof(FilterList))
            {

            }
        }
    }
}
