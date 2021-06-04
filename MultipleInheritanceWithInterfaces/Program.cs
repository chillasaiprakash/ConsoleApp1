using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceWithInterfaces
{
    // Multiple Inheritance throught the interfaces
    // syntax: accessModifier interface <nameOfTheInterface> ICOllection (or) IDictionary
    // {

    // }
    public interface Interface1
    {
        void Add();
    }
    public interface Interface2
    {
        void Add();
    }
    public class MyDerivedClass : Interface1, Interface2
    {
        void Interface1.Add()
        {
            Console.WriteLine("You are in interface1 Add method");
        }
        void Interface2.Add()
        {
            Console.WriteLine("You are in interface2 Add method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////Multiple Inheritance 
            MyDerivedClass myclass = new MyDerivedClass();
            //Here with explicit interface method call we can tell the compiler to call 
            // Add() from iterface1 and intterface2
            ((Interface1)myclass).Add();
            ((Interface2)myclass).Add();
            Console.ReadLine();

        }
    }
}