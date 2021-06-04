
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysWithUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter row Size of array or matrix:");
            int rowSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter col Size of array or matrix:");
            int colSize = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[rowSize, colSize];

            /* Stored values into the array*/
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < arr1.GetLength(1); j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");

            Console.ReadLine();
        }
    }
}