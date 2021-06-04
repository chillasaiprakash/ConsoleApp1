using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DeliveryType
        {
            cashOnDelivery = 1,
            debitCard = 2,
            creditCard = 3
        }

        static void Main(string[] args)
        {
            // An Enum is used to create a group of constants
            // const int cashOnDelivery = 1;
            // const int debitCard = 2;
            // const int creditCard = 3;

            var deliveryMethodTypeForUser2 = DeliveryType.creditCard;

            Console.WriteLine("Delivery Type is {0}", deliveryMethodTypeForUser2);
            Console.ReadLine();
        }
    }

}