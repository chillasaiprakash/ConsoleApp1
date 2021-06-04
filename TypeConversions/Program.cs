using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion
            
            //Example 1
            byte b = 1;   // In Memory value 00000001
            int i = b;    // In Memory value 00000000 00000000 00000000 00000001

            int i1 = 1;
            float f = i1;

            //Explicit Type Conversion (Casting)
            //Example 1
            int i2 = 1;
            byte b1 = (byte)i2;  //chances of data loss because of size limit of bytes
            byte b2 = (byte)i2; //telling the compiler to manually convert using data type

            //Example 2
            float f1 = 1.2f;
            int i3 = (int)f1;   
            int i4 = (int)f;


            //Non compatible Types

            string s = "1";
            int i5 = Convert.ToInt32(s);
            int i6 = int.Parse(s);
        }
    }
}
