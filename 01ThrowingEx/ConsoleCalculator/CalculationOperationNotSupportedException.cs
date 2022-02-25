using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class CalculationOperationNotSupportedException : CalculationException
    {
        private const string _defaultMessage = "Specified operation was out of the range of valid values";

        public string Operation { get; }

        public CalculationOperationNotSupportedException() : base(_defaultMessage)
        {
        }

        public CalculationOperationNotSupportedException(Exception innerException) : base(_defaultMessage, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public CalculationOperationNotSupportedException(string operation) : base(_defaultMessage)
        {
            Operation = operation;
        }

        public CalculationOperationNotSupportedException(string operation, string message) : base(message)
        {
            Operation = operation;
        }

        public override string ToString()
        {
            if (Operation == null)
            {
                return base.ToString();
            }

            return base.ToString() + Environment.NewLine + $"Unsupported operation: {Operation}";
        }
    }
}
