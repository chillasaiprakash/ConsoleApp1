using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /* constructor - it is a method which have the same name as class name
             and constructor will be called whenever an object or instance of a class is created. */

            // use of constructor - to assign/intiliaze values to varibles of a class

            // Constructor is a special method which will not have any return type

            // Parameter less or Default Constructor
            /* public class Customer
             * {
             *      public Customer()
             *      {
             *
             *      }
             *  }
             */

            // this - it is used refer any variable / method within a class in which this keyword is defined

            // Parameterised constructor
            /* public class Customer
             * {
             *      string name;
             *      public Customer(string name)
             *      {
             *          this.name = name;
             *      }
             *  }
             */

            /*
             * Customer newCustomer = new Customer("Anwesh");
             */

            /*  Constructor Overloading - Overloading means having a method with same but with different signature
             *  public class Customer
             *  {
             *      public Customer() {....}
             *      public Customer(string name) {.....}
             *      public Customer(int id, string name) {....}
             *  }
             */

            Customer customer = new Customer();

            Console.WriteLine("Default Constructor output");
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);

            Customer customer1 = new Customer(1);
            Console.WriteLine("Paremeterized Constructor with single param output");
            Console.WriteLine(customer1.id);
            Console.WriteLine(customer1.name);

            Customer customer2 = new Customer(1, "Anwesh");
            Console.WriteLine("Paremeterized Constructor with muliple param output");
            Console.WriteLine(customer2.id);
            Console.WriteLine(customer2.name);

            //Object intializer is an alternate for constructor

            Customer customer3 = new Customer { id = 3, name = "Anwesh3" };
            Console.WriteLine("Object Intializers output");
            Console.WriteLine(customer3.id);
            Console.WriteLine(customer3.name);

            Console.ReadLine();
        }
    }
}
