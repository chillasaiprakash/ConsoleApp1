using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List - if you were not aware of the length of elements at the time of initialization at that we will go with list.
            //Array - Fixed size
            //List - Dynamic size
            //Syntax - collectionType<dataType> collectionName = new collectionsType<dataType>();
            //List<int> numbers = new List<int>();
            //<int> - Here angular brackets indicates it is of Generic Collection

            List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            //Usefull methods
            //Add() - to add / insert an element into list
            //AddRange() - to add mutiple elements into list
            //Remove() - to remove an element from list
            //RemoveAt() - to remove an element at specific index
            //IndexOf() - to get the index of an element from list
            //Contains() - to check if an element already exists within the list
            //Count - to get the size of the list

            numbers.Add(5);

            Console.WriteLine("Effect of Add()");
            foreach (var item in numbers) Console.WriteLine(item);



            numbers.AddRange(new int[] { 6, 7, 8 });

            Console.WriteLine("Effect of AddRange()");
            foreach (var item in numbers) Console.WriteLine(item);


            numbers.Remove(5);

            Console.WriteLine("Effect of Remove()");
            foreach (var item in numbers) Console.WriteLine(item);

            numbers.RemoveAt(6);

            Console.WriteLine("Effect of RemoveAt()");
            foreach (var item in numbers) Console.WriteLine(item);

            int index = numbers.IndexOf(2);
            Console.WriteLine("Effect of IndexOf()");
            Console.WriteLine("index of 2 is {0}", index);

            bool isElementExists = numbers.Contains(7);
            Console.WriteLine("Effect of Contains()");
            Console.WriteLine("Is Element 7 exists within the list {0} ", isElementExists);

            Console.WriteLine("Effect of Count");
            Console.WriteLine("Size/ Count of numbers list is: ", numbers.Count);

            Console.ReadLine();
        }
    }
}
