using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day22_03创建XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            XmlDocument doc = new XmlDocument();
            //创建第一行描述行为，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            XmlElement books = doc.CreateElement("Books");
            doc.AppendChild(books);

            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "西游记";
            book1.AppendChild(name1);
            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "33";
            book1.AppendChild(price1);
            XmlElement dec1 = doc.CreateElement("Des");
            dec1.InnerText = "降妖除魔";
            book1.AppendChild(dec1);


            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);

            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "红楼梦";
            book2.AppendChild(name2);
            XmlElement price2 = doc.CreateElement("Price");
            price2.InnerText = "66";
            book2.AppendChild(price2);
            XmlElement dec2 = doc.CreateElement("Des");
            dec2.InnerText = "大观园的故事";
            book2.AppendChild(dec2);


            doc.Save("Books.xml");
            Console.WriteLine("创建成功" );
            Console.ReadKey();
        }
    }
}
