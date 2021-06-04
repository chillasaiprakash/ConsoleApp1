using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arthimetic Operators
            //          Operator            Example
            //add           +               a + b
            //subtract      -               a - b
            //multiply      *               a * b
            //Divide        /               a / b   - Dividend
            //Remainder     %               a % b   - Remainder
            //Increment     ++              a = a + 1 (or) a += 1
            //Decrement     --              a = a - 1 (or) a -= 1

            var a = 6;
            var b = 3;
            var c = 1;

            Console.WriteLine("---------Arthimetic Operator------------");
            Console.WriteLine(a + b);   //9
            Console.WriteLine(a - b);   //3
            Console.WriteLine(a * b);   //27
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            // If you wanted to get a float value as result following is the example
            Console.WriteLine((float)a / (float)b);  // Example of Type Conversion
           

            // Operator Precedence

            // Example 1 - Highest precedence in below expression is *
             //()
             ///or %
             // *
            Console.WriteLine( a + b * c);
            // Execution, since * has the highest priority first b * c will be calcultated
            // and then the result will be added to a variable

            // Example 2 - Highest precedence in below expression is ()
            Console.WriteLine( (a + b) * c);

            //Comparison operators
            //Equal                         ==          a == b
            //Not Equal                     !=          a != b
            //Greater than                  >           a > b
            //Greather than or equal to     >=          a >= b
            //Less than                     <           a < b
            //Less than or equal to         <=          a <= b


            Console.WriteLine("---------Comparison Operator------------");
            
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));

            //Assignment operators
            //Assignment                    =           a = 1


            //Logical operators   (most commoly used)
            //And            &&              a && b
            //or             ||              a || b
            //Not             !               !a

            // 1 && 1 is 1
            // - T && T - T
            // - F && T - F
            // - T && F - F

            // 0 || 0 is 0
            // - F || F - F
            // - T || F - T
            // - F || T - T

            a = 1;
            b = 2;
            c = 3;

            Console.WriteLine("---------Logical Operator------------");

            Console.WriteLine(c > b && c > a);  // T && T => T
            Console.WriteLine(c > b && c == a); // T && F => F
            Console.WriteLine(c > b || c > a);  // T || T => T
            Console.WriteLine(c < b || c < a);  // F || F => F

            // Terenary Operator ( ?: )

            Console.WriteLine("---------Terenary Operator------------");

            var result = c > b ? a : b;    // if the value of c is greater than b, then a value will be stored in result or else b will be stored

            Console.WriteLine(result);
            Console.ReadLine();
            // Comments in .NET

            // An Example of Single Line Comment
            
            /*
             * An Example of Multi Line Comment 
             */
        }
    }
}
