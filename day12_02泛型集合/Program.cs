using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_02泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listint = new List<int>();
            listint.Add(1);
            listint.Add(2);
            listint.Add(3);
            listint.AddRange(new int[] { 4, 5, 6, 7, 8, 9 });
            listint.AddRange(listint);
            for (int i = 0; i < listint.Count; i++)
            {
                Console.WriteLine(listint[i]);
            }
            Console.ReadKey();
        }
    }
}
