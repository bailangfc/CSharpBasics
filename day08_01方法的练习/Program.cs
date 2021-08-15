using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08_01方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string name = GetLongArray(names);
            //Console.WriteLine(name);
            //Console.ReadKey();
            //GetLongArray()
            while (true)
            {
                Console.WriteLine("请输入一个数");
                string str = Console.ReadLine();
                int a = GetNumber(str);
                bool b = IsPrime(a);
                Console.WriteLine(b);
                Console.ReadKey();
            }
            
        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    //Console.WriteLine("请输入一个质数");
                    int a = Convert.ToInt32(s);
                    return a;
                }
                catch
                {
                    Console.WriteLine("重新输入");
                    s = Console.ReadLine();
                }
            }
            
        }



        /// <summary>
        /// 获取string数组中最长的一个string类型变量
        /// </summary>
        /// <param name="s">数组</param>
        /// <returns>最长的string</returns>
        public static string GetLongArray(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }


            }
            return max;


        }
    }
}
