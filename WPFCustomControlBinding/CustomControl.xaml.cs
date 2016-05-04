using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace WPFCustomControlBinding
{
    /// <summary>
    /// Interaction logic for CustomControl.xaml
    /// </summary>
    public partial class CustomControl : UserControl
    {
        public IEnumerable CustomItems
        {
            get { return (IEnumerable)GetValue(CustomItemsProperty); }
            set { SetValue(CustomItemsProperty, value); }
        }

        public static readonly DependencyProperty CustomItemsProperty =
             DependencyProperty.Register("CustomItems", typeof(IEnumerable), typeof(CustomControl), new PropertyMetadata(default(IEnumerable)));

        public CustomControl()
        {
            InitializeComponent();
        }
    }
}