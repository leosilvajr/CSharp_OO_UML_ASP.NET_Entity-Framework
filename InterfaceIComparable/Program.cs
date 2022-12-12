using InterfaceIComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIComparable
{
  /*Problema motivador:
   * Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por linha), armazenando-os
   * em uma lista. Depois, ordenar os dados dessa lista e mostra-los ordenadamente na tela. Nota: o caminho
   * do arquivo pode ser informado "hardcode".
   */


  internal class Program
  {
    static void Main(string[] args)
    {
      string path = @"C:\C#\CursoUdemy_CSharp_OO_UML_ASP.NET_Entity Framework\InterfaceIComparable\File\in.txt";

      try
      {
        //LE O ARQUIVO
        using (StreamReader sr = File.OpenText(path))
        {
          //ARMAZENA OS DADOS EM UMA LISTA
          List<Employee> list = new List<Employee>();
          while (!sr.EndOfStream) 
          {
            list.Add(new Employee(sr.ReadLine()));
          }

          //ORDENA A LISTA
          list.Sort();
          foreach (Employee emp in list)
          {
            Console.WriteLine(emp);
          }

        }
      }
      catch (IOException e)
      {
        Console.WriteLine("An error ocurred.");
        Console.WriteLine(e.Message);

      }
    }
  }
}
