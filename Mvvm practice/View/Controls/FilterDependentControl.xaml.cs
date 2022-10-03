using Mvvm_practice.Model;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace Mvvm_practice.View.Controls
{
    public partial class FilterDependentControl : UserControl
    {

        public static readonly DependencyProperty FilterInputTypeProperty = DependencyProperty.Register(
        nameof(FilterInputType), typeof(FilterInputType), typeof(FilterDependentControl), new PropertyMetadata(FilterInputType.Nothing));


        public static readonly DependencyProperty SelectableValuesProperty =
            DependencyProperty.Register(nameof(SelectableValues), typeof(IList<int>), typeof(FilterDependentControl), new PropertyMetadata(new List<int>()));

        public FilterDependentControl()
        {
            InitializeComponent();
        }

        public FilterInputType FilterInputType
        {
            get { return (FilterInputType)this.GetValue(FilterInputTypeProperty); }
            set { this.SetValue(FilterInputTypeProperty, value); }
        }

        public IList<int>? SelectableValues
        {
            get { return (IList<int>?)GetValue(SelectableValuesProperty); }
            set { SetValue(SelectableValuesProperty, value); }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool successfull = int.TryParse(e.Text, out _);

            e.Handled = !successfull;
        }
    }
}
