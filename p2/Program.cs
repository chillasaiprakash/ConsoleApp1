using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of ints, return true if one of the first 4 elements in the array is a 9.The array length may be less than 4.
            int[] arr = new int[4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("element -{0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.GetLength(0);i++)
            {
                if (arr[i] == 9)
                    Console.WriteLine("True");
                
            }
            Console.ReadLine();


        }
    }
}
