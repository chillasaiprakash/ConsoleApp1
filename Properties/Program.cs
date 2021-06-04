using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {

        public class Person
        {
            public string firstName { get; set; }
        }

        static void Main(string[] args)
        {
            // Property - It is a class member that encapsulates a getter / setter for accessing a field
            // Use - to create a getter and setter with less code

            /*
             * class Person
             * {
             *      private string name;
             *      
             *      public string name 
             *      {
             *          get { return name; }
             *          set { name = value; }
             *      }
             * }
             */

            /* accessModifier dataType variableName { get; set; } */

            Person p = new Person();
            p.firstName = "Anwesh";

            Console.WriteLine(p.firstName);
            Console.ReadLine();
        }
    }
}
