using DelegatePredicate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
        Fazer um programa que, a partir de uma lista de produtos, remova da lista
    somente aqueles cujo preço minimo seja 100.

 */

namespace DelegatePredicate
{
     class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Predicate é uma função que recebe um objeto e devolve um booleano


            //list.RemoveAll(p => p.Price >= 100.0);
            // Remover Produto p, tal que p.Price seja maior ou igual a 100.

            //ou

            list.RemoveAll(ProductTest);

            foreach (Product  p in list)
            {
                Console.WriteLine(p);
            }
        }

        //Criar Função auxiliar que recebe Produto e devolve o booleano.
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }    
    }
}
