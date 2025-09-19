// See https://aka.ms/new-console-template for more information
using System;
using calculation_app;

namespace greeting_app 
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Prosper";
            Console.WriteLine("Hello, " + name + "!\n");

            Console.WriteLine("======================\n");

            // Using the Calculator class from calculation_app namespace
            Calculator calc = new Calculator();
            int sum = calc.Add(5, 3);
            Console.WriteLine("5 + 3 = " + sum + "\n");

            int difference = calc.Subtract(5, 3);
            Console.WriteLine("5 - 3 = " + difference + "\n");

            int product = calc.Multiply(5, 3);
            Console.WriteLine("5 * 3 = " + product + "\n");

            int quotient = calc.Divide(5, 3);
            Console.WriteLine("5 / 3 = " + quotient + "\n");

            int remainder = 5 % 3;
            Console.WriteLine("5 % 3 = " + remainder);
            // Console.ReadLine();
        }
    }
}

