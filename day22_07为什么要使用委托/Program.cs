using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day22_07为什么要使用委托
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "aBcdEF", "Hijklmn", "opqRst", "uvWXyz" };          
            ToUpper(names);
            ToLower(names);
            SYH(names);
            Console.ReadKey();
        }

        public static void ToUpper(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToUpper();
                Console.WriteLine(names[i]);

            }
           // Console.ReadKey();          
        }

        public static void ToLower(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToLower();
                Console.WriteLine(names[i]);
            }
           // Console.ReadKey();
        }

        public static void SYH(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "\"" + names[i] + "\"";
                Console.WriteLine(names[i]);
            }
           // Console.ReadKey();
        }


    }
}
