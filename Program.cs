using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace TaskManager
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                //string line = Console.ReadLine();
                ArrayList test = taskmanager();
                for (int i = 0; i < test.Count; i++)
                {
                    Console.WriteLine((i + 1) + "." + test[i]);
                }
                Console.ReadKey();
            }
            
        }
        static ArrayList taskmanager() 
        {
            ArrayList alist = new ArrayList();
            Process[] Name = Process.GetProcesses();
            foreach (Process prc in Name)
            {
                alist.Add(String.Format("App Name : {0}     PID : {1}      Memory(Private) : {2}", prc.ProcessName, prc.Id, Process.GetCurrentProcess().PagedMemorySize));
                
            }
            alist.Sort();
            return alist;
        }
    }
}
