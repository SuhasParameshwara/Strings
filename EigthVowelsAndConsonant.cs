using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightVowelAndConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any string: \n");
                string str = Console.ReadLine();
                int countVowel = 0, countConsonant = 0;
                foreach (char ch in str.ToCharArray())
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    {
                        countVowel++;
                    }
                    else
                    {
                        countConsonant++;
                    }
                }
                Console.WriteLine("\nNumber of vowels in the strig is " + countVowel);
                Console.WriteLine("\nNumber of consonants in the string is " + countConsonant);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
