using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            // syntax for using if
            // if (expressionToBeEvaluated)
            // {
            //      .....
            // }

            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }

            // syntax for using if else
            // if (expressionToBeEvaluated)
            // {
            //      .....
            // }
            // else
            // {
            //      .....
            // }

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else 
            {
                Console.WriteLine("It's Night");
            }

        }
    }
}
