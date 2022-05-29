using Atturra.Assignment.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Utilities.Helpers
{
    public class UserInputValidator
    {
        public static string GrossPackageValidator(string input)
        {
            string errorMessage = "";
            decimal parsedInput = 0.00m;
            try
            {
                parsedInput = Convert.ToDecimal(input);
            }
            catch (Exception ex)
            {
                errorMessage = "Please enter a valid number";
                return errorMessage;
            }


            if (parsedInput <= 0)
            {
                errorMessage = "Gross package should be a positive value.";
            }

            return errorMessage;
        }

        public static string PayFrequencyValidator(string input)
        {
            string errorMessage = "";
            if (input != "W" && input != "F" && input != "M")
            {
                errorMessage = "Please enter valid pay frequency value";
            }
            return errorMessage;
        }


        public static Frequency ConvertPayFreq(string input)
        {
            if (input == "M")
            {
                return Frequency.Month;
            }

            if (input == "F")
            {
                return Frequency.Fortnight;
            }

            if (input == "W")
            {
                return Frequency.Week;
            }

            return Frequency.Month;
        }
    }
}
