using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_10多态练习
{


    class Program
    {
        static void Main(string[] args)
        {
            //范例：鸭子叫
            //RealDuck r1 = new RealDuck("对的");
            //MuDuck m1 = new MuDuck("看看");
            //Duck[] du = { r1, m1 };
            //du[1].Call();
            //du[0].Call();
            //Console.ReadKey();


            //员工打卡
            Employee em = new Employee();
            Manager ma = new Manager();
            Programmer pro = new Programmer();
            Employee[] emp = { em, ma, pro };
            for (int i = 0; i < emp.Length; i++)
            {
                //emp[i].DaKa();
                if (emp[i] is Programmer)
                {
                    ((Programmer)emp[i]).DaKa();
                }
                else if (emp[i] is Manager)
                {
                    ((Manager)emp[i]).DaKa();
                }
                else
                {
                    emp[i].DaKa();
                }
            }
            Console.ReadKey();




        }
    }

    




    public  class Employee
    {
        public  void DaKa()
        {
            Console.WriteLine("员工9点打卡");
        }
    }

    public class Manager:Employee
    {
        public  new  void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }

    public class Programmer : Employee
    {
        public new  void DaKa()
        {
            Console.WriteLine("程序员不打卡");
        }
    }

    public class Duck
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

        public Duck(string name)
        {
            this.Name = name;
        }

        public virtual void Call()
        {
            Console.WriteLine("鸭子叫");
        }
    }

    public class RealDuck : Duck
    {
        public RealDuck(string name) : base(name)
        {

        }

        public override void Call()
        {
            Console.WriteLine("真的鸭子嘎嘎叫 ");
        }
    }

    public class MuDuck:Duck
    {
        public MuDuck(string name):base(name)
        {

        }
        public override void Call()
        {
            Console.WriteLine("木的鸭子吱吱叫");
        }
    }


    
}
