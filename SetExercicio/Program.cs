using SetExercicio.Entities;
using System;
using System.Collections.Generic;
using System.IO;


namespace SetExercicio
{
    /*
     Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome
    de usuário e o instante em que o usuário acessou osite no padrão ISO 8601, separados por espaço,
    conforme exemplo. Fazer um programa que leia o log de acessos a partir de  um arquivo, e daí informa quantos
    usuários distintos acessaram o site.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string raiz = "C:\\C#\\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\\SetExercicio\\";

            HashSet<LogRecord> set = new HashSet<LogRecord>();  

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(raiz + path + ".txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);

                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }

                    Console.WriteLine("TOTAL USERS: " + set.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
