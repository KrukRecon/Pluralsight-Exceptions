using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException += new UnhandledExceptionEventHandler(HandleException);

            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                Console.WriteLine("Operation was not provided.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"An argument was null. {ex}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operation is not supported. {ex}");
            }
            catch (CalculationOperationNotSupportedException ex)
            {
                Console.WriteLine($"CalculationOperationNotSupportedException caught: {ex.Operation}");
                Console.WriteLine(ex);
            }
            catch (CalculationException ex)
            {
                Console.WriteLine($"CalculationException caught: {ex}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Sorry, something went wrong. {ex}");
            }
            finally
            {
                Console.WriteLine("XD");
            }


            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry there was a problem and we need to close. Details: {e.ExceptionObject}");
        }

        private static void DisplayResult(int result) => WriteLine($"Result is: {result}");
    }
}


// FROM C# 9 "Top-level statements":

//using ConsoleCalculator;
//using static System.Console;


//WriteLine("Enter first number");
//int number1 = int.Parse(ReadLine());

//WriteLine("Enter second number");
//int number2 = int.Parse(ReadLine());

//WriteLine("Enter operation");
//string operation = ReadLine().ToUpperInvariant();


//var calculator = new Calculator();
//int result = calculator.Calculate(number1, number2, operation);
//DisplayResult(result);


//WriteLine("\nPress enter to exit.");
//ReadLine();


//void DisplayResult(int result)
//{
//    WriteLine($"Result is: {result}");
//}


