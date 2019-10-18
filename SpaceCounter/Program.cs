using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string userSentence;
            Console.WriteLine("Write a random sentence, please.");
            userSentence = Console.ReadLine();
            CountSpaces(userSentence);

        }
        public static void CountSpaces(string sentence)
        {
            int counter = 0;
            foreach(char symbol in sentence)
            {
                if(symbol == ' ')
                {
                    counter++;
                }

            }
            Console.WriteLine($"There are {counter} spaces in your sentence.");
            Console.ReadLine(); 


        }
    }
}
