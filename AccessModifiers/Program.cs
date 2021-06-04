using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Access Modifier - It is a way to control access of a class or its members to the outside classes.
            // To provide safety to the members of a class 
            // Encapsulation - It is a process of limiting / Controlling the access of a class or its members to the outside classes

            /*
             * Public - Accessible to everyone (to outside classes)
             * Private  - Accessible only within the class 
             * Protected  - Accessible to the class in which it is defined also accessible within its child class
             * Internal Protected   - Accessible with in the class and to its child which is inside same assembly
             * Protected Internal   - Accessible with in the class and to its child child class which is in a new assembly
             */

            // In general
            // fields will be specifed as private
            // provide getters / setter methods as public
            // Setter - it is a method which is used assign value to a variable
            // Getter - it is a method which is read/ retreive value from a variable

            Person p = new Person();
            p.setName("Anwesh");
            Console.WriteLine(p.getName());

            Console.ReadLine();
            
        }
    }
}
