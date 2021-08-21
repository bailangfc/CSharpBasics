using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_09多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态的3种方法：1、虚方法；2、抽象类；3、接口
            Chinese cn1 = new Chinese("李梅");
            Chinese cn2 = new Chinese("韩磊");
            Janpanese j1 = new Janpanese("小导字");
            Janpanese j2 = new Janpanese("进饼子");
            Korea k1 = new Korea("金妍儿");
            Korea k2 = new Korea("金秀儿");
            American a1 = new American("汤姆");
            American a2 = new American("吉姆");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2,new English("") ,new English("") };
            for (int i = 0; i < pers.Length; i++)
            {
                //if (pers[i] is Chinese)
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Janpanese)
                //{
                //    ((Janpanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else
                //{
                //    ((American)pers[i]).SayHello();
                //}

                pers[i].SayHello();
            }

            Console.ReadKey();



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

        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {

        }

        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }

    public class Janpanese : Person
    {
        public Janpanese(string name) : base(name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("我是日本人，我叫{0}", this.Name);
        }
    }

    public class Korea : Person
    {
        public Korea(string name) : base(name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("我是韩国人，我叫{0}", this.Name);
        }
    }

    public class American : Person
    {
        public American(string name) : base(name)
        {
        }
        public override void SayHello()
        {
            Console.WriteLine("我是美国人，我叫{0}", this.Name);
        }
    }

    public class English : Person
    {
        public English(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是英国人");
        }
    }
}
