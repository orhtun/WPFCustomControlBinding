using System.Collections.ObjectModel;
using System.Windows;

namespace WPFCustomControlBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> DataStringList
        {
            get { return (ObservableCollection<string>)GetValue(DataStringListProperty); }
            set { SetValue(DataStringListProperty, value); }
        }

        public static readonly DependencyProperty DataStringListProperty =
             DependencyProperty.Register("DataStringList", typeof(ObservableCollection<string>), typeof(CustomControl), new PropertyMetadata(default(ObservableCollection<string>)));

        public MainWindow()
        {
            DataStringList = new ObservableCollection<string>();
            this.DataContext = this;

            for (int i = 0; i < 10; i++)
            {
                DataStringList.Add(i.ToString());
            }

            InitializeComponent();
        }
    }
}