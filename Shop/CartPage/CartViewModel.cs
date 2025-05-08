using Shop.UtilityClasses;
using System.Collections.ObjectModel;

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
