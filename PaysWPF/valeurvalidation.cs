using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class ValeurValidation : ValidationRule
    {
        public double MinValeur { get; set; }
        public double MaxValeur { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                double note;
                string s = value as string;
                if (s != null)
                {
                    if (!double.TryParse(value as string, out note))
                    {
                        return new ValidationResult(false, "Conversion en double impossible.");
                    }
                    if (note < MinValeur)
                    {
                        return new ValidationResult(false, "La note ne peut pas être inférieur à " + MinValeur);
                    }
                    if (note > MaxValeur)
                    {
                        return new ValidationResult(false, "La note ne peut pas être supérieur à " + MaxValeur);
                    }
                }
                return ValidationResult.ValidResult;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}