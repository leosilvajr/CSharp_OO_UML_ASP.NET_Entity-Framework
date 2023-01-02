using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCompareIgualdade.Entities
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

        //Regra: Considerar que para que um produto seja igual ao outro, tem que bater o nome e o preço
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); 
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            //DownCast
            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
