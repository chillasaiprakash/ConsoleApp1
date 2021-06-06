using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a non - empty array, return true if there is a place to split the array so that
            //the sum of the numbers on one side is equal to the sum of the numbers on the other side.
            int[] split = new int[4];
            split[0] = 1;
            split[1] = 2;
            split[2] = 3;
            split[3] = 4;
            int n = split.GetLength(0);
            if (n % 2 == 0)
                Console.WriteLine("True");
            Console.ReadLine();

        }
    }

}
