using System.Windows;
using System.Windows.Controls;

namespace WPFAdvancedConcepts.Views
{
    /// <summary>
    /// Interaction logic for DataGridVirtualization.xaml
    /// </summary>
    public partial class DataGridVirtualization : UserControl
    {
        public static readonly DependencyProperty LblDataGridProperty = DependencyProperty.Register(
    nameof(LblDataGrid), typeof(string), typeof(DataGridVirtualization), new PropertyMetadata("Colors Data Grid"));

        public string LblDataGrid
        {
            get => (string)GetValue(LblDataGridProperty);
            set => SetValue(LblDataGridProperty, value);
        }

        public DataGridVirtualization()
        {
            InitializeComponent();
        }
    }
}
