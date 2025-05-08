using Shop.UtilityClasses;
using System.Collections.ObjectModel;

namespace Shop
{
    public class ProductModel : ObservableObject
    {
        private string? _pictureUrl;
        private string? _name;
        private int _quantityInStock;
        private int _quantityToBuy;

        public string? PictureUrl
        {
            get => _pictureUrl;
            set
            {
                if (value == _pictureUrl) return;
                _pictureUrl = value;
                OnPropertyChanged(nameof(PictureUrl));
            }
        }
        public string? Name
        {
            get => _name;
            set
            {
                if (value == _name) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int QuantityInStock
        {
            get => _quantityInStock;

            set
            {
                if (value == _quantityInStock) return;
                _quantityInStock = value;
                OnPropertyChanged(nameof(QuantityInStock));
            }
        }

        public int QuantityToBuy
        {
            get => _quantityToBuy;

            set
            {
                if (value == _quantityToBuy) return;
                _quantityToBuy = value;
                OnPropertyChanged(nameof(QuantityToBuy));
                OnPropertyChanged(nameof(IsInStock));
            }
        }
        public bool IsInStock => _quantityToBuy <= _quantityInStock;

        public ObservableCollection<ProductModel> Products { get; } = [];

        public ObservableCollection<ProductModel> CreateProducts()
        {
            Products.Add(new ProductModel { Name = "Bananas", PictureUrl = "/Images/bananas.jpg", QuantityInStock = 50 });
            Products.Add(new ProductModel { Name = "Tomatoes", PictureUrl = "/Images/tomatoes.jpg", QuantityInStock = 150 });
            Products.Add(new ProductModel { Name = "Apples", PictureUrl = "/Images/apples.jpg", QuantityInStock = 71 });
            Products.Add(new ProductModel { Name = "Pears", PictureUrl = "/Images/pears.jpg", QuantityInStock = 33 });
            return Products;
        }
    }
}
