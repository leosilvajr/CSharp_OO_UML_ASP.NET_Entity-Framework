using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison.Entities
{
    class Product 
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
            return Name +
                ", " +
                Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //public int CompareTo(Product other)
        //{
        //    //Ordenando por Preço
        //    return Price.CompareTo(other.Price);

        //    //Ordenando por Nome
        //    //return Name.ToUpper().CompareTo(other.Name.ToUpper());  
        //}
    }
}
