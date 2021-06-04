using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    public class ExThread
    {

        // Static method for thread a
        public static void method1()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Task.Delay(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
                Console.WriteLine(i);
            }
        }

        // static method for thread b
        public static void method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //MultiTasking :
            /*
             * Windows operating system is a multitasking operating system.
             * It means it has the ability to run multiple applications at the same time
             */

            //Process :
            /*
             * A process is a part of the operating system (or a component under the operating system) 
             * which is responsible for executing the program or application
             */

            /*Thread : 
             * Thread is a unit of a process that is responsible for executing some application code
             */

            /*
             * By default, every process has at least one thread which is responsible for executing the application code and that thread is called as Main Thread. 
             * So, every application by default is a single-threaded application.
             */

            /* All the threading related classes in C# belong to the System.Threading namespace
             */

            ExThread.method1();
            ExThread.method2();

            // Creating and initialiiing threads
            // Thread a = new Thread(ExThread.thread1);
            // Thread b = new Thread(ExThread.thread2);
            // a.Start();
            // b.Start();

            Console.ReadLine();
        }

    }
}
