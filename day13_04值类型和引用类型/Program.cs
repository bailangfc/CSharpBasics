using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_04值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型：int,double,char,decimal,bool,enum,struct,存在栈中
            //引用类型：string,数组,自定义类,集合,object,接口，存在堆中

            //Person p1 = new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "李四";
            //p1.Name = "abd";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p2.Name);
            //Console.ReadKey();
            int number = 10;
             TestTwo(ref number);
        
            Console.WriteLine(number);
            Console.ReadKey();
        }

        public static void TestTwo(ref int n)
        {
             n += 10;
        }
    }



    public class Person
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }
        //public string Name1 { get => _name; set => _name = value; }
    }
}
