using System;

namespace CalculatorNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.Write("Enter first number  : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            calculator.Calculate(num1, num2);
        }
    }

    public class Calculator
    {
        public delegate void CalculatorHandler (double num1, double num2);

        public event CalculatorHandler Calculated;

        public void doAllOperations(double num1, double num2)
        {
            Console.WriteLine("\nResult : ");
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public void Calculate(double num1, double num2)
        {
            Calculated?.Invoke(num1, num2);
        }

        public Calculator()
        {
            Calculated += doAllOperations;
        }

    }
}