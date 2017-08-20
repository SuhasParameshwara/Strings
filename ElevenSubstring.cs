using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                char[] strArray = str.ToCharArray();
                Console.WriteLine("\nEnter the start Index: \n");
                int startIndex = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the end Index: \n");
                int endIndex = int.Parse(Console.ReadLine());
                if (startIndex < 0 || endIndex < 0 || startIndex > str.Length || endIndex > str.Length)
                {
                    Console.WriteLine("Invalid start index or end index!");
                }
                else
                {
                    Console.Write("\nThe string between {0} and {1} is ", startIndex, endIndex);
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        Console.Write(strArray[i]);
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
