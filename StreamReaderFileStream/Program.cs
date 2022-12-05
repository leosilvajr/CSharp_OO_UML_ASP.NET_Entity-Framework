using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderFileStream
{
    /* CAMINHO DO ARQUIVO
     * C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\StreamReaderFileStream\file1.txt
     * */

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\StreamReaderFileStream\file1.txt";
            StreamReader sr = null;


            try
            {
                //o File instancia implicitamente o FileStream e o StreamReader
                sr = File.OpenText(path);


                //Ler todas as linhas do arquivo até chegar no fim
                while(!sr.EndOfStream) 
                {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                }
            }
            catch (IOException e )
            {
                Console.WriteLine("An error accurred.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)       
                    sr.Close();

            }
        }
    }
}
