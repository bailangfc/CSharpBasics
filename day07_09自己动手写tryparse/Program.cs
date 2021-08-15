using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_09自己动手写tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int ress;
            Console.WriteLine("输入一个字符串");
            string input = Console.ReadLine();
            bool a = MyTryParse(input, out ress);
            Console.WriteLine(a);
            Console.WriteLine(ress);
            Console.ReadKey();
        }

        public static bool MyTryParse(string s,out int result)
        {
            
            try
            {
                //int result = 0;
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                result = 0;
                return false;
                
            }
           
        }
    }
}
