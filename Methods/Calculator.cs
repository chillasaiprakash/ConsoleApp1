using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int add(params int[] numbers)
        {
            int sum = 0;
            foreach(var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public void incrementWithoutRef(int j)
        {
            j = j + 1;
            Console.WriteLine("J value inside Called Method is " + j);
        }

        public void incrementWithRef(ref int j)
        {
            j = j + 1;
            Console.WriteLine("J value inside Called Method is " + j);
        }

        public void simpleMethodForOut(int i, int j, out int sum, out int product)
        {
            sum = i + j;
            product = i * j;
        } 
    }
}
