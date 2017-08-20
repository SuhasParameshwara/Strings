using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSeparateChar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name: \n");
                string str = Console.ReadLine();
                int i = 1;
                foreach(char ch in str.ToCharArray())
                {
                    Console.WriteLine("\nCharacter {0} is {1}", i++, ch);
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
