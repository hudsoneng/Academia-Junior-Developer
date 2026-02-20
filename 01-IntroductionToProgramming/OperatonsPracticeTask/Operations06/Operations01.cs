using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operations06
{
    internal class Operations01
    {
        /// <summary>
        /// Develop a console application for each of the points in the list below.
        /// When a input is requested, the same must be provided by the user.
        /// </summary>
        public required string FirstName;
        public required string SecondName;
        public required string LastName;
        public required string FullName;

        public required char Gender;
        public required int Age;
        public required DateTime BirthDate;
        public required string CurrentJob;
        public required float Height;
        public required string EyeColour;


        public string GetFullName()
        {
            return $"Welcome {FullName}!";
        }

        public string str;
        char[] charArray = str.ToCharArray();
        public char GetGender()
        {
            return $"Selected ({Gender})";
        }
    }
}
