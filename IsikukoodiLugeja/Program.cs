using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsikukoodiLugeja
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearofBirth;
            string id;
            Console.WriteLine("Enter your ID code, please.");
            id = Console.ReadLine();
            bool idValid;
            idValid = CheckIDLength(id);
            if (idValid)
            {
                Console.WriteLine("OK.");
                GetGender(id);
                GetYear(id);
            }
            else
            {
                Console.WriteLine("Not OK.");
            }
            
            Console.ReadLine();
        }
        public static void GetGender(string idCode)
        {
            int firstNumber = int.Parse(idCode[0].ToString());
            if (firstNumber == 4 || firstNumber == 6)
            {


                Console.WriteLine("Hello, Madam!");
            }
            else
            {
                Console.WriteLine("Hello, Sir!");
            }

        }


        public static bool CheckIDLength(string idCode)
        {
            bool isValid;
            if (idCode.Length == 11)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }
        public static void GetYear(string idCode)
            {
            string year = idCode.Substring(1, 2);
            Console.WriteLine($"Your year of birth is {year}.");
            string fullYear = $"20{year}.";
            }
    }
}
