using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    class Program
    {
        partial class Customer
        {
            //Fields
            public string _firstName;
            public string _lastName;
            // (Default Constructor)
            public Customer()
            {
                _firstName = "Anwesh";
                _lastName = "P";
            }
            public void PrintFirstName()
            {
                Console.WriteLine("First Name : {0}", _firstName);

            }
        }


        partial class Customer
        {
            public void PrintLastName()
            {
                Console.WriteLine("Last Name : {0}", _lastName);

            }
        }

        static void Main(string[] args)
        {
            //Partial Class (Spilt the functionality in to two or more classes) 
            Customer d = new Customer();
            //runtime compiler clubs all the methods in to single class
            d.PrintFirstName();
            d.PrintLastName();
            Console.ReadLine();
        }
    }
}
