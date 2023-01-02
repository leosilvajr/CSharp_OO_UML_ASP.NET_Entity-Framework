using Microsoft.Win32;
using RestricoesGenerics.Entities;
using RestricoesGenerics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestricoesGenerics
{
    /* PROBLEMA: 
     * Uma empresa de consultoria deseja avaliar a performance de produtos,
     * funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
     * o maior dentre um conjunto de elementos. Fazer um programa que leia um conjunto de 
     * N produtos, conforme exemplo, e depois mostre o mais caro deles.
     * */

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("--------------------------");
            Console.Write("Enter Numbers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");

            //Ler nome  e preço separados por virgula.
            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];

                double price = double.Parse(vect[1],CultureInfo.InstalledUICulture);

                list.Add(new Product(name, price));
            }

            CalculationService calc = new CalculationService();

            Product max = calc.Max(list);

            
            Console.WriteLine("--------------------------");
            Console.Write("VALOR MAIOR: ");
            Console.WriteLine(max);
        }
    }
}
