using GetHashCode_Equals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode_Equals
{
    //Equals: Metodo que compara se o objeto é igual a outro, retornando true ou false.

    //GetHashCode: retorna um numero inteiro representando um codigo gerado a partir das intormações do objeto.

    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b)); //Comparando ponto de vista do conteudo da String.
            Console.WriteLine(a == b);      // Comparando ponto de vista da referencia.


            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
