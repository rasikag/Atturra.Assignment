using Atturra.Assignment.Services.Interfaces;

namespace Atturra.Assignment.Services
{
    public class IncomeTaxService : IIncomeTaxService
    {
        private protected decimal IncomeTaxRate { get; private set; }
        public decimal CalculateDeductions(decimal taxableIncome)
        {
            decimal toatalIncomeTax = 0;

            if (taxableIncome >= 0 && taxableIncome <= 18200)
            {
                toatalIncomeTax = 0;
                IncomeTaxRate = 0;
            }
            else if (taxableIncome > 18200 && taxableIncome <= 37000)
            {
                IncomeTaxRate = Convert.ToDecimal(19.0 / 100);
                toatalIncomeTax = (taxableIncome - 18200) * IncomeTaxRate;
            }
            else if (taxableIncome > 37000 && taxableIncome <= 87000)
            {
                IncomeTaxRate = Convert.ToDecimal(32.5 / 100);
                toatalIncomeTax = 3572 + ((taxableIncome - 37000) * IncomeTaxRate);
            }
            else if (taxableIncome > 87000 && taxableIncome <= 180000)
            {
                IncomeTaxRate = Convert.ToDecimal(37.0 / 100);
                toatalIncomeTax = 19822 + ((taxableIncome - 87000) * IncomeTaxRate);
            }
            else if (taxableIncome > 180000)
            {
                IncomeTaxRate = Convert.ToDecimal(47.0 / 100);
                toatalIncomeTax = 54232 + ((taxableIncome - 180000) * IncomeTaxRate);
            }
            return Math.Ceiling(toatalIncomeTax);
        }
    }
}
