﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_02里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "  abc  ";
            ////string str1 = str.TrimEnd();
            //string str1 = str.TrimStart();
            //Console.WriteLine(str1);
            //Console.ReadKey();

            //1.里氏转换
            //2.子类可以赋值给父类:如果有一个地方需要一个父类作为参数，我们可以给一个子类代替
            //Student s = new Student();
            //Person p = s;
            Person p = new Student();

            //string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            //Console.WriteLine(str);
            //Console.ReadKey();
            //3.如果父类中装的是子类对象，那么可以将这个父类强转为子类对象。
            // is的用法
            //if (p is Teacher)
            //{
            //    Teacher s1 = (Teacher)p;
            //    s1.TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            // as的用法
            //Teacher t = p as Teacher;
            Student s = p as Student;
            //Student ss = (Student)p;
            //ss.StudentSayHello();
            Console.ReadKey();

        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }

    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
