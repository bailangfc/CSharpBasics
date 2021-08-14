using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace day11_10键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add('1', false);
            ht.Add(2, "zhangsan");
            ht.Add(3, '女');
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            //Console.WriteLine(ht['1']);
            Console.ReadKey();
        }
    }
}
