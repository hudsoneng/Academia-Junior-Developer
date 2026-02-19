using System;
using System.Security.Cryptography.X509Certificates;

namespace OpeatornsPraticeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Hudson";
            string SecondName = "Ferraz";
            string LastName = "Souza";
            string FullName = $"{FirstName} {SecondName} {LastName}";
            char Gender = 'M';
            int Age = 26;
            DateTime BirthDate = new DateTime(1999, 10, 30);
            string CurrentJob = "Architectural Hardware House";
            float Height = 1.78f;
            string EyeColour = "Brown";

            Console.WriteLine($"{FirstName}"); // a.
            Console.WriteLine($"{SecondName}"); // b.
            Console.WriteLine($"{LastName}"); // c.
            Console.WriteLine($"{FullName}"); // d.
            Console.WriteLine($"{Gender}"); // e.
            Console.WriteLine($"{Age}"); // f.
            Console.WriteLine(BirthDate); // g.
            Console.WriteLine($"{CurrentJob}"); // h.
            Console.WriteLine($"{Height} Meters"); // i.
            Console.WriteLine($"{EyeColour}"); // j.
        }
    }
}