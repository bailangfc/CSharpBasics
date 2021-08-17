using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_01面向对象
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get {
                    if (_age < 0 || _age > 100)
                    {
                        _age = 66;
                    }
                    return _age;
                }
            set {
                    //if (value < 0 || value > 100)
                    //{
                    //value = 0;
                    //}
                    _age = value;
                }
        }

        private char _gender;
        public char Gender
        {
            get {
                    //if (_gender != '男' && _gender != '女')
                    //{
                    //    return _gender = '怪';
                    //}
                    return _gender;
                }
            set {
                    if (value != '男' && value != '女')
                    {
                        value = '怪';
                    }
                     _gender = value;
                }
        }

        public void Life()
        {
            Console.WriteLine("我叫：{0}。年龄：{1}。性别：{2}。",this.Name,this.Age,this.Gender);
        }
    }
}
