using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入电脑品牌：");
            string brand = Console.ReadLine();
            NoteBook nb = GetBrand(brand);
            if (nb != null)
            {
                nb.SayHello();
            }
            else
            {
                return;
            }
         
            
            Console.ReadKey();
        }

        public static  NoteBook GetBrand(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "IBM":nb = new IBM();
                    break;
                case "Acer":nb = new Acer();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }

    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是弘基笔记本");
        }
    }
}
