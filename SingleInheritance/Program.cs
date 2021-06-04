using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritance
{
    //Single Inheritance:The process of deriving new class by using one existing class is 
    //called as single inheritance.


    class Employee
    {
        public string fname;
        public string lname;
        public string email;
    }
    class FullTimeEmployee : Employee
    {
        public double yearlysalary;
        public void PrintFullName()
        {
            Console.WriteLine("Full Name:" + fname + " " + lname);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.fname = "Anwesh";
            fte.lname = "P";
            fte.email = "anwesh1729@gmail.com";
            fte.yearlysalary = 1000000;
            fte.PrintFullName();
            Console.ReadLine();

        }
    }
}
