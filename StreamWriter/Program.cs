using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ler tudo oque esta no conteudo do arquivo file1.txt e salvar em letra maiuscula o que ta no file2.txt
            string sourcePath = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\StreamWriter\file1.txt";
            string targetPath = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\StreamWriter\file2.txt";
            try
            {
                //Lê todas as linhas do arquivo e guarda no vetor.
                string[] lines = File.ReadAllLines(sourcePath); 

            //Ler tudo oque esta no conteudo do arquivo file1.txt e salvar em letra maiuscula o que ta no file2.txt
                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
