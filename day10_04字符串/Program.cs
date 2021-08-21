using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_04字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "张三";
            //name = "李四";
            //Console.WriteLine(name);
            //Console.ReadKey();


            //string s1 = "张三";
            //string s2 = "张三";
            //Console.ReadKey();

            string s = "abcdef";
            //s[0] = "b";
            char[] c = s.ToCharArray();
            c[0] = 'b';
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            //Console.WriteLine(s[0]);
            Console.ReadKey();
        }
    }
}
