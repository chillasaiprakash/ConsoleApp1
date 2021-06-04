using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    class Program
    {
        // Multi level Inheritance:The process of deriving a new class by already derived 
        // class is called as multi-level inheritance
        class Employee
        {
            public string fname;
            public string lname;
            public string email;
        }
        class FullTimeEmployee : Employee
        {
            public string NatureOfWork;
            public double yearlysalary;
            public void PrintFullName()
            {
                Console.WriteLine("Full Name:" + fname + " " + lname);
            }
        }
        class EmployeeOfTheYear : FullTimeEmployee
        {
            public string achievements;
            public void EmployeeAchievements()
            {
                Console.WriteLine("Full Name:" + fname + " " + lname + " " + achievements);
            }
        }

        static void Main(string[] args)
        {
            //////Multilevel Inheritance
            EmployeeOfTheYear fte = new EmployeeOfTheYear();
            fte.fname = "Anwesh";
            fte.lname = "P";
            fte.email = "anwesh.p@quadrantresource.com";
            fte.yearlysalary = 1000000;
            fte.NatureOfWork = "Developer";
            fte.achievements = "Completed all task in time";
            fte.EmployeeAchievements();
            Console.ReadLine();
        }
    }
}
