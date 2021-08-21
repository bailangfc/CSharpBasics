using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day09_04面向对象练习;

namespace day10_02命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("张",33,'男',0,0,0);
            p1.Say();
            Console.ReadKey();

        }
    }
}
