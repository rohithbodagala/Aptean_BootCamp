using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProducts
{
    class Product
    {
       public string company, category, name;
        public double price;
        public Product(string company,string category,string name,double price)
        {
            this.company = company;
            this.category = category;
            this.name = name;
            this.price = price;

        }
    }
}
