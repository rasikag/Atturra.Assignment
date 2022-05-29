using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Utilities.Helpers
{
    public class UserInputReceiver
    {
        public static decimal GetGrossPackage()
        {
            string salaryPackage = Console.ReadLine();
            string salaryPackageValidation;

            salaryPackageValidation = UserInputValidator.GrossPackageValidator(salaryPackage);
            while (!string.IsNullOrEmpty(salaryPackageValidation))
            {
                Console.WriteLine(salaryPackageValidation);
                Console.WriteLine("Please enter your salary package amount again:");
                salaryPackage = Console.ReadLine();
                salaryPackageValidation = UserInputValidator.GrossPackageValidator(salaryPackage);
            }
            return Convert.ToDecimal(salaryPackage);
        }


        public static string GetPayFrequency()
        {
            string payFrequency = Console.ReadLine();
            string payFrequencyValidation = UserInputValidator.PayFrequencyValidator(payFrequency);
            while (!string.IsNullOrEmpty(payFrequencyValidation))
            {
                Console.WriteLine(payFrequencyValidation);
                Console.WriteLine("Please enter your pay frequency (W for weekly, F for fortnightly, M for monthly) again:");
                payFrequency = Console.ReadLine();
                payFrequencyValidation = UserInputValidator.PayFrequencyValidator(payFrequency);
            }
            return payFrequency;
        }
    }
}
