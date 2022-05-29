using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Enums
{
    public enum ErrorCodes
    {
        [Description("Calculation Error.")]
        CODE_CALCULATION_ERROR,
        [Description("Invalid Frequency Error.")]
        CODE_INVALID_FREQUENCY_ERROR,
        [Description("Error occurred when Currency formatting.")]
        CODE_CURRENCY_FORMATTING_ERROR,
        [Description("Error occurred when currency round up to the nearest cent.")]
        CODE_CURRENCY_ROUNDINGTO_CENT_ERROR,
        [Description("Error occurred when currency round up to the nearest dollar.")]
        CODE_CURRENCY_ROUNDINGTO_DOLLER_ERROR,

        [Description("Calculate deduction Error.")]
        CODE_CALCULATION_DEDUCTION_ERROR,
        [Description("Invalid Tax Income.")]
        CODE_INVALID_TAX_INCOME_ERROR,
    }
}
