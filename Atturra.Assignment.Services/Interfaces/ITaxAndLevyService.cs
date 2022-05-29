using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Services.Interfaces
{
    public interface ITaxAndLevyService
    {
        public decimal CalculateDeductions(decimal taxableIncome);
    }
}
