using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace day10_07字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //string str = "abcdefg";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);

            //}
            //Console.ReadKey();

            //string str = "abdfads";
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - i - 1];
            //    chs[chs.Length - i - 1] = temp;
            //}
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();





            //string str = "hello c sharp";
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length/2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - i - 1];
            //    strNew[strNew.Length - i - 1] = temp;
            //}

            //string str1 = string.Join(" ", strNew);
            //Console.WriteLine(str1);
            ////for (int i = 0; i < strNew.Length; i++)
            ////{
            ////    Console.Write(strNew[i]+"  ");
            ////}
            //Console.ReadKey();


            //string email = "absdfadsfc@outlook.com";
            //int index = email.IndexOf("@");
            //string name = email.Substring(0, index);
            //string com = email.Substring(index + 1);
            //Console.WriteLine(name);
            //Console.WriteLine(com);
            //Console.ReadKey();


            //string path = @"H:\CSharpBasicsBook\1111.txt";
            //string[] content = File.ReadAllLines(path, Encoding.UTF8);
            //for (int i = 0; i < content.Length; i++)
            //{
            //    string[] strNew = content[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine((strNew[0].Length>10?strNew[0].Substring(0,8)+".......":strNew[0])+"|"+strNew[1]);
            //}
            //Console.ReadKey();

            //string str = "dadjejlaejlfjejaioejleljleljielae";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            //string str = "我是北京我是上海我是重庆我是天津，我是安徽，我是六安";
            //int index = str.IndexOf("我是");
            //Console.WriteLine("第1次出现 我是 的位置是{0}", index);
            //int count = 1;
            //while (index != -1)
            //{
            //    count++;
            //    index = str.IndexOf("我是", index + 1);
            //    if (index != -1)
            //    {
            //        Console.WriteLine("第{0}次出现 我是 的位置是{1}", count, index);
            //    }
            //}
            //Console.ReadKey();












            //string path = @"H:\CSharpBasicsBook\1111.txt";
            //string[] content = File.ReadAllLines(path, Encoding.UTF8);
            //char[] chs = { ' ' };
            //string[] content1 = null;
            //List<string> list = new List<string>();
            //for (int i = 0; i < content.Length; i++)
            //{
            //    content1 = content[i].Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //    //list.AddRange(content1);

            //}

            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////for (int i = 0; i < content.Length; i++)
            ////{
            ////    Console.WriteLine(content[i]);
            ////}
            //Console.ReadKey();
        }
    }
}
