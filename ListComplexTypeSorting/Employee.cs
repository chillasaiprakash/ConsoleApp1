using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListComplexTypeSorting
{
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee newEmployee)
        {
            if (this.Salary > newEmployee.Salary)
            {
                return 1;
            }
            else if (this.Salary < newEmployee.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            //return this.Salary > newEmployee.Salary ? 1 : (this.Salary < newEmployee.Salary ? -1 : 0); 
        }
    }

    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
