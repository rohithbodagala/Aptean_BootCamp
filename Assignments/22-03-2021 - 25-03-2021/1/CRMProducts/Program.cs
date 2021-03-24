using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CRMProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            string MicrosoftCRMProducts = @"..\..\..\ProductInfo\MicrosoftCRMProducts.txt";
            string OracleCRMProducts = @"..\..\..\ProductInfo\OracleCRMProducts.txt";
            List<Product> MicrosoftProducts = new List<Product>();
            List<Product> OracleProducts = new List<Product>();
            var lines = File.ReadAllLines(MicrosoftCRMProducts);
            foreach (var line in lines)
            {
                var words = line.Split(',');
                MicrosoftProducts.Add(new Product(words[0], words[1], words[2],double.Parse(words[3])));
                
            }
            lines = File.ReadAllLines(OracleCRMProducts);
            foreach (var line in lines)
            {
                var words = line.Split(',');
                OracleProducts.Add(new Product(words[0], words[1], words[2], double.Parse(words[3])));

            }
            var Query = from mproduct in MicrosoftProducts 
                          from oproduct in OracleProducts
                        where (mproduct.price < oproduct.price)
                        select new Pair(mproduct.name,oproduct.name);
            foreach(var q in Query)
            {
                Console.WriteLine($"Microsoft CRM Product {q.mproduct} is less in price than Oracle CRM Product {q.oproduct}");
            }
        }
    }
}
