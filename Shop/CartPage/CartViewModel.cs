using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CartPage
{
    public class CartViewModel : ObservableObject, IPageViewModel
    {
        private readonly ProductModel _product;

        public CartViewModel(ProductModel product)
        {
            _product = product;
            Products = _product.Products;
        }

        public string PageName => "Cart";
        public string PageIconUrl => "/Images/cart.ico";

        public ObservableCollection<ProductModel> Products { get; } = [];

    }
}
