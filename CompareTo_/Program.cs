using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTo_
{
  internal class Program
  {
    static void Main(string[] args)
    {
                //Maria é maior do que o Alex, entao funçao retorna valor maior do que 0
      Console.WriteLine("maria".CompareTo("alex"));


                //Alex é menor do que o Maria, entao funçao retorna valor menor que 0
      Console.WriteLine("alex".CompareTo("maria"));

              //Comparando dois objetos igual o resultado da 0.
      Console.WriteLine("maria".CompareTo("maria"));
    }
  }
}
