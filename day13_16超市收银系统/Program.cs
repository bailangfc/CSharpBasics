using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_16超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建超市对象
            SupperMarket sm = new SupperMarket();
            sm.ShowPros();
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
