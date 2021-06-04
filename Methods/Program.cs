using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Signature of Methods
             * Method Overloading
             * Params modifier
             * Ref modifier
             * Out modifier
             */

            // Signature of a method
            // method name
            // number and type of parameters


            /* public class Point
             * {
             *      public void Move(int x, int y)
             *      {
             *      
             *      }
             * }
             */

            // Overloading Methods - method with same name and different signature
            /* public class Point
             * {
             *      public void move (int x, int y) {}
             *      public void move (Point newLocation) {}
             *      public void move (Point newLocation, int speed) {}
             * }
             */

            /*
             * public class Calculator
             * {
             *      public void Add(int x1, int x2);
             *      public void Add(int x1, int x2, int x3);
             *      public void Add(params );
             * }
             */

            // as an alternate for above example
            /* public class Calculator
             * {
             *      public void Add(int[] numbers) {}
             * }
             * 
             * var result = calc.Add(new int[] {1, 2, 3, 4, 5});        // problem is re-initialization
             */

            // Params modifier
            // as an alternate for above example
            /* public class Calculator
             * {
             *      public void Add(params int[] numbers) {}
             * }
             * 
             * var result = calc.Add(1, 2, 3, 4);        
             */

            // Ref modifier
            /* public class MyClass
             * {
             *      public void myMethod(int a)
             *      {   
             *          a += 2;
             *      }
             * }
             *
             *
             * var a = 1;
             * myClass.myMehtod(a);     // Output will we 1
             * public class MyClass
             * {
             *      public vodi myMethod(ref int a)
             *      {
             *          a += 2;
             *      }
             *      
             * }
             * 
             * var a = 1;
             * myClass.myMethod(ref a);
             */


            Calculator calc = new Calculator();


            var twoParamsResult = calc.add(1, 2);

            Console.WriteLine("method overriding with two params result : {0}", twoParamsResult);

            var threeParamsResult = calc.add(1, 2, 3);

            Console.WriteLine("method overriding with three params result : {0}", threeParamsResult);

            var paramsParameterResult = calc.add(1, 2, 3, 4, 5);

            Console.WriteLine("method overriding with params keyword result : {0}", paramsParameterResult);


            var a = 1;
            Console.WriteLine("a value before Calling incrementWithoutRef() " + a);
            calc.incrementWithoutRef(a);
            Console.WriteLine("a value after Calling incrementWithoutRef() " + a);

            //Console.WriteLine("wihtout ref keyword result : {0}", withOutRefResult);
            Console.WriteLine("a value before Calling incrementWithRef() " + a);
            calc.incrementWithRef(ref a);
            Console.WriteLine("a value after Calling incrementWithRef() " + a);

            //Console.WriteLine("with ref keyword result : {0}", withRefResult);

            int i = 1, j = 2, sum = 0, product = 0;
            calc.simpleMethodForOut(i, j, out sum, out product);
            Console.WriteLine("Sum with out keyword : {0}", sum);
            Console.WriteLine("Product with out keyword : {0}", product);

            Console.ReadLine();
        }
    }
}


