using Shop.NavigationPanel;
using System.Windows;

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationViewModel context = new();
            DataContext = context;
            this.Show();
        }
    }
}