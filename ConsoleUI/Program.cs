using System;
using UnitTestsLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations calc = new Calculations();

            Console.Write("\nPlease enter the value of X => ");
            calc.X = double.Parse(Console.ReadLine());


            Console.Write("\nPlease enter the value of Y => ");
            calc.Y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter which operation you would like to do => ");
            calc.Operation = Console.ReadLine();

            string operating = calc.Operation.ToLower();

            switch(operating)
            {
                case "add":
                    calc.Add(calc.X, calc.Y);
                    Console.Write(calc.SumDouble);
                    break;
                case "subtract":
                    calc.Subtract(calc.X, calc.Y);
                    Console.Write(calc.SumDouble);
                    break;
                case "divide":
                    calc.Divide(calc.X, calc.Y);
                    Console.Write(calc.SumDouble);
                    break;
                case "multiply":
                    calc.Multiply(calc.X, calc.Y);
                    Console.Write(calc.SumDouble);
                    break;
                default:
                    Console.WriteLine($"{operating} is not a valid operation");
                    break;
            }

            Console.ReadLine();
        }
    }
}
