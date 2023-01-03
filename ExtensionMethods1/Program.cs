using ExtensionMethods1.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Informe Mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Informe Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Informe Hora: ");
            int hora = int.Parse(Console.ReadLine());

            Console.Write("Informe Minuto: ");
            int minuto = int.Parse(Console.ReadLine());

            Console.Write("Informe Segundo: ");
            int segundo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Voce Informou Data: {dia}/{mes}/{ano} Horário: {hora}:{minuto}:{segundo}");

            DateTime dt = new DateTime(ano, mes, dia, hora, minuto, segundo);

            Console.WriteLine("Tempo que passou até agora:");
            Console.WriteLine(dt.ElapsedTime());


            Console.WriteLine();


            string s1 = "Good Morning dear sttudents !";
            Console.WriteLine(s1.Cut(10));

            


        }
    }
}
