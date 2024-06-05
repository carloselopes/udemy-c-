using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class Product
    {
        public string nameProduct { get; set; }
        public double priceProduct { get; set; }

        public Product(string name, double price)
        {
            nameProduct = name;
            priceProduct = price;
        }

    }
}
