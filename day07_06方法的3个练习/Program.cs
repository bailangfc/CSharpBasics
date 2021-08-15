using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_06方法的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个数");
            //string input = Console.ReadLine();
            //string a = YesOrNo(input);
            //Console.WriteLine(a);
            //Console.ReadKey();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int listSum = GetListSum(nums);
            Console.WriteLine(listSum);
            Console.ReadKey();
        }

        public static int GetListSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }



        /// <summary>
        /// 输出Yes或者No
        /// </summary>
        /// <param name="input">输入</param>
        /// <returns>Yes或者No</returns>
        //public static string YesOrNo(string input)
        //{
        //    while (true)
        //    {
        //        if (input == "Yes" || input == "No")
        //        {
        //            //Console.WriteLine(input);
        //            return input;
        //        }
        //        else
        //        {
        //            Console.WriteLine("重新输入");
        //            input = Console.ReadLine();
        //        }
        //    }
        //}
        




    }
}
