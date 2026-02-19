using System;

namespace Operations03
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// 3. The application receives four numbers, then calculates which is the lowest result
            /// after each one is divided by the remaining three. The lowest result must be returned.
            /// </summary>

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 1st number: ");
            Console.ResetColor();
            double a = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 2nd number: ");
            Console.ResetColor();
            double b = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 3rd number: ");
            Console.ResetColor();
            double c = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter 4th number: ");
            Console.ResetColor();
            double d = Convert.ToDouble(Console.ReadLine());

            // Atenção: aqui assumo que nenhum dos números é 0 (para evitar divisão por zero)
            double resultA = a / b / c / d;
            double resultB = b / a / c / d;
            double resultC = c / a / b / d;
            double resultD = d / a / b / c;

            double lowestResult = resultA;
            string lowestLabel = "1st number";

            if (resultB < lowestResult)
            {
                lowestResult = resultB;
                lowestLabel = "2nd number";
            }

            if (resultC < lowestResult)
            {
                lowestResult = resultC;
                lowestLabel = "3rd number";
            }

            if (resultD < lowestResult)
            {
                lowestResult = resultD;
                lowestLabel = "4th number";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The lowest result is {lowestResult}, produced by the {lowestLabel}.");
            Console.ResetColor();
        }
    }
}