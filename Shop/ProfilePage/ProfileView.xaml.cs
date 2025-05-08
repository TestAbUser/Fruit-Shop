using System.Windows.Controls;
using System.Windows.Input;

namespace Shop.ProfilePage
{
    /// <summary>
    /// Interaction logic for ProfileView.xaml
    /// </summary>
    public partial class ProfileView : UserControl
    {
        public ProfileView()
        {
            InitializeComponent();
        }

        private void GroupBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            balance.IsEnabled = !balance.IsEnabled;
        }
    }
}
