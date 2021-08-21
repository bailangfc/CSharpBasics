using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_04面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person("小明",33,'男',45,55,43);
            Person p2 = new Person("小王", 44, '女');
            p2.Say();
            //p1.Name = "小明";
            //p1.Age = 22;
            //p1.Gender = '男';
            //p1.English = 90;
            //p1.Chinese = 99;
            //p1.Math = 98;
            //p1.Say();
            //p1.Score();
            //Console.WriteLine("=========");
            //p2.Say();
            //p2.Score();
            Console.ReadKey();
        }
    }
}
