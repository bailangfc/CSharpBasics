using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_06字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "a b _ + =  f ,";
            //char[] chs = { ' ', '_', '+', ',', '=' };
            //string[] str = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            ////Console.WriteLine(str);
            //Console.ReadKey();

            //string s = "2008-09-08";
            //char[] chs = { '-' };
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",str[0],str[1],str[2]);
            //Console.ReadKey();


            //string str = "国家主席小胡";
            //if (str.Contains("国家主席"))
            //{
            //    str = str.Replace("国家主席", "*");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();


            //string str = "今天天气好清凉，处处好风光";
            //str = str.Substring(1,3);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //string str = "今天天气好清凉，处处好风光";
            //if (str.StartsWith("天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}

            //if (str.EndsWith("光"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();

            //string str = "我是搞一个";
            //int index = str.IndexOf("搞", 2);
            //Console.WriteLine(index);
            //Console.ReadKey();


            string path= @"c:\a\b\c苍\d\e苍\f\g\\fd\fd\fdf\d\vfd\苍老师苍.wav";
            int index = path.LastIndexOf('\\');
            string name = path.Substring(index + 1);
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
