using Atturra.Assignment.Services.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Services.Factory.Interface
{
    public interface IIncomeCalculatorFactory
    {
        public IncomeCalculator CreateIncomeCalculator(string frequency);
    }
}
