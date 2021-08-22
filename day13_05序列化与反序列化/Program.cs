using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace day13_05序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 12;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\bailangfc\OneDrive\桌面\2222.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{

            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\bailangfc\OneDrive\桌面\2222.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);

            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();
        }
    }

    [Serializable]
    public class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }
    }
}
