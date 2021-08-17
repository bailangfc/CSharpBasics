using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_05练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<3)
            {
                Console.WriteLine("请输入一个里程数");
                string input = Console.ReadLine();
                double input1 = double.Parse(input);
                Ticket tk = new Ticket(input1);
                tk.ShowTicket();
                i++;
                if (i == 2)
                {
                    Console.ReadKey();
                }
            }
            
            //Console.ReadKey();

        }
    }
}
