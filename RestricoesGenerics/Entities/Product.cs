﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenerics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            //Verificando se obj nao é produto
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not Product");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
