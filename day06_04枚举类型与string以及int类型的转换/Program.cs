using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06_04枚举类型与string以及int类型的转换
{
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "QMe";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(typeof(int));
            //Console.WriteLine(state);
            //Console.ReadKey();


            Console.WriteLine("请输入qq当前状态：1——OnLine,2——OffLine,3——Leave,4——Busy,5——QMe");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": QQState s1= (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您的qq当前状态为:{0}",s1);
                    break;
                case "2":QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您的qq当前状态为{0}",s2);
                    break;
                case "3":QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您的qq当前状态为{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您的qq当前状态为{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您的qq当前状态为{0}", s5);
                    break;

            }
            Console.ReadKey();
        }
    }
}
