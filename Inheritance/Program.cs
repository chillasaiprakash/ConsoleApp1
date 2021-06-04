using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class FullTimeEmployee
    //{
    //    string fname;
    //    string lname;
    //    string email;
    //    string yearlysalary;
    //}

    //class PartTimeEmployee
    //{
    //    string fname;
    //    string lname;
    //    string email;
    //    string hourlysalary;
    //}

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
    class PartTimeEmployee : Employee
    {
        public double hourlysalary;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Inheritance 
             * It is a kind of relationship between one or more classes, which allows to inherit code from one class to other
             */

            // base class is referred to as parent or super class
            // derived class is referred to as child class

            /* One of the advantage of inheritance is code re usability */

            // Single Inheritance
            // Hierarchical Inheritance
            // Multi Level Inheritance
            // Multiple Inheritance (not supported by .NET instead we have to go with interface to acheive this)

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.fname = "Anwesh";
            fte.lname = "P";
            fte.email = "anwesh.p@quadrantresource.com";
            fte.yearlysalary = 100000;

            Console.WriteLine(fte.fname);
            Console.WriteLine(fte.lname);
            Console.WriteLine(fte.email);
            Console.WriteLine(fte.yearlysalary);

            fte.PrintFullName();


            PartTimeEmployee pte = new PartTimeEmployee();
            pte.fname = "Anwesh1";
            pte.lname = "P1";
            pte.email = "anwesh.p1@quadrantresource.com";
            pte.hourlysalary = 800;

            Console.WriteLine(pte.fname);
            Console.WriteLine(pte.lname);
            Console.WriteLine(pte.email);
            Console.WriteLine(pte.hourlysalary);

            Console.ReadLine();

        }
    }
}
