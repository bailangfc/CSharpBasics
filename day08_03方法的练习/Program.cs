using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08_03方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //100、计算任意多个数间的最大值(提示：params)
            int[] nums = { 1, 2, 3, 6, 65, 4353, 34564 };
            //int maxValue = GetMax(nums);
            //Console.WriteLine(maxValue);
            //Console.ReadKey();


            //101、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序

            //Change(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);

            //}
            //Console.ReadKey();
            //102将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] names = { "梅西", "卡卡", "郑大世" };
            string nameStr = OperateStr(names);
            Console.WriteLine(nameStr);
            Console.ReadKey();
        }

        public static string OperateStr(string[] strs)
        {
            string str = "";
            for (int i = 0; i < strs.Length - 1; i++)
            {
                str += strs[i] + "|";
            }
            return str + strs[strs.Length - 1];
        }


        public static void Change(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }


        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }
}
