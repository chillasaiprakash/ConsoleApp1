using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithoutInterfaces
{
    // Multiple Inheritance:The process of deriving new class by more than one base 
    // classes is called as multiple inheritance
    // C# doesn't support multiple inheritance
    // The reason for that is,if more than one base class having same method or property 
    // or filed name C# compiler will get ambiguity
    // to make call of the methods or properties or fileds

    //This problem is called as dimond problem
    //Following is the example to explain the issue with classes of multiple inheritance
    public class class1
    {
        public void Add()
        {
            Console.WriteLine("Class 1 Add method");
        }
    }
    public class class2
    {
        public void Add()
        {
            Console.WriteLine("Class 2 Add method");
        }
    }
    public class MyDerivedClass : class1
    //public class MyDerivedClass : class1, class2
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Multilevel Inheritance
            MyDerivedClass d = new MyDerivedClass();
            // Here compiler get ambiguity to call Add() method,whether it needs to call 
            // from class1 or class2
            // So to avaoid this complexity microsoft decided not to support multiple 
            // inheritance in C#.
            // d.Add();

            Console.ReadLine();
        }
    }
}
