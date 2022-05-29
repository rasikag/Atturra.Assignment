
using Atturra.Assignment.Services.Factory.Interface;
using Atturra.Assignment.Services.Interfaces;
using Atturra.Assignment.Utilities.Enums;
using Atturra.Assignment.Utilities.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Atturra.Assignment
{
    public class Program
    {


        public static void Main()
        {
            decimal SUPERANNUATIONRATE = Convert.ToDecimal(9.5 / 100);

            var serviceProvider = AppConfiguration.ConfigureServices();

            var medicareService = serviceProvider.GetService<IMedicareLevyService>();
            var budgeteService = serviceProvider.GetService<IBudgetRepairLevyService>();
            var incomeService = serviceProvider.GetService<IIncomeTaxService>();
            var incomeCalculatorFactory = serviceProvider.GetService<IIncomeCalculatorFactory>();

            if (incomeCalculatorFactory == null || medicareService == null || budgeteService == null || incomeService == null) //
                return;

            Console.WriteLine("Enter your salary package amount:");
            var grossPayValue = UserInputReceiver.GetGrossPackage();

            Console.WriteLine("Enter your pay frequency (W for weekly, F for fortnightly, M for monthly):");

            string payFrequency = UserInputReceiver.GetPayFrequency();
            var calculator = incomeCalculatorFactory.CreateIncomeCalculator(payFrequency);

            Frequency frequency = UserInputValidator.ConvertPayFreq(payFrequency);

            Console.WriteLine("Calculating salary details...");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Gross package: {0}", CurrencyFormatHelper.MaskCurrency(grossPayValue));

            var superAnnum = calculator.GetSuperAnnum(grossPayValue, SUPERANNUATIONRATE);

            Console.WriteLine("Superannuation : {0}", CurrencyFormatHelper.MaskCurrency(superAnnum));

            var taxableAmount = calculator.GetTaxableIncome(grossPayValue, superAnnum);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Taxable income: {0}", CurrencyFormatHelper.MaskCurrency(taxableAmount));

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            var deductionStartAmount = calculator.DeductionStartSalary(taxableAmount);

            Console.WriteLine("Deductions: ");
            var medicareLevy = medicareService.CalculateDeductions(deductionStartAmount);
            Console.WriteLine("Medicare Levy : {0}", CurrencyFormatHelper.MaskCurrency(medicareLevy));


            var budgetRepairLevy = budgeteService.CalculateDeductions(deductionStartAmount);
            Console.WriteLine("Budget Repair Levy : {0}", CurrencyFormatHelper.MaskCurrency(budgetRepairLevy));


            var incomeTax = incomeService.CalculateDeductions(deductionStartAmount);
            Console.WriteLine("Income Tax : {0}", CurrencyFormatHelper.MaskCurrency(incomeTax));

            Console.WriteLine("");
            Console.WriteLine("");


            var netSalary = calculator.GetnetSalary(grossPayValue, superAnnum, incomeTax, medicareLevy, budgetRepairLevy);

            Console.WriteLine("Net Income : {0}", CurrencyFormatHelper.MaskCurrency(netSalary));

            var payPacket = calculator.PayPacketAmount(netSalary);

            Console.WriteLine("Pay packet: {0} per {1}", CurrencyFormatHelper.MaskCurrency(payPacket), frequency);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Press any key to end...");
            Console.ReadLine();
            CloseApp();
        }


        private static void CloseApp()
        {
            Environment.Exit(0);
        }


    }


}

