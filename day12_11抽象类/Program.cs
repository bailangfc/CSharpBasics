using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_11抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            //Animal a1 = new Cat();
            a.Bark();
            //a1.Bark();
            Console.ReadKey();
        } 
    }

    public abstract class Animal
    {
        public virtual void TestVirtual()
        {
            Console.WriteLine("都有生命");
        }

        private int _age;
        
        public Animal(int age)
        {
            this.Age = age;
        }

        public Animal()
        {

        }

        public abstract string TestString(string name);

        public abstract void Bark();
        public abstract string name
        {
            get;
            set;
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
    }

    public abstract class Test : Animal
    {

    }
    public class Dog : Animal
    {
        public override string name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪的叫");
        }

        public override string TestString(string name)
        {
            throw new NotImplementedException();
        }
    }
    //方法的签名：返回值和参数
    //public class Cat
    //{
    //    public override string name
    //    {
    //        get
    //        {
    //            throw new NotImplementedException();
    //        }

    //        set
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

    //    public override void Bark()
    //    {
    //        Console.WriteLine("猫咪咪咪的叫");
    //    }
    //}
}
