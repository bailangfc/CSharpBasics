using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_04面向对象练习
{
    public class Person
    {

        ~Person()
        {
            Console.WriteLine("我是析构函数");
        }


        public Person(string name,int age,char gender,int chinese,int english,int math)
        {
            //name = this.Name;
            //age = this.Age;
            //gender = this.Gender;
            //chinese = this.Chinese;
            //english = this.English;
            //math = this.Math;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }

        public Person(string name,int age,char gender):this("",0,'男',0,0,0)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 100 || value < 0)
                {
                    value = 0;
                }
                _age = value;
            }
        }

        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }

        private int chinese;
        public int Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }

        private int englisn;
        public int English
        {
            get { return englisn; }
            set { englisn = value; }
        }

        private int math;
        public int Math
        {
            get { return math; }
            set { math = value; }
        }

        public void Say()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，我是{2}生",this.Name,this.Age,this.Gender);

        }

        public void Score()
        {
            Console.WriteLine("语文分数{0}，英语分数{1}，数学分数{2}",this.Chinese,this.English,this.Math);
        }
    }
}
