using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace day14_01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadKey();

        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);

            byte[] md5Buffer = md5.ComputeHash(buffer);
            //return Encoding.Default.GetString(md5Buffer);
            string strNew = "";
            for (int i = 0; i < md5Buffer.Length; i++)
            {
                strNew += md5Buffer[i].ToString("x2");
            }
            return strNew;
        }
    }
}
