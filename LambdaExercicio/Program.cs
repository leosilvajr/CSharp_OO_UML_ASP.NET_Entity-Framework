using LambdaExercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExercicio
{
    /*
        Fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato .csv
    (suponha que exista pelo menos um produto). 
        Em seguida mostrar o preço médio dos produtos. Depoi, mostrar os nomes, em ordem decrescente,
    dos produtos que possuem preço inferior ao preço médio.
     */
     class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\C#\\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\\LambdaExercicio\\in.txt";
            Console.WriteLine($"Enter full filepath: {path}");

            List<Product> list = new List<Product>();
            //Ler o arquivo
            using(StreamReader  sr = File.OpenText(path))
            {
                while (!sr.EndOfStream) 
                {   
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1],CultureInfo.InvariantCulture);

                    list.Add(new Product(name, price));
                }
            }

            //Transformar a lista de produto em uma lista de double, apenas os preços
            //Encontrar a Media com average
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Aerage price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //Mostrar os nomes dos produtos cujo preço seja abaixo da media ordenados em decrescente.
            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p=>p.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
