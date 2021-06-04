using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // What is Array
            // - An Array is a data structure which is used to collect/store variables of same data type
            // - Array will have fixed size and size has to be specified while array declartion only
            // 

            // int number1;
            // int number2;
            // int number3;

            // Declaring Arrays
            // Intializing Arrays
            // datatype[] arrayName = new dataType[size];
            int[] numbers = new int[3];

            // Accessing array elements
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Alternate way of array declaration and assigning values
            int[] numbers2 = new int[3] { 1, 2, 3 };

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(numbers2[2]);

            var names = new string[3] { "name1", "name2", "name3" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.ReadLine();
        }
    }
}
