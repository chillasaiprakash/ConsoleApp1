using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndPolymorphism
{
    public class Mobile
    {
        private string imeiCode { get; set; }
        public string simCard { get; set; }
        public string processor { get; }
        public int internalMemory { get; }
        public bool isSingleSIM { get; set; }

        public void getIEMICode()
        {
            Console.WriteLine("IEMI Code - IEDF34343435235");
        }

        public void dial()
        {
            Console.WriteLine("Dial a number");
        }

        public void receive()
        {
            Console.WriteLine("Receive a call");
        }

        public void sendMessage()
        {
            Console.WriteLine("Message Sent");
        }

    }
}
