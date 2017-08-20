using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                Dictionary<char, int> dictionary = new Dictionary<char, int>();
                int max = 0;
                foreach (char ch in str.ToCharArray())
                {
                    if (dictionary.ContainsKey(ch))
                    {
                        int val = dictionary[ch] + 1;
                        dictionary[ch] = val;
                        if (val > max)
                        {
                            max = val;
                        }
                    }
                    else
                    {
                        dictionary.Add(ch, 1);
                    }
                }
                foreach (char ch in dictionary.Keys)
                {
                    if (dictionary[ch] == max)
                    {
                        Console.WriteLine("\n{0} is the maximum occuring character in the string.", ch);
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
