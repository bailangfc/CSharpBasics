using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10_08继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("臧三",33,'男',88);

        }
    }

    public class Person
    {
        private string _name;

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
        private int _age;
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
        private char _gender;
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


        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //public Person()
        //{

        //}
    }

    public class Student : Person
    {

        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.Id = id;
        }
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        private int _id;



        public void Study()
        {
            Console.WriteLine("学生要学习");
        }




    }

    public class Teacher 
    {

        private double _salary;



        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }



        public void Teach()
        {
            Console.WriteLine("老师会讲课");
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

        public void Drive()
        {
            Console.WriteLine("司机会开车");
        }
    }

}
