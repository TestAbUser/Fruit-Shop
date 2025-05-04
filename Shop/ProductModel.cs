using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ProductModel : ObservableObject
    {
        private string? _pictureUrl;
        private string? _name;
        private int _quantity;

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

        public ObservableCollection<ProductModel> Products { get; } = [];

        public ObservableCollection<ProductModel> GetProducts()
        {
            Products.Add(new ProductModel { Name = "Bananas", PictureUrl = "/Images/bananas.jpg", Quantity = 50 });
            Products.Add(new ProductModel { Name = "Tomatoes", PictureUrl = "/Images/tomatoes.jpg", Quantity = 150 });
            Products.Add(new ProductModel { Name = "Apples", PictureUrl = "/Images/apples.jpg", Quantity = 71 });
            Products.Add(new ProductModel { Name = "Pears", PictureUrl = "/Images/pears.jpg", Quantity = 33 });
            return Products;
        }
    }
}
