using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xiaowang = new Person();
            xiaowang.Name = "小王";
            xiaowang.Age = -9;
            xiaowang.Gender = '春';
            xiaowang.Life();
            Console.ReadKey();
            //Person.Name = "仙王";
        }

    }
}
