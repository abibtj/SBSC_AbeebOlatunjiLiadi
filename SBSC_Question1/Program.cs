using System;
using System.Collections.Generic;

namespace SBSC_Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to SBSC challenge Question 1.");
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("Please, input a hyphen separated numbers.");

            string input = Console.ReadLine();

            try
            {
                var strInputArray = input.Split('-');
                List<int> intInputList = new List<int>();
                bool output = true;

                foreach (var strInput in strInputArray)
                {
                    intInputList.Add(Convert.ToInt32(strInput));
                }

                for (int i = intInputList.ToArray().Length - 1; i > 1; i--)
                {
                    if ((intInputList[i] - intInputList[i - 1]) != (intInputList[i - 1] - intInputList[i - 2]))
                    {
                        output = false;
                    }
                }

                Console.WriteLine($"Output: {output}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Your input contains invalid number(s): {input}");
            }
            catch (Exception)
            {
                Console.WriteLine($"An error has occured, please try again.");
            }
        }
    }
}
