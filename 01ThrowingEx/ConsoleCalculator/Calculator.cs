using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}

            if (operation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("logging in proces");
                    //throw;

                    //throw new ArithmeticException("An error occured during calculation.", ex);
                    throw new CalculationException(ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(nonNullOperation);
                //throw new ArgumentOutOfRangeException(nameof(operation), "Mathematical operator is not supported)");
                //Console.WriteLine("Unknown operation.");
                //return 0;
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}

