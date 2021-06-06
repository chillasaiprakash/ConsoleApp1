using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p8
{
    class Program
    {
        //How to remove duplicate characters from a string
        static void Main(string[] args)
        {
 
            Console.Write("Enter a String : ");
            string duplicate = Console.ReadLine();
            string unique = "";
            for (int i = 0; i < duplicate.Length; i++)
            {
                if (!unique.Contains(duplicate[i]))
                {
                    unique += duplicate[i];
                }
            }
            Console.WriteLine(unique);
            Console.ReadLine();
        }
    }
}
