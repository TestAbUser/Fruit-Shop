using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.ProfilePage
{
    public class ProfileViewModel: ObservableObject, IPageViewModel
    {
        public string PageName => "Profile";
    }
}
