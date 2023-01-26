
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class ValidationPrix : ValidationRule
    {
        public double MinValeur { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                double note;
                string s = value as string;
                if (s != null)
                {
                    s = s.TrimEnd('€');
                    if (!double.TryParse(s, out note))
                    {
                        return new ValidationResult(false, "Conversion en double impossible.");
                    }
                    if (note < MinValeur)
                    {
                        return new ValidationResult(false, "Le prix ne peut pas être inférieur à " + MinValeur);
                    }
                }
                return ValidationResult.ValidResult;

            }
            catch (Exception e)
            {

                return new ValidationResult(false, e.Message); ;
            }
        }
    }
}