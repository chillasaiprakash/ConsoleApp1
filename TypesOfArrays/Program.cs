using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            //Syntax : datatype[] variablename = new datatype[sizeofarray];
            //Eg : var numbers = new int[size];

            //Mutli Dimension Array 
            //Syntax : datatype[] variablename = new datatype[rowSize, colSize];
            //Eg: var matrix = new int[3,5]; // int[] matrix = new int[3,5];
            //Eg: var matrix = new int[3,5]
            //{
            //  {1,2,3,4,5},
            //  {1,2,3,4,5},
            //  {1,2,3,4,5}
            //}

            Console.WriteLine("Multi Dimensonal Array Output");

            var multiDimesionArray = new int[3, 5]
            {
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 },
                {1, 2, 3, 4, 5 }
            };

            for (int i = 0; i < multiDimesionArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimesionArray.GetLength(1); j++)
                {
                    Console.WriteLine("Element at {0}{1} is: {2}", i, j, multiDimesionArray[i, j]);
                }
            }


            Console.WriteLine("Multi Dimensonal Array Output");

            var jaggedArray = new int[3][]; //int[] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[2] = new int[2] { 1, 2 };

            //int[][] jagged_arr = new int[][]
            //    {
            //        new int[] {1, 2, 3, 4},
            //        new int[] {11, 34, 67},
            //        new int[] {89, 23},
            //        new int[] {0, 45, 78, 53, 99}
            //};

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine("Element at {0}{1} is: {2}", i, j, jaggedArray[i][j]);
                }
            }


            //for accessing the elements : matrix[rowIndex, colIndex] 
            //eg : var element = matrix[0, 0];

            //Jagged Array (array of arrays)
            // Eg: var newArray = new int[3][];
            // newArray[0] = new int[3];
            // newArray[1] = new int[4];
            // newArray[2] = new int[2];

            //for accessing elements - newArray[0][1]


            //Syntax Difference between Jagged and Rectangular Arrays
            //Jagged Array - var matrix = new int[3][]
            //Rectangular Array - var matrix = new int[3, 5]

            //Some of the useful methods in Array
            //Length - Property
            //Clear()
            //Copy()
            //IndexOf()
            //Reverse()
            //Sort()


            var numbers = new int[] { 5, 4, 8, 4, 2, 0, 9, 1 };

            //Length - returns the size of the array

            Console.WriteLine("Length of numbers array is {0} : ", numbers.Length);

            //IndexOf() - to find position of the element in the array

            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is {0}: ", index);

            //Clear()
            Array.Clear(numbers, 0,2);

            Console.WriteLine("Effect of Clear() method");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            var newNumbersArray = new int[3];
            //Copy() to the array
            Array.Copy(numbers, newNumbersArray, 3);

            Console.WriteLine("Effect of Copy() method");
            foreach (var item in newNumbersArray)
            {
                Console.WriteLine(item);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort() method");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse() method");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
