using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfoDirectory
{
    //Caminho 
    //C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\DirectoryInfoDirectory\myfolder

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\DirectoryInfoDirectory\myfolder";

            try
            {

                //Vamos listar as pastas a partir de uma pasta informada.
                IEnumerable<string> folders;
                folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }


                Console.WriteLine();


                //Vamos listar os arquivos a partir de uma pasta informada.
                IEnumerable<string> files;
                files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //VAMOS CRIAR UMA PASTA
                Directory.CreateDirectory(path + "\\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
