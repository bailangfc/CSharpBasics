using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05_11for循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("请输入五个年龄");
            //    int sum = 0;
            //    //int ai = 5;
            //    bool b = true;
            //    for (int i=1;i<6 ; i++)
            //    {
            //        try
            //        {
            //            int a = int.Parse(Console.ReadLine());

            //            if (a > 100 || a < 0)
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                sum += a;
            //            }
            //        }
            //        catch
            //        {

            //            Console.WriteLine("输入年龄的格式不正确，请重新输入");
            //            b = false;
            //            break;
            //        }

            //    }
            //    if (b)
            //    {
            //        double AvgAge = sum / 5;
            //        Console.WriteLine("平均年龄是{0}", AvgAge);
            //    }

            //    Console.ReadKey();

            //第二题
            //string userName = "";
            //string pwd = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名:");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    pwd = Console.ReadLine();

            //    if (userName == "admin" && pwd == "88888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录失败");

            //    }
            //}
            //Console.ReadKey();

            //第三题
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
                if (sum > 20)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();


        }
    }
}
