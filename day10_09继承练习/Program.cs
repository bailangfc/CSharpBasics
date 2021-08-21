using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_09继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者  我的爱好是偷拍 我的年龄是34 我是一个男狗仔
            //司机：我叫舒马赫 我的年龄是43 我是男人  我的驾龄是 23年
            //程序员：我叫孙全 我的年龄是23 我是男生 我的工作年限是 3年
            Reporter re = new Reporter("账单",33,'男',"打球");
            re.ReporterSayHello();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public Person(string name,int age,char gender)
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
        public Reporter(string name,int age,char gender,string hobby) : base(name, age, gender)
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
        public Programmer(string name,int age,char gender,int worktime):base(name,age,gender)
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

    public class Driver
    {
        private int _driveTime;

        public int DriveTime
        {
            get
            {
                return _driveTime;
            }

            set
            {
                _driveTime = value;
            }
        }


    }
}
