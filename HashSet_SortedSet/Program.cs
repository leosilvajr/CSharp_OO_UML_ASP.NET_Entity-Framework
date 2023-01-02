using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SortedSet
{
    internal class Program
    {
        /* HashSet: 
         * Armazenamento em tabela hash
         * Extremamente rápido: inserção, remoção e busca O(1)
         * A ordem dos elementos não é Garantida
         */

        /* SortedSet: 
         * Armazenamento em árvore
         * Rápido: inserção, remoção e busca O(log(n))
         * Os elementos são armazenados ordenamente conforme implementação IComparer<T>
         */
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (var p in set)
            {
                Console.WriteLine(p);
            }


            SortedSet<int> a = new SortedSet<int>() { 0 , 2 , 4 , 5 , 6 , 8 , 10, 89};
            SortedSet<int> b = new SortedSet<int>() { 5 , 6 , 7 , 8 , 9 , 10 , 89};
            PrintCollection(a);
            Console.WriteLine();

            Console.WriteLine("------UNION ENTRE CONJUNTO A E B-----");
            //UNION ENTRE CONJUNTO A E B
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
            Console.WriteLine();

            Console.WriteLine("------INTERSECTON-----");
            //intersection mostra elementos que possuem nos dois conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);
            Console.WriteLine();

            Console.WriteLine("------DIFERENCE-----");
            //diference mostra elementos que não possuem nos dois conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }


        //IEnumerable é uma interface implementada por todas as coleções basicas do pacote System.Collections
        //Função auxiliar para imprimir conjunto do SortedSet
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj  in collection)
            {
                Console.Write($"[{obj}] ");
            }
            Console.WriteLine();
        }
    }
}
