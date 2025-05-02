using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.HomePage
{
    public class HomePageViewModel:ObservableObject, IPageViewModel
    {
        private ProductModel _product;
        public string Name => "Home";

        public HomePageViewModel() 
        {
            _product = new ();
            Products = _product.GetProducts();
        }
        public ObservableCollection<ProductModel> Products { get;} = [];
    }
}
