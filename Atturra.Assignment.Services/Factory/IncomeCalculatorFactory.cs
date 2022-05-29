using Atturra.Assignment.Services.Calculators;
using Atturra.Assignment.Services.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Services.Factory
{
    public class IncomeCalculatorFactory : IIncomeCalculatorFactory
    {

        public IncomeCalculator CreateIncomeCalculator(string frequency)
        {

            IncomeCalculator calculator;

            if (string.IsNullOrEmpty(frequency))
            {
                throw new ArgumentNullException("Frequency cannot be null.");
            }

            switch (frequency)
            {
                case "W": calculator = new WeeklyIncomeCalculator(); break;
                case "F": calculator = new FortnightIncomeCalculator(); break;
                case "M": calculator = new MonthlyIncomeCalculator(); break;
                default: throw new NotSupportedException("The provided frequency is not yet supported.");
            }

            return calculator;
        }

    }
}
