using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string name = Console.ReadLine();
                string temp = name;
                Console.WriteLine("\n"+temp);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid String!");
            }
            Console.ReadLine();
        }
    }
}
