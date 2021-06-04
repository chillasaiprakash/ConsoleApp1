using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfAndSwitch
{
    class Program
    {
        public enum Season
        {
            Rainy,
            Winter,
            Summer
        }
        static void Main(string[] args)
        {
            var season = Season.Rainy;


            Console.WriteLine("----------Below is the output of using nested if-------------");

            if (season == Season.Rainy)
            {
                Console.WriteLine("Rainy season");
            }
            else if (season == Season.Winter)
            {
                Console.WriteLine("Winter season");
            }
            else if (season == Season.Summer)
            {
                Console.WriteLine("Summer season");
            }
            else
            {
                Console.WriteLine("No season");
            }


            Console.WriteLine("----------Below is the output of using switch -------------");
            season = Season.Summer;

            switch (season)
            {
                case Season.Rainy:
                    Console.WriteLine("Rainy season");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter season");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer season");
                    break;
                default:
                    break;
            }


            switch (season)
            {
                case Season.Rainy:
                case Season.Winter:
                case Season.Summer:
                    Console.WriteLine("It's a season");
                    break;
                default:
                    Console.WriteLine("Not a season");
                    break;
            }
        }
    }
}
