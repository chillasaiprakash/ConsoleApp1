using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Coordinate
    {
        public int x;
        public int y;


        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetOrigin()
        {
            this.x = 0;
            this.y = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tell what is value type and reference type from the below link.
            // https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type

            //struct can be used to hold small data values that do not require inheritance.
            //It can contain a parameterized constructor, static constructor, constants, fields, methods, properties

            /*struct Coordinate
             * {
             * public int x;
             * public int y;
             * }
             * }
             */

            Coordinate point = new Coordinate();
            Console.WriteLine(point.x); //output: 0  
            Console.WriteLine(point.y); //output: 0  

            Coordinate point0;
            //Console.Write(point0.x); // Compile time error  

            point0.x = 10;
            point0.y = 20;
            Console.Write(point0.x); //output: 10  
            Console.Write(point0.y); //output: 20 

            Coordinate point1 = new Coordinate(10, 20);

            Console.WriteLine(point1.x); //output: 10  
            Console.WriteLine(point1.y); //output: 20  

            point1.SetOrigin();

            Console.ReadLine();
        }

    }

}
