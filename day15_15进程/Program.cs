using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15_15进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] pros = Process.GetProcesses();
            //for (int i = 0; i < pros.Length; i++)
            //{
            //    Console.WriteLine(pros[i]);
            //}

            //Process.Start("calc");
            //Process.Start("iexplore","http://www.baidu.com");
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\bailangfc\OneDrive\桌面\1.txt");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();


            Console.ReadKey();
        }
    }
}
