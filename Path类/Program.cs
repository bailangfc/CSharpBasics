using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"H:\百度\huyong.txt";
            //int index = str.LastIndexOf("\\");
            //int index1 = str.IndexOf("\\");
            //获得文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得文件名但是不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件所在的文件夹的名称
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //拼接文件路径
            Console.WriteLine(Path.Combine(@"C:\huyong1", "a.txt"));
            //Console.WriteLine(index);
            //Console.WriteLine(index1);
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
