﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstValue
{
  internal class Program
  {
    static void Main(string[] args)
    {
      PrintService<int> printService = new PrintService<int> (); 

      Console.Write("How many values: ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
      {
        Console.Write($"Valor {i}: ");
        int x = int.Parse((Console.ReadLine()));
        printService.AddValue(x);
      }

      printService.Print();
      Console.WriteLine();
      Console.WriteLine("First: "+ printService.First());

    }
  }
}
