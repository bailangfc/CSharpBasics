using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_05泛型练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边 偶数显示在右边
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> js = new List<int>();
            //List<int> os = new List<int>();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        os.Add(num[i]);
            //    }
            //    else
            //    {
            //        js.Add(num[i]);
            //    }
            //}
            //for (int j = 0; j < js.Count; j++)
            //{
            //    Console.WriteLine(js[j]);
            //}
            //Console.WriteLine("--------------------");
            //for (int s = 0; s < os.Count; s++)
            //{
            //    Console.WriteLine(os[s]);
            //}
            //Console.WriteLine("--------------------");
            //js.AddRange(os);
            //for(int k = 0; k < js.Count; k++)
            //{
            //    Console.WriteLine(js[k]);
            //}
            //Console.ReadKey();

            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i]= item;
            //    i++;
            //}

            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //统计 Welcome to china中每个字符出现的次数 不考虑大小写
        }
    }
}
