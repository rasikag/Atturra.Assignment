using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Services.Calculators
{
    public class WeeklyIncomeCalculator : IncomeCalculator
    {
        public override decimal PayPacketAmount(decimal netSalary)
        {
            return Math.Round((netSalary / 52), 2, MidpointRounding.AwayFromZero);
        }

    }
}
