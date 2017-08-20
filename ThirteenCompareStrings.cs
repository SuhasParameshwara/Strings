using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirteenCompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first string: \n");
                string FirstString = Console.ReadLine();
                Console.WriteLine("\nEnter the second string: \n");
                string SecondString = Console.ReadLine();
                if (FirstString.CompareTo(SecondString) == 0)
                {
                    Console.WriteLine("\nBoth the strings are equal.");
                }
                else if(FirstString.CompareTo(SecondString) == 1)
                {
                    Console.WriteLine("\nFirst string is greater than second string.");
                }
                else
                {
                    Console.WriteLine("\nSecond string is greater than first string.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
