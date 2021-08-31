using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15_09石头剪刀布
{
    class Player
    {
        public int ShowFirst(string str)
        {
            int num = 0;
            switch (str)
            {
                case "石头":num = 1;
                    break;
                case "剪刀":num = 2;
                    break;
                case "不":num = 3;
                    break;
            }
            return num;
        }
    }
}
