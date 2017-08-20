using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourteenCompareSetStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                Console.WriteLine("\nEnter the number of strings to compare with the given string: \n");
                int size = int.Parse(Console.ReadLine());
                string[] strArray = new string[size];
                for(int i = 0; i < strArray.Length; i++)
                {
                    Console.WriteLine("\nEnter the string {0}\n", i + 1);
                    string temp = Console.ReadLine();
                    if (str.Equals(temp))
                    {
                        Console.WriteLine("\nBoth the strings are equal.");
                    }
                    else
                    {
                        Console.WriteLine("\nBoth the string are not equal.");
                    }
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
