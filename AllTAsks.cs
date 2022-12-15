using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskManager
{
    class AllTAsks
    {
        // This Lists all the running processes
        public static void PrintingAllProcesses()
        {
            Console.WriteLine("Currently Runing Processes **********" +
                "**********************************\n");
            var runningProcesses = from proc in Process.GetProcesses()
                                   orderby proc.Id
                                   select proc;

            foreach (var p in runningProcesses)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }

            Console.WriteLine("********************************************\n");
        }


        


        



       

    }


}
