using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day07_13方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //M(int a, int b, int c);
        }

        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }
        //public static int M(int a1, int a2)
        //{
        //    return a1 + a2;
        //}
        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
