﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoUsing
{
    /* CAMINHO DO ARQUIVO
    * C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\BlocoUsing\file1.txt
    * */
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\BlocoUsing\file1.txt";

            //Using: Tudo que executar nesse bloco, ao final do bloco será encerrado automaticamente.
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
