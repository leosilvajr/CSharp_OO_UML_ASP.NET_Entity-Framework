using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path_
{
    /*CAMINHO
     * C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\Path_\myfolder\file1.txt
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\Path_\myfolder\file1.txt";
            Console.WriteLine("GetDirectoryName: " +Path.GetDirectoryName(path));

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            //Pegar nome do arquivo.
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            //Pegar nome do arquivo sem a extensão.
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            //Pegar extensão do arquivo.
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));

            //Pegar todo o caminho do arquivo.
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            //Pasta temp do sistema.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
