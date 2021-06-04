using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstraction - Abstraction allows us to expose limited data and functionality of objects publicly and hide the actual implementation

            Mobile mobile = new Mobile();
            mobile.dial();      // for consumer of the mobile class, user/developer is not aware of the logic that is written inside dial() method


        }
    }
}
