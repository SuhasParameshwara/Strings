using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixCount
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                char[] strArray = str.ToCharArray();
                int countDigit = 0, countAlpha = 0, countSpecialChar = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsDigit(strArray[i]))
                    {
                        countDigit++;
                    }
                    else if (Char.IsLetter(strArray[i]))
                    {
                        countAlpha++;
                    }
                    else
                    {
                        countSpecialChar++;
                    }
                }
                Console.WriteLine("\nNumber of alphabets in the string is {0}", countAlpha);
                Console.WriteLine("\nNumber of digits in the string is {0}", countDigit);
                Console.WriteLine("\nNumber of special characters in the string is {0}", countSpecialChar);
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid String!");
            }
            Console.ReadLine();
        }
    }
}
