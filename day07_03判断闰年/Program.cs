using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_03判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = IsRun(2007);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断一个年份是否是闰年
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns></returns>
        public static bool IsRun(int year)
        {
            bool a = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return a;
        }
    }
}
