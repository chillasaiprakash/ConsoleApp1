using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given 2 strings, a and b, return a string of the form short+long + short, with the shorter string on the outside and the longer string on the inside.
            //The strings will not be the same length, but they may be empty(length 0).
            string firstname = "prakash";
            string secondname = "sai";
            string large;
            int length1 = firstname.Length;
            int length2 = secondname.Length;
            if(length1<length2)
                Console.WriteLine("{0}+{1}+{2}", firstname, secondname, firstname);
            else
                Console.WriteLine("{0}+{1}+{2}", secondname, firstname,secondname);
            Console.ReadLine();



        }
    }
}
