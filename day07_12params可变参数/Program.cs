using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_12params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] nums = { 100, 200, 300 };
            //string studentName = "小王";
            //Test(studentName, 20,20,20);
            //Console.ReadKey();

            //求任意长度数组的最大值 int类型

            int[] nums = { 8,9 };

            int a = GetMax(nums);
            Console.WriteLine(a);
            Console.ReadKey();
        }

        //public static void Test(string name, params int[] scores)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < scores.Length; i++)
        //    {
        //        sum += scores[i];
        //    }
        //    Console.WriteLine("{0}的总成绩是{1}",name,sum);
        //}

        public static int GetMax(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];

            }
            return sum;
        }

    }
}
