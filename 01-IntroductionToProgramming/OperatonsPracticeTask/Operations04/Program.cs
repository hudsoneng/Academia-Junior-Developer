using System;

namespace Operations04
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 4. The application receives two number and divides them. The result must be returned,
            /// with two decimal places;
            /// </summary>

            Console.Write("Enter 1st number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            decimal DecimalPlaceA = (decimal) (a / b);

            decimal DecimalPlaceB = (decimal) (b / a);

            Console.WriteLine($"Result of a / b: {DecimalPlaceA:F2}");
            Console.WriteLine($"Result of b / a: {DecimalPlaceB:F2}");
        }
    }
}