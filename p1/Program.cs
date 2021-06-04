using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Q1.Given 2 positive int values, return the larger value that is in the range
            //10..20 inclusive, or return 0 if neither is in that range.
            int a = 9, b= 15,lar;
            if (a < b) 
                lar = b;
            else 
                lar = a;
            if (lar >= 10 && lar <= 20)
                Console.WriteLine("{0}", lar);
            else 
                Console.WriteLine("0");
            Console.ReadLine();

        }
    }
}
