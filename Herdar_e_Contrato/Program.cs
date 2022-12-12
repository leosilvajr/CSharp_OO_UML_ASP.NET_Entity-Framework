using Herdar_e_Contrato.Model.Entities;
using Herdar_e_Contrato.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_e_Contrato
{
  internal class Program
  {
    static void Main(string[] args)
    {

      IShape s1 = new Circle() { Radius = 2.0, Color = Color.White};

      IShape s2 = new Rectangle() { Width = 3.50,Height = 4.2, Color = Color.Black};

      Console.WriteLine(s1);
      Console.WriteLine(s2);
    }
  }
}
