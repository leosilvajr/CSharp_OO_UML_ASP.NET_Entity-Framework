using DelegateAction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10%.
 *
 */
namespace DelegateAction
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

            //Criando um Objeto do Tipo Delegate Action
            Action<Product> act = UpdatePrice;

            //Usando Action com expressão lambda
            Action<Product> act1 = p => { p.Price += p.Price * 0.1; };


            //ForEach: ela recebe um Action do tipo Product, ou seja:
            //Tem que ser uma função que receba um produto e que seja void
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            //Função simples para atulizar preço de um produto.
            p.Price += p.Price * 0.1;
        }
    }
}
