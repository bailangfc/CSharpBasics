using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day15_02Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"H:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"H:\a");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();


            //获得指定目录下所有文件的全路径
            //string[] path = Directory.GetFiles(@"H:\Picture");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //获得指定目录下所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"H:\Picture");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"H:\Picture\a"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"H:\Picture\a" + i);
            //    }
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            //Directory.Delete(@"H:\Picture", true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

        }
    }
}
