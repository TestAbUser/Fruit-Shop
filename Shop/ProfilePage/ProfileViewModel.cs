using Shop.UtilityClasses;

namespace Shop.ProfilePage
{
    public class ProfileViewModel : ObservableObject, IPageViewModel
    {
        public string PageName => "Profile";
        public string PageIconUrl => "/Images/profile.ico";
    }
}
