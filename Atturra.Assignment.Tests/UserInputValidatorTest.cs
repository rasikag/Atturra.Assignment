using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atturra.Assignment.Utilities.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Atturra.Assignment.Tests
{
    [TestClass]
    public class UserInputValidatorTest
    {
        [TestMethod]
        public void ParseUserInputToDecimal()
        {
            var result = UserInputValidator.GrossPackageValidator("1234.67");
            Assert.IsNotNull(result);
        }
    }
}
