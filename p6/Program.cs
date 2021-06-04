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
           static string result = "";
            static void pairStar(string test,int i)
            {
                result = result + test[i];
                if (i == test.Length - 1)
                    return;
                if (test[i] == test[i + 1])
                    result = result + '*';

                pairStar(test, i + 1);
            }

            
            public static void Main(string[] args)
            {
                string test = "qquuaaddrraanntt";
                pairStar(test, 0);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
