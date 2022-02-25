using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculationException : Exception
    {
        private const string _defaultMessage = "Error Message, idk i don't want to re-type it XD";

        public CalculationException() : base(_defaultMessage)
        {
        }

        public CalculationException(string message) : base(message)
        {
        }

        public CalculationException(Exception innerException) : base(_defaultMessage ,innerException)
        {
        }

        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
