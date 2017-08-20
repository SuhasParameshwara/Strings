using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the first string: \n");
                string FirstStr = Console.ReadLine();
                Console.WriteLine("\nEnter the second string: \n");
                string SecondStr = Console.ReadLine();
                if (FirstStr == SecondStr)
                {
                    Console.WriteLine("\nBoth the strings are equal.");
                }
                else
                {
                    Console.WriteLine("\nBoth the strings are not equal.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid String");
            }
            Console.ReadLine();
        }
    }
}
