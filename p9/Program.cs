using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p9
{
    //How to find all possible substring of a given string
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string String = Console.ReadLine();

            Console.WriteLine("All substrings for given string are : ");

            for (int i = 0; i < String.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(String.Length - i);
                for (int j = i; j < String.Length; ++j)
                {
                    subString.Append(String[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
