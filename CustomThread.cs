using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManager
{
    class CustomThread
    {
        internal static void CreateCustomThread()
        {
            Console.WriteLine("**** The Thread App\n");
            Console.WriteLine("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine();
            Test(threadCount);
        }

        public static void Test(string input)
        {
            if (input == "1")
            {
                PrintNumbers();
            }
            else
            {
                ThreadStart threadStart = new ThreadStart(PrintNumbers);
                Thread backgroundThread = new Thread(threadStart);
                backgroundThread.Name = "secondary";
                backgroundThread.Start();
            }
        }

        private static void PrintNumbers()
        {
            // Display Thread info.
            Console.WriteLine("-> {0} is executing PrintNumbers()",
                Thread.CurrentThread.Name);

            //print out numbers.
            Console.WriteLine("Your numbers: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}, ", i);
                Thread.Sleep(3000);
            }
            Console.WriteLine();
        }
    }
}
