using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenBubbleSort
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
                int len = str.Length;
                char temp = '\0';
                for(int i = 0; i < len-1; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (strArray[i] > strArray[j])
                        {
                            temp = strArray[i];
                            strArray[i] = strArray[j];
                            strArray[j] = temp;
                        }
                    }
                }
                Console.WriteLine("\nBefore sorting the string: " + str);
                Console.Write("\nAfter sorting the string: ");
                for(int i = 0; i < len; i++)
                {
                    Console.Write(strArray[i]);
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
