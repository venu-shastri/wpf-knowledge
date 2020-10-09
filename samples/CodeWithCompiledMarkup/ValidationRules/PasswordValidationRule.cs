using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CodeWithCompiledMarkup.ValidationRules
{
    public class PasswordValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string password = value as string;
            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult(false, "Password Requires Value");
            }
            else
            {
                if(password.Length > 4 && password.Length < 8)
                {
                    return new ValidationResult(true, "");
                    
                }
                return new ValidationResult(false, "Password Length > 4 and  < 8");

            }

        }
    }
}
