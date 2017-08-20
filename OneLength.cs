using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneLength
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.WriteLine("Enter the name: \n");
                String str = Console.ReadLine();
                int len = 0;
                foreach (char c in str.ToCharArray())
                {
                    len++;
                }
                Console.WriteLine("\nThe length of the string is {0}", len);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
