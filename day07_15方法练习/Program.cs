using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_15方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字：");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字：");
            string strNumberTwo = Console.ReadLine();
            
            int numberTwo = GetNumber(strNumberTwo);
            JudgeNumber(ref numberOne,ref numberTwo);

            int sum = GetSum(numberOne, numberTwo);
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        public static int GetSum(int n1,int n2)
        {
            int sum = 0;
            for (int i = n1; i <=n2; i++)
            {
                sum += i;
            }
            return sum;
        }


        public static void JudgeNumber(ref int n1,ref int n2)
        {
            while (true)
            {
                if (n1<n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数不能大于等于第二个数，请重新输入第一个数");
                    string s1 = Console.ReadLine();
                    n1 = GetNumber(s1);
                    Console.WriteLine("请输入第二个数");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);
                }



            }
        }

        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入！");
                    s = Console.ReadLine();
                }
            }
            
        }
    }
}
