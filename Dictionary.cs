using System;
using System.Collections.Generic;

namespace Dictionnaires
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();

            dictionary['a'] = new List<string> { "Alakhazam", "Astragan", "Arrestation" };
            dictionary['b'] = new List<string> { "Barbiturique", "Balbutiement", "Bedouin" };
            dictionary['c'] = new List<string> { "Caractère", "Croquant", "Circonscription" };


            foreach (char key in dictionary.Keys)
            {
                foreach (string item in dictionary[key])
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            dictionary.Remove('c');
            Console.WriteLine();

            foreach (char key in dictionary.Keys)
            {
                foreach (string item in dictionary[key])
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }
        }

       
    }
}
