using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListComplexTypeSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            numbersList.Sort();

            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 4500
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Hina",
                Gender = "Female",
                Salary = 7500
            };
            Employee emp6 = new Employee()
            {
                ID = 106,
                Name = "Tarun",
                Gender = "Male",
                Salary = 6000
            };
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);
            listEmployees.Add(emp5);
            listEmployees.Add(emp6);
            Console.WriteLine("Employees before sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            listEmployees.Sort();

            Console.WriteLine("Employees After sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }


            SortByName sortByName = new SortByName();
            listEmployees.Sort(sortByName);
            Console.WriteLine("Employees After sorting using sortByName class");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }

            Console.ReadLine();
        }
    }
}
