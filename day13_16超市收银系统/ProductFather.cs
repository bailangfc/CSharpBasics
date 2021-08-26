using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day13_16超市收银系统
{
    class ProductFather
    {

        public string ID
        {
            get;
            set;
        }

        public  double Price
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        

        public ProductFather(string id,double price,string Name)
        {
            this.Price = price;
            this.Name = Name;
            this.ID = id;

        }
       
    }
}
