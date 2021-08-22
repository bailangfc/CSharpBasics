using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_14显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Bird b = new Bird();
            b.Fly();
            Console.ReadKey();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }

         void IFlyable.Fly()
        {
            Console.WriteLine("接口中的飞");
        }
    }
}
