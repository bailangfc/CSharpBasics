using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day08_02方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("请输入成绩");
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    string stuLevel = GetLevel(score);
            //    Console.WriteLine(stuLevel);
            //    Console.ReadKey();
            //}
            double r = 4;
            double pre;
            double areas;
            GetCricle(r, out pre, out areas);
            Console.WriteLine(pre);
            Console.WriteLine(areas);
            Console.ReadKey();
        }

        public static void GetCricle(double r,out double pre,out double areas)
        {
            pre = 2 * 3.14 * r;
            areas = 3.14 * r * r;
        }





        /// <summary>
        /// 获取成绩等级
        /// </summary>
        /// <param name="score">分数</param>
        /// <returns>等级</returns>
        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9:
                    level = "优";
                    break;
                case 8:
                    level = "良";
                    break;
                default:
                    level = "不好";
                    break;
            }
            return level;
        }
    }
}
