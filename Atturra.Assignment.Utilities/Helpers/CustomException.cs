using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atturra.Assignment.Utilities
{
    public class CustomException : Exception
    {
        public string Code { get; set; }
        public CustomException(string message, string errorCode) : base(message)
        {
            Code = errorCode;
        }
    }
}
