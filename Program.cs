using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllTAsks.PrintingAllProcesses();

            

            Console.WriteLine("WHAT WOULD YOU YOU LIKE TO DO? \n\n " +
                "1:[NEW TASK]\t 2: [CUSTOM THREAD] \t ");
            var enter_task = Console.ReadLine();
            while (true)
            {
                if (enter_task != null)
                {

                    switch (enter_task)
                    {
                        case "1":
                            NewTask.StartNewTAsk();
                            break;
                        case "2":
                            CustomThread.CreateCustomThread();
                            break;
                        default:
                            Console.WriteLine("Invalid selection");
                            continue;
                    }

                }
                break;
            }

        }
    }
}
