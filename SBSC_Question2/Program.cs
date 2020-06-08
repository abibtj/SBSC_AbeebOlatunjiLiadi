using System;
using System.Collections.Generic;

namespace SBSC_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to SBSC challenge Question 2.");
            Console.WriteLine("");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("Please, input a hyphen separated ordered list of integers.");

            string input = Console.ReadLine();

            Console.WriteLine("Please, enter an integer value of K: ");
            string _k = Console.ReadLine();
            int k = 0;
            List<int> intInputList = new List<int>();

            try
            {
                k = Convert.ToInt32(_k);

                var strInputArray = input.Split('-');

                foreach (var strInput in strInputArray)
                {
                    intInputList.Add(Convert.ToInt32(strInput));
                }

                ComputeAbsoluteValues(intInputList);

            }
            catch (FormatException)
            {
                Console.WriteLine($"Your input contains invalid number(s): {input} - K: {_k}");
            }
            catch (Exception)
            {
                //Console.WriteLine($"An error has occured, please try again.");
            }

            try
            {
                Console.WriteLine($"Output: {intInputList.ToArray()[k - 1]}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Output: -1");
            }
        }

        private static void ComputeAbsoluteValues(List<int> intInputList)
        {
            foreach (var number in intInputList)
            {
                var tempList = new List<int>();
                foreach (var num in intInputList)
                {
                    if (num != number)
                    {
                        tempList.Add(num);
                    }
                }

                for (int i = 0; i < tempList.ToArray().Length; i++)
                {
                    int absoluteDifference = Math.Abs(number - tempList[i]);
                    if (!intInputList.Contains(absoluteDifference))
                    {
                        intInputList.Insert(0, absoluteDifference);

                        ComputeAbsoluteValues(intInputList);
                    }
                }
            }
        }
    }
}