﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1().GetAwaiter();
            Method2();
            Console.ReadLine();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Method 1 i value is {0}", i);
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2 i value is {0}", i);
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
