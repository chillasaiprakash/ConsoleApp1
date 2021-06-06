using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p6
{
    // Given a string, compute recursively a new string where identical chars that are
    //adjacent in the original string are separated from each other by a "*
    class Program
    {
           
            public string check(string test)
            {
              string result = "";
            for (int i = 1; i < test.Length-1; i++)
            {
                result = result + test[i];
                if (test[i] == test[i + 1])
                    result = result + '*';
               
            }
            return result;
        }

            
            public static void Main(string[] args)
            {
                string test = "qquuaaddrraanntt";
                Program c = new Program();
                 var  s = c.check(test);
            foreach (var items in s)
            {
                Console.WriteLine(items);
            }
                Console.ReadLine();
            }
        }
    }
