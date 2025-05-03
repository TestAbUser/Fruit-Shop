using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.CartPage
{
    public class CartViewModel: ObservableObject, IPageViewModel
    {
        private string? _productName;
        private bool _isInStock;
        private int _quantity;

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

        public bool IsInStock
        {
            get => _isInStock;
            set
            {
                if (value == _isInStock) return;
                _isInStock = value;
                OnPropertyChanged(nameof(IsInStock));
            }
        }

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

        //private ProductModel _product;

        //public CartViewModel()
        //{
        //    //  _product = new();
        //    Products.Add(new ProductModel { Name = "fd" });//_product.GetProducts();
        //}
        //public ObservableCollection<ProductModel> Products { get; } = [];
    }
}
