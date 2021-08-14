using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day22_12lamda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.RemoveAll(x => x > 4);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
