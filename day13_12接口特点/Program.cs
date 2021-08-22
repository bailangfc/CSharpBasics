using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_12接口特点
{
    class Program
    {
        static void Main(string[] args)
        {

            //抽象类、接口、静态类都不可以被实例化
            IFlyable fly = new Person();
            fly.Fly();
            Console.ReadKey();

        }
    }

    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public interface IFlyable
    {
        //不允许有访问修饰符 默认为public
        //方法、自动属性
        void Fly();
    }


    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }

    public interface superM:M1,M2
    {

    }

    public class Car : superM
    {
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }
    }

}
