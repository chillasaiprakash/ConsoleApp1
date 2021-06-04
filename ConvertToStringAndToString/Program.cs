using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToStringAndToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert.ToString()
            //ToString()

            /* Both these methods are used to convert a value to string. 
             * The difference is Convert.ToString() method handles null whereas the ToString() doesn’t handle null in C#.
             */
            string name = null;
            //name.ToString();        // error
            Convert.ToString(name); // no error

            Console.ReadLine();
        }
    }
}
