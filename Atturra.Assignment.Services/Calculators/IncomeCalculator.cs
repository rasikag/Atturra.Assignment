using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Services.Calculators
{
    public abstract class IncomeCalculator
    {
        public virtual decimal GetSuperAnnum(decimal grossIncome, decimal superannuationRate)
        {
            var result = (grossIncome / (1 + superannuationRate)) * superannuationRate;
            return Math.Round(result, 2);
        }

        public virtual decimal GetTaxableIncome(decimal grossIncome, decimal superannuationRate)
        {
            return grossIncome - superannuationRate;
        }

        public virtual decimal GetnetSalary(decimal grossAmount, decimal superannuation, decimal incomeTax, decimal medicareLevy, decimal budgetRepairLevy)
        {
            return grossAmount - (superannuation + incomeTax + medicareLevy + budgetRepairLevy);
        }

        public virtual decimal DeductionStartSalary(decimal taxableIncome)
        {
            return Math.Floor(taxableIncome);
        }

        public abstract decimal PayPacketAmount(decimal netSalary);
    }
}
