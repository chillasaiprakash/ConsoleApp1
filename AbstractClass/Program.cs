using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Customer
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
        public abstract void PrintFullName();

        public static int add(int a , int b)
        {
            return a + b;
        }
    }

    class DerivedCustomer : Customer
    {
        public override void PrintFullName()
        {
            Console.WriteLine("First name is {0} Last Name is {1}", base._firstName, base._lastName);
        }

        public int add(int a,int b)
        {
            return a + b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            /* An Abstract class is an incomplete class or special class we can't instantiate. 
             * We can use an Abstract class as a Base Class.
             * An Abstract method must be implemented in the non-Abstract class using the override keyword.
             * After overriding the abstract method is in the non-Abstract class.
             */

            //abstarct Class doesn't support object creation
            //Customer c = new Customer();
            DerivedCustomer d = new DerivedCustomer();
            d.PrintFullName();
            d.add(2, 3);
            Console.ReadLine();
        }
    }
}
