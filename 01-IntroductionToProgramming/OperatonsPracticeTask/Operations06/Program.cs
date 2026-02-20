using System;

namespace Operations06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// summary
            /// 6. The application that allows the user to select the application which allows the user to 
            /// select the prior developed (exercises 1 to 5) application of the above wants to execute.
            /// The selection if based on providing a selection code (Md#ID#). A Switch must be used;
            /// summary

            Operations01 operations01 = new Operations01();
            Operations02 operations02 = new Operations02();
            Operations03 operations03 = new Operations03();
            Operations04 operations04 = new Operations04();
            Operations05 operations05 = new Operations05();

            int Menu = 1;
            switch (Menu)
            {
                case 1:
                    operations01.GetFullName();
                    Console.Write("Enter your first name: ");
                    operations01.FirstName = Console.ReadLine();

                    Console.Write("Enter your second name: ");
                    operations01.FirstName = Console.ReadLine();

                    Console.Write("Enter your last name: ");
                    operations01.FirstName = Console.ReadLine();

                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)
        }
    }
}