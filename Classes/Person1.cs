using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person1
    {
        public string firstName; // variable
        public string lastName;  // variable

        public void Introduce()  // method
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }
    }
}
