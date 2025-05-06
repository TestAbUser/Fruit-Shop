using Shop.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public partial class UserModel: IDataErrorInfo
    {
        private string _error = string.Empty;

        public string Error => _error;

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                if (columnName == nameof(Email))
                {
                    if (!EmailValidationRegex.IsValidEmail(Email))
                    {
                        return "Email is not valid!";
                    }
                }
                return string.Empty;
            }
        }
    }
}
