using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FileFileInfo
{
    /*CAMINHO DO ARQUIVO
     * C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\FileFileInfo\file1.txt
     * */
    public class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\FileFileInfo\file1.txt";
            string targetPath = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\FileFileInfo\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                //Ler todas as linhas do meu arquivo e guardar cada linha no elemento do vetor;
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string item in lines)
                {
                    Console.WriteLine(item);
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
