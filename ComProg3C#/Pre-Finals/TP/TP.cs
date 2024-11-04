using System;

namespace CalculatorNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculatorClass cal = new CalculatorClass();

            Console.Write("Enter first number  : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            cal.Calculate(num1, num2);
        }
    }

    public class CalculatorClass
    {
        public delegate void Formula (double num1, double num2);

        public event Formula CalculateEvent;

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
            CalculateEvent?.Invoke(num1, num2);
        }

        public CalculatorClass()
        {
            CalculateEvent += doAllOperations;
        }

    }
}