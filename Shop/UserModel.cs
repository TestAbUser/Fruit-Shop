using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
   public class UserModel: ObservableObject
    {
        private string _firstName;
        private string? _middleName;
        private string _lastName;
        private string _phoneNumber;
        private int _age;
        private decimal _balance;
        private string _email;

        public string FirstName
        {
            get => _firstName;

            set
            {
                if (value == _firstName) return;
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string MiddleName
        {
            get => _middleName;

            set
            {
                if (value == _middleName) return;
                _middleName = value;
                OnPropertyChanged(nameof(MiddleName));
            }
        }

        public string LastName
        {
            get => _lastName;

            set
            {
                if (value == _lastName) return;
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;

            set
            {
                if (value == _phoneNumber) return;
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get => _email;

            set
            {
                if (value == _email) return;
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public int Age
        {
            get => _age;

            set
            {
                if (value == _age) return;
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public decimal Balance
        {
            get => _balance;

            set
            {
                if (value == _balance) return;
                _balance = value;
                OnPropertyChanged(nameof(Balance));
            }
        }
    }
}
