using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number = Console.ReadLine();
            int n = Convert.ToInt32(number);
            Console.WriteLine("Given number is {0}", n);
            Console.ReadLine();
        }
    }
}
