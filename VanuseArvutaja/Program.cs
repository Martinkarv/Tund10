using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanuseArvutaja
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearofBirth;
            Console.WriteLine("Tere,sisesta oma sünniaasta palun.");
            yearofBirth = int.Parse(Console.ReadLine());
            Vanus(yearofBirth);
            Console.ReadLine();
        }

        public static void Vanus(int yearofBirth)
        {
            Console.WriteLine($"Te olete {2019 - yearofBirth} aastat vana.");
        }
    }
}
