using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {   
            // try, catch and finally will be used for exception handling
            try
            {
                Console.WriteLine("Enter value for numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter value for denominator");
                int denominator = Convert.ToInt32(Console.ReadLine());
                int c = numerator / denominator;
                Console.WriteLine("Division is {0}", c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Inside DivideByZeroException block");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Don't provide zero value for denominator");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Inside FormatException block");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter only numbers for Division operation");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Got Some exception");
            }
            finally
            {
                Console.WriteLine("Finally will be called no matter what");
            }

            Console.ReadLine();
        }
    }
}
