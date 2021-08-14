using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day06_03枚举的练习
{
    public enum Sensom
    {
        春,
        夏,
        秋,
        冬
          
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sensom s = Sensom.夏;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
