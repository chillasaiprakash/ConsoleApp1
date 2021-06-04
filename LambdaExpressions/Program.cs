using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Lambda Expression - A lambda expression is an anonymous method
            // Properties of an anonymous method : 
            // No Access Modifier
            // No name
            // No return statement

            // Why : To achieve the same functionality using less lines of code or for convience

            Console.WriteLine(square(5));
            Console.WriteLine();

            // syntax : args => expression
            // () -> ....  // no args
            // x -> ....   // with one args
            // (x1, x2) -> .... // with multiple args

            // number => number * number;
            // () => {}
            // x => {}
            // (x1, x2, x3)

            // Example 1
            Func<int, int> squareLambda = number => number * number;
            Console.WriteLine(squareLambda(5));
            Console.WriteLine();


            // Example 2 ( FIndAll() )
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine("{0} ", num);
            }
            Console.WriteLine();

            //Example 3 ( Select() )
            List<Dog> dogs = new List<Dog>() {
                        new Dog { Name = "Rex", Age = 4 },
                        new Dog { Name = "Sean", Age = 0 },
                        new Dog { Name = "Stacy", Age = 3 }
            };

            var names = dogs.Select(x => x.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine();

            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });

            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("After applying sort by ascending");

            var sortedDogsAsc = dogs.OrderBy(x => x.Age);
            var sortedDogsAsc1 = dogs.OrderBy(x => x.Age);

            foreach (var dog in sortedDogsAsc)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
            }

            Console.WriteLine();
            Console.WriteLine("After applying sort by descending");

            var sortedDogsDesc = dogs.OrderByDescending(x => x.Age);

            foreach (var dog in sortedDogsDesc)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
            }

            Console.ReadLine();
        }

        static int square(int n)
        {
            return n * n;
        }
    }
}
