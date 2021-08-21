using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_10关键字new
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter re = new Reporter("张三", 33, '男', "游泳");
            re.SayHello();
            re.ReporterSayHello();
            Programmer pro = new Programmer("李四", 32, '女', 09);
            pro.ProgrammerSayHello();
            pro.SayHello();
            Console.ReadKey();

        }
    }


    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("大家好，我是人类");
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string _name;
        private int _age;
        private char _gender;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
    }

    public class Reporter : Person
    {
        public new void SayHello()
        {
            Console.WriteLine("大家好，我是记者");
        }

        public Reporter(string name, int age, char gender, string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        private string _hobby;

        public string Hobby
        {
            get
            {
                return _hobby;
            }

            set
            {
                _hobby = value;
            }
        }

        //public Reporter(string name,int age,char gender,string hobby)
        //{
        //    Console.WriteLine("我是{0}，我是一个狗仔，我今年{1}岁，我是{2}人，我的爱好是{3}", this.Name, this.Age, this.Gender, this.Hobby);
        //}

        public void ReporterSayHello()
        {
            Console.WriteLine("我是{0}，我是一个狗仔，我今年{1}岁，我是{2}人，我的爱好是{3}", this.Name, this.Age, this.Gender, this.Hobby);
        }
    }

    public class Programmer : Person
    {
        public new void SayHello()
        {
            Console.WriteLine("大家好，我是程序员");
        }

        public Programmer(string name, int age, char gender, int worktime) : base(name, age, gender)
        {
            this.WorkTime = worktime;
        }

        private int _workTime;

        public int WorkTime
        {
            get
            {
                return _workTime;
            }

            set
            {
                _workTime = value;
            }
        }

        public void ProgrammerSayHello()
        {
            Console.WriteLine("我叫{0}，我的年龄是{1}，我是{2}生，我的工作年限是{3}年", this.Name, this.Age, this.Gender, this.WorkTime);
        }
    }

}
