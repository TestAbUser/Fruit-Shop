using Shop.UtilityClasses;
using System.Collections.ObjectModel;

namespace Shop.HomePage
{
    public class HomePageViewModel : ObservableObject, IPageViewModel
    {
        private readonly ProductModel _product;
        public string PageName => "Home";
        public string PageIconUrl => "/Images/home.png";


        public HomePageViewModel(ProductModel product)
        {
            _product = product;
            Products = _product.CreateProducts();
        }
        public ObservableCollection<ProductModel> Products { get; } = [];
    }
}
