using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund10
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string userAnswer;
            string sugu;
            Console.WriteLine("Kas te olete tulemas või lahkumas?");
            userAnswer = Console.ReadLine();
            Console.WriteLine("Kas te olete mees või naine?");
            sugu = Console.ReadLine();
            if(userAnswer.ToLower() == "tulemas")
                {
                Tervist(sugu);
               
                }
            else
            {
                Nägemist(sugu);
                
            }

            Console.ReadLine();
        }
           
            public static void Tervist(string sugu)
                {
                Console.WriteLine($"Tervist {sugu}!");
                }

            public static void Nägemist(string sugu)
            {
            Console.WriteLine($"Head aega {sugu}!");
            }
            
    }
}
