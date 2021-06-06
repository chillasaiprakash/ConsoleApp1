using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p7
{
    class Program
    {
        static void Main(string[] args)
        {
            string normal = "sai";
            string rev ="";
            int s = normal.Length;
            for (int j = s - 1; j>= 0; j--)
                {
                rev += normal[j];
                }
            Console.WriteLine(rev);
            Console.ReadLine();
        }
    }
}
