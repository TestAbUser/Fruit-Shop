﻿using Shop.UtilityClasses;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Shop
{
    public partial class UserModel : IDataErrorInfo
    {
        private readonly string _error = string.Empty;

        public string Error => _error;

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case nameof(Email):
                        if (!EmailValidationRegex.IsValidEmail(Email))
                        {
                            return "Email is not valid!";
                        }
                        return string.Empty;
                    case nameof(PhoneNumber):
                        if (!ValidatePhoneNumber(PhoneNumber))
                        {
                            return "Phone number is not valid!";
                        }
                        return string.Empty;
                }

                return string.Empty;
            }
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;
            try
            {
                return Regex.IsMatch(phoneNumber,
                    @"^\s*\+?\s*([0-9][\s-]*){9,}$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
