using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class CurrentThreads
    {
        // This Lists the current thread and all the running processes
        public static void CurrentProcessAndItsThreads()
        {
            Process theProc = null;

            try
            {
                //theProc = Process.GetProcessById(Process.GetCurrentProcess().Id); // gets the thread if an id is passed to it

                theProc = Process.GetCurrentProcess();
                Console.WriteLine(theProc?.ProcessName);

                Console.WriteLine("Here are the threads used by: {0}", theProc.ProcessName);
                ProcessThreadCollection theThreads = theProc.Threads;

                foreach (ProcessThread pt in theThreads)
                {
                    string info = $"-> Thread ID: {pt.Id}\tStart Time: {pt.StartTime.ToShortTimeString()}\tPriority: {pt.PriorityLevel}";
                    Console.WriteLine(info);
                }

                Console.WriteLine("********************************************\n");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
