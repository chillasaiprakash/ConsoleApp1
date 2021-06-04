using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public class Person
        {
            public string firstName; // variable
            public string lastName;  // variable

            public void Introduce()  // method
            {
                Console.WriteLine("My name is {0} {1}", firstName, lastName);
            }
        }

        static void Main(string[] args)
        {
            //Class - Person is the new class that is created

            //Creating objects
            // Synatx : ClassName instanceName = new ClassName();
            // Eg : Person person = new Person();

            Person person = new Person();
            person.firstName = "Anwesh";
            person.lastName = "P";
            person.Introduce();

            Person1 person1 = new Person1();
            person1.firstName = "Anwesh";
            person1.lastName = "P";
            person1.Introduce();


            Calculator calulator = new Calculator();
            var additionResult = calulator.add(1, 2);
            Console.WriteLine(additionResult);

            //Use of static keyword

            //static keyword is used to call a method/variable without
            //creating an issue for an exisiting class

            var subtractionResult = Calculator2.sub(2, 1);
            Console.WriteLine(subtractionResult);
            Console.ReadLine();
        }
    }
}
