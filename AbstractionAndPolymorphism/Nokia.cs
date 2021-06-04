using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndPolymorphism
{
    public class Nokia : Mobile
    {
        public void getBlueToothConnection()
        {
            Console.WriteLine("Bluetooth connected");
        }

        //New implementation for this method which was available in Mobile Class  
        //This is runtime polymorphism  
        //Override the code of an existing method is called as method overriding
        public override void sendMessage()
        {
            Console.WriteLine("Message Sent to a group");
        }

    }
}
