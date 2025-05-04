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
        private string? _productName;
        private int _quantity;
        private readonly ProductModel _product;

        public CartViewModel(ProductModel product)
        {
            _product = product;
            Products = _product.Products;
        }

        public string? ProductName
        {
            get => _productName;
            set
            {
                if (value == _productName) return;
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }

        public bool IsInStock => _quantity <= _product.Quantity;

        public int Quantity
        {
            get => _quantity;

            set
            {
                if (value == _quantity) return;
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public string PageName => "Cart";

        public ObservableCollection<ProductModel> Products { get; } = [];
    }
}
