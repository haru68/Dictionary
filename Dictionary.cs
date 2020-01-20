using System;
using System.Collections.Generic;

namespace Dictionnaires
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> dictionary = new Dictionary<string, char>();

            dictionary["FirstLetter"] = 'a';
            dictionary["SecondLetter"] = 'b';
            dictionary["ThirdLetter"] = 'c';

            foreach (KeyValuePair<string, char> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key, kvp.Value);
            }

            dictionary.Remove("SecondLetter");

            foreach (KeyValuePair<string, char> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key, kvp.Value);
            }
        }

       
    }
}
