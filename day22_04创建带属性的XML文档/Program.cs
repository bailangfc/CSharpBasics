using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day22_04创建带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerText = "张三";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "1000002";
            order.AppendChild(customerNumber);

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem = doc.CreateElement("OrderItem");

            orderItem.SetAttribute("Name", "娃娃");
            orderItem.SetAttribute("Count", "11");
            items.AppendChild(orderItem);


            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            orderItem1.SetAttribute("Name", "娃娃");
            orderItem1.SetAttribute("Count", "11");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            orderItem2.SetAttribute("Name", "娃娃");
            orderItem2.SetAttribute("Count", "11");
            items.AppendChild(orderItem2);

            doc.Save("Order.xml");
            Console.WriteLine("创建成功");
            Console.ReadKey();



        }
    }
}
