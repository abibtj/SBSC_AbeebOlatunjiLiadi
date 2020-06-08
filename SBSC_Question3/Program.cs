using System;
using System.Collections.Generic;
using System.Text;

namespace SBSC_Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to SBSC challenge Question 3.");
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("Please, input a word.");

            string input = Console.ReadLine();
            var inputCharArray = input.ToCharArray();

            try
            {
                Dictionary<char, int> dictionary = new Dictionary<char, int>();
                foreach (var character in inputCharArray)
                {
                    if (dictionary.ContainsKey(character))
                    {
                        dictionary[character] = dictionary[character] + 1;
                    }
                    else
                    {
                        dictionary.Add(character, 1);
                    }
                }

                string output = string.Empty;

                foreach (var item in dictionary)
                {
                    output += item.Key.ToString() + item.Value;
                }

                Console.WriteLine($"Output: {output}");
            }
            catch (Exception)
            {
                Console.WriteLine($"An error has occured, please try again.");
            }
        }
    }
}
