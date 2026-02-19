using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a 3rd number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a 4th number: ");
            int d = Convert.ToInt32(Console.ReadLine());

            // primitive data types
            int GreatestNumber = a;

            if (b > GreatestNumber)
                GreatestNumber = b;

            if (c > GreatestNumber)
                GreatestNumber = c;

            if (d > GreatestNumber)
                GreatestNumber = d;

            Console.WriteLine($"The greatest number is: {GreatestNumber}");
        }
    }
}