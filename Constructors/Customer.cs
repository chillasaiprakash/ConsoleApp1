using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int id;
        public string name;

        public Customer()
        {
            Console.WriteLine("Default constructor is called");
        }

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

    }
}
