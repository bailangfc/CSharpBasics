using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_08使用out参数做登陆
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名：");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pwd = Console.ReadLine();
            string msg = "";
            bool loginReslut = IsLogin(userName, pwd, out msg);
            Console.WriteLine(loginReslut);
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static bool IsLogin(string userName,string pwd,out string msg)
        {
            if (userName == "admin" && pwd == "12345")
            {
                msg = "登陆成功";
                return true;
            }else if (userName == "admin")
            {
                msg = "密码错误";
                return false;

            }else if (pwd == "12345")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知的错误";
                return false;
            }
        }
    }
}
