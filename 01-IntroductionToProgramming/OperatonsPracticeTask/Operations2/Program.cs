using System;

namespace Operations2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 2. The application receives two number, then calculates which has the highest result of
            /// the division of one from the other.The result must be returned
            /// </summary>
            Console.Write("Enter 1st number: "); // a
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: "); // b
            int b = Convert.ToInt32(Console.ReadLine());

            int HighestResult = a / b;

            Console.WriteLine($"{HighestResult}");
        }
    }
}