using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15_09石头剪刀布
{
    class Computer
    {
        public string First
        {
            get;
            set;
        }
        public int  ShowFirst()
        {
            Random r = new Random();
            int number = r.Next(1, 4);
            switch (number)
            {
                case 1:this.First = "石头";
                    break;
                case 2:this.First = "剪刀";
                    break;
                case 3: this.First = "布";
                    break;
            }
            return number;
        }
    }
}
