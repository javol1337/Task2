using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, this is an addition calculator.");
            Console.WriteLine("Please enter the first number");

            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");

            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is: {firstNumber + secondNumber}");

        }
    }
}
