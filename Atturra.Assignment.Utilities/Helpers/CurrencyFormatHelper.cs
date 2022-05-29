using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Utilities.Helpers
{
    public class CurrencyFormatHelper
    {
        public static string MaskCurrency(decimal amount, string currencySign = "$")
        {
            return string.Format("{0}{1}", currencySign, amount.ToString("N2"));
        }
    }
}
