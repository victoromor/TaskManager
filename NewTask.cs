using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class NewTask
    {
        public static void StartNewTAsk()
        {
            Process proc = null;

            // Start a Process using Process start info
            try
            {
                int i = 0;
                ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "bezao.genesystechhub.com");

                foreach (var verb in startInfo.Verbs)
                {
                    Console.WriteLine($"{i++}. {verb}");
                }

                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Verb = "Open";
                startInfo.UseShellExecute = true;
                proc = Process.Start(startInfo);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Kill a process
            Console.WriteLine("-->  Hit enter to Kill {0}...", proc.ProcessName);
            Console.ReadLine();

            // kill all of the iexplore.exe processes

            try
            {
                foreach (var p in Process.GetProcessesByName(proc?.ProcessName))
                {
                    p.Kill();
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
