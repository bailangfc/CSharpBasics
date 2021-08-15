using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_07out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double[] results = MaxMinSumAvg(nums);
            //Console.WriteLine("最大值是{0}",results[0]);
            //Console.WriteLine("最小值是{0}", results[1]);
            //Console.WriteLine("总和是{0}", results[2]);
            //Console.WriteLine("平均值是{0}", results[3]);
            //Console.ReadKey();

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max;
            int min;
            int sum;
            int avg;
            bool a;
            string b;
            decimal c;
            Test(nums, out max, out min, out sum, out avg,out a,out b,out c);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();

        }


        //public static double[] MaxMinSumAvg(double[] numbers)
        //{
        //    double[] res = new double[4];
        //    res[0] = numbers[0];
        //    res[1] = numbers[0];
        //    res[2] = 0;
        //    //res[0] 最大值  res[1] 最小值 res[2] 总和 res[3] 平均值
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (res[0] < numbers[i])
        //        {
        //            res[0] = numbers[i];
        //        }
        //        if (res[1] > numbers[i])
        //        {
        //            res[1] = numbers[i];
        //        }

        //        res[2] += numbers[i];
        //    }
        //    res[3] = res[2] / numbers.Length;
        //    return res;
        //}

        /// <summary>
        /// 计算一个整数数组的最大值、最小值、平均值、总和
        /// </summary>
        /// <param name="nums">要求值得数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out bool a, out string b, out decimal c)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];

                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];

            }
            avg = sum / nums.Length;
            a = false;
            b = "ddd";
            c = 4m;
        }

    }
}
