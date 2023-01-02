using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExercicio
{
    /*
     *      Na contagem de votos de uma eleição, são gerados vários registros
        de votação contendo o nome do candidato e a quantidade de votos
        (formato .csv) que ele obteve em uma urna de votação. Você deve
        fazer um programa para ler os registros de votação a partir de um
        arquivo, e daí gerar um relatório consolidado com os totais de cada
        candidato.

        Exec: 
            Enter file full path: c:\temp\in.txt
            Alex Blue: 76
            Maria Green: 71
            Bob Brown: 61
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string raiz = "C:\\C#\\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\\DictionaryExercicio\\";
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(raiz+path))
                {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
