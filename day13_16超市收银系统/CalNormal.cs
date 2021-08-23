using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_16超市收银系统
{
    class CalNormal : CalFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
