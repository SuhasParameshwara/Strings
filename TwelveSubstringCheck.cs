using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveSubstringCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                Console.WriteLine("\nEnter the substring: \n");
                string subStr = Console.ReadLine();
                if (str.Contains(subStr))
                {
                    Console.WriteLine("\nThe substring is present in the string.");
                }
                else
                {
                    Console.WriteLine("\nThe substring is not present in the string.");
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
