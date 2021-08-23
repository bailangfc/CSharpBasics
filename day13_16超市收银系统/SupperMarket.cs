using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_16超市收银系统
{
    class SupperMarket
    {
        //创建仓库对象
        CangKu ck = new CangKu();
        /// <summary>
        /// 创建超市对象的时候，给仓库的货架上导入货物
        /// </summary>
        public SupperMarket()
        {
            ck.JinPros("Acer", 1000);
            ck.JinPros("SamSung", 1000);
            ck.JinPros("JiangYou", 1000);
            ck.JinPros("Banana", 1000);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临，请问需要什么?");
            Console.WriteLine("我们有Acer、SamSung、JiangYou、Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少个?");
            int count = Convert.ToInt32(Console.ReadLine());
            //去仓库取货
            ProductFather[] pros = ck.QuPros(strType, count);
            double realMoney = GetMoney(pros);
            Console.WriteLine("您需要付{0}元", realMoney);
            Console.WriteLine("请选择您的打折方式:1--不打折 2--打九折 3--八五折 4---买300送50 5--买500送100");
            string input = Console.ReadLine();
            //简单工厂：根据用户输入，返回一个装了子类对象的父类
            CalFather cal = GetCAL(input);
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元",totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("名称："+item.Name+"\t"+"货物单价："+item.Price+"\t"+"货物编号:"+item.ID);
            }
        }

        
        /// <summary>
        /// 根据用户的选择打折方式返回一个打折对象
        /// </summary>
        /// <returns></returns>
        public CalFather GetCAL(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;

            }
            return cal;
        }


        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            //realMoney=pros[0].Price*pros.Length;适用于买的东西都是同一样的情况
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }


        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
