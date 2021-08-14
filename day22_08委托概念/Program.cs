using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day22_08委托概念
{
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //DelSayHi del = new DelSayHi(SayHiCh);
            //del("张三");

            DelSayHi del = SayHiCh;
            del("张三");

            Console.ReadKey();

        }

        public static void Test(string name,DelSayHi del)
        {
           // del(name);
        }

        public static void SayHiCh(string name)
        {
            Console.WriteLine("你好啊"+name);
        }

        public static void SayHiAm(string name)
        {
            Console.WriteLine("Hello"+name);
        }
    }

}
