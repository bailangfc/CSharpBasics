using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06_11方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.GetMax(2, 4);
            int result = Program.GetMax(2, 3);
            Console.WriteLine(result);
            Console.ReadKey();
            
        }

        public static int GetMax(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
