using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10
{

    //How to perform Left circular rotation of an array
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 8 };
            foreach(var item in nums)
            Console.WriteLine("\nArray1: [{0}]", item);
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            foreach (var item in nums)
            Console.WriteLine("\nAfter rotating array becomes: [{0}]",item);
            Console.ReadLine();
        }
    }
}
