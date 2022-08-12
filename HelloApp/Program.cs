using System;
using MyCalc;

namespace HelloApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to jenkins");
            Console.WriteLine("2nd build");
            Calc calc = new Calc();
            Console.WriteLine($"Sum = {calc.Add(70,80)}");
            Console.WriteLine($"Sum = {calc.Multiply(4, 5)}");
            Console.WriteLine($"Sum = {calc.Subtract(20, 5)}");
            Console.ReadLine();
        }
    }
}
