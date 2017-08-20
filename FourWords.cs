using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the name\n");
                string name = Console.ReadLine();
                string[] nameArray = name.Split(' ');
                Console.WriteLine("\nThe number of words is " + nameArray.Length);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
