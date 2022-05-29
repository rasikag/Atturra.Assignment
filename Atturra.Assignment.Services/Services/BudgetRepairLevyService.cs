using Atturra.Assignment.Services.Interfaces;

namespace Atturra.Assignment.Services
{
    public class BudgetRepairLevyService : IBudgetRepairLevyService
    {
        private protected decimal BudgetRepairLevyRate { get; private set; }

        public decimal CalculateDeductions(decimal taxableIncome)
        {
            decimal totalBudgetLevy = 0;

            if (taxableIncome >= 0 && taxableIncome <= 180000)
            {
                totalBudgetLevy = 0;
                BudgetRepairLevyRate = 0;
            }
            else if (taxableIncome > 180000)
            {
                BudgetRepairLevyRate = Convert.ToDecimal(2.0 / 100);
                totalBudgetLevy = (taxableIncome - 180000) * BudgetRepairLevyRate;
            }
            return Math.Ceiling(totalBudgetLevy);
        }
    }
}
