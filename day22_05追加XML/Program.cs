using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace day22_05追加XML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            //如果文件存在,先加载出来，拿到这个文件的根节点
            if (File.Exists("Books.xml"))
            {
                doc.Load("Books.xml");
                books = doc.DocumentElement;
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                books = doc.CreateElement("Books");
                doc.AppendChild(books);

            }
            //如果文件不存在，创建这个文档


            XmlElement book1 = doc.CreateElement("Book");
            books.AppendChild(book1);

            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "C++编程指南";
            book1.AppendChild(name);

            XmlElement price = doc.CreateElement("Price");
            price.InnerText = "33";
            book1.AppendChild(price);

            XmlElement des = doc.CreateElement("Des");
            des.InnerText = "经典著作";
            book1.AppendChild(des);

            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
