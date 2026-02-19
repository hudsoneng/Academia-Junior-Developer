using System;

namespace Operations05
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// summary
            /// 5. The application receives two number, calculates the multiplication 
            /// and return the word
            ///  “Bizz” when even and “Buzz” when odd;
            /// summary
            Console.Write("Enter 1st number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            int Result = FirstNumber * SecondNumber;

            Console.WriteLine($"The result of multiplication is {Result}");

            // Source - https://stackoverflow.com/a/18818697
            // Posted by TGH, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-02-19, License - CC BY-SA 3.0
            if (Result % 2 == 0)
            {
                Console.WriteLine("Bizz!");
            }
            else
            {
                Console.WriteLine("Buzz!");
            }

        }
    }
}