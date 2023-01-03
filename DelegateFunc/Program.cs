using DelegateFunc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFunc
            //Representa um metodo que recebe zero ou mais argumentos, e retorna um valor. 
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

            //Recebe um product e retorna uma string
            Func<Product, string> func = p => p.Name.ToUpper();

            //Declaramos que vou pegar a lista original e aplicar a cada elemento da lista a função NameUpper
            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }
    }
}
