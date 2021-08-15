using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_05方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            Console.WriteLine("请输入一个整数");
            string input = Console.ReadLine();
            int a = GetNumber(input);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        //private static void NewMethod()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("请输入一个数字");
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine(number);
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误");
        //        }

        //    }
        //    Console.ReadKey();
        //}

        public static int GetNumber(string input)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(input);
                    return number;
                }
                catch
                {
                    Console.WriteLine("重新输入");
                    input = Console.ReadLine();
                }
            }

        }
    }
}
