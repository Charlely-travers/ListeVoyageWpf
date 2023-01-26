using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    class Urlvalidation : ValidationRule
    {
        public string urldrapeau { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            try
            {
                string s = value as string;
                Uri uri;


                if (s != null)
                {
                    if(s.StartsWith("https"))
                    {
                        s=s.Replace("https", "http");
                    }
                    if(s.StartsWith("www."))
                    {
                        s = s.Replace("www.", "http://");
                    }

                    if ((Uri.TryCreate(s, UriKind.Absolute, out uri) && uri.Host.Replace("www.", "").Split('.').Count() > 1 && uri.HostNameType == UriHostNameType.Dns && uri.Host.Length > uri.Host.LastIndexOf(".") + 1 && 255 >= s.Length && uri.Scheme == Uri.UriSchemeHttp) == false)
                        return new ValidationResult(false, "Url non valide");
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

     

