using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_11ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法来交换两个int类型的变量
            int a = 10;
            int b = 12;
            //Console.WriteLine("a={0}", a);
            //Console.WriteLine("b={0}", b);
            //Console.WriteLine("---------------------");
            Test(ref a, ref b);
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}",b);
            Console.ReadKey();
        }

        public static void Test(ref int n1,ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
        }
    }
}
