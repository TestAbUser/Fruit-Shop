using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CartPage
{
    public class CartViewModel: ObservableObject, IPageViewModel
    {

        public string PageName => "Cart";
    }
}
