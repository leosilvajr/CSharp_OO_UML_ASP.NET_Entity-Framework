using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Programa vai tentar abrir um arquivo que esta no computador.
             * 
             * Se o arquivo nao existir ele vai cair no FileNotFoundException.
             * Só que independente se o arquivo existir ou não, o bloco finally vai fechar o recurso do FileStream
             */
            FileStream fs = null;

            try
            {
                fs = new FileStream(@"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\Finally\data.txt",
                    FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);   
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
