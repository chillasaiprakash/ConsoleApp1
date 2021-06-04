using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sample
{

    namespace returning_array
    {
        //Given an int array of any length, return a new array of its first 2 elements.
        //If the array is smaller than length 2, use whatever elements are present.
        class Program
        {
            public int Front(params int[] nums)
            {
                int[] arr2 = new int[4];
                if (nums.Length > 2)
                {
                    //arr2 = new int[2];
                    arr2[0] = nums[0];
                    arr2[1] = nums[1];


                    return arr2[0] + arr2[1];

                }
                else
                {
                    arr2 = new int[1];
                    arr2[0] = nums[0];
                    return arr2[0];
                }
            }

            static void Main(string[] args)
            {
                int[] nums = new int[4];
                nums[0] = 1;
                nums[1] = 2;
                nums[2] = 3;
                nums[3] = 4;
                Program p = new Program();
                Console.WriteLine("values is{0}", p.Front(nums));
                Console.ReadLine();
            }

        }
    }
}