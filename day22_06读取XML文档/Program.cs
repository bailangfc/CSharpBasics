using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day22_06读取XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Books.xml");
            //XmlElement books = doc.DocumentElement;
            //XmlNodeList xml = books.ChildNodes;
            //foreach (XmlNode item in xml)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //Console.ReadKey();

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Order/Items/OrderItem");
            //foreach (XmlNode item in xnl)
            //{
            //    Console.WriteLine(item.Attributes["Name"].Value);
            //    Console.WriteLine(item.Attributes["Count"].Value);
            //}
            //Console.ReadKey();

            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            XmlNode xn = doc.SelectSingleNode("/Order/Items");
            xn.RemoveAll();
            doc.Save("Order.xml");
            Console.WriteLine("删除成功");
            Console.ReadKey();



        }
    }
}
