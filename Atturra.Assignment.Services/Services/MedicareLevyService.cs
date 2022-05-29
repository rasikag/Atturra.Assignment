using Atturra.Assignment.Services.Interfaces;

namespace Atturra.Assignment.Services
{
    public class MedicareLevyService : IMedicareLevyService
    {
        private decimal MedicareRate { get; set; }
        public decimal CalculateDeductions(decimal taxableIncome)
        {
            decimal total = 0.00m;
            try
            {
                if (taxableIncome >= 0 && taxableIncome <= 21335)
                {
                    total = 0;
                    MedicareRate = 0;
                }
                else if (taxableIncome > 21335 && taxableIncome <= 26668)
                {
                    MedicareRate = Convert.ToDecimal(10.0 / 100);
                    total = (taxableIncome - 21335) * MedicareRate;
                }
                else if (taxableIncome > 26668)
                {
                    MedicareRate = Convert.ToDecimal(2.0 / 100);
                    total = taxableIncome * MedicareRate;
                }
                return Math.Ceiling(total);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            return total;
        }
    }
}
