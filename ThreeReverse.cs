using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name: \n");
                string name = Console.ReadLine();
                char[] nameArray = name.ToCharArray();
                int len = name.Length;
                Console.WriteLine("\nReversed order\n");
                for(int i=0; i < len; i++)
                {
                    Console.WriteLine("\n" + nameArray[len - (i + 1)]);
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
