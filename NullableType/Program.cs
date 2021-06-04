using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int nonNullnumber = 1;

            Console.WriteLine(nonNullnumber);

            int? nullNumber = null;

            Console.WriteLine(nullNumber);
            Console.ReadLine();
        }
    }
}
