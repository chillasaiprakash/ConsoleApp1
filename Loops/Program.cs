using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration statments or Loops : If we want to execute a block of code untill a specfic condition meets.
            // For loops
            // Foreach loops
            // While loops
            // Do-While loops

            // For loops
            // Syntax:
            // for (var i = 0 ; i < 10 ; i ++ )
            // {    // initialization clause ; condition clause ; iteration clause
            //      ..
            // }

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (var i = 10; i <= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Foreach loops
            // Syntax:
            // foreach (var item in numbers)
            // {
            //      ...
            // }

            var name = "Anwesh P";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 1, 2, 3, 4 };

            for (var i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // While loop (Entry control loop)
            // Syntax: 
            // while (i < 10)
            // {    
            //      ...
            //      i++;
            // }

            var j = 0;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            // do while loops (Exit control loop)
            // do
            //  {
            //      ...
            //      i++;
            //  } while ( i < 10);

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10); 

            // break : if you want break the loop execution
            // continue : jumps to next iteration.

            for(var i = 0; i <= 5; i++)
            {
                if(i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (var i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
