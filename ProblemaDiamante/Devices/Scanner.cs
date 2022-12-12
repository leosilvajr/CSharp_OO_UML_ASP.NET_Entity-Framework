using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiamante.Devices
{
  class Scanner : Device , IScanner //Herda de Device
  {
    public override void ProcessDoc(string document) //Subscreve o ProcessDoc
    {
      Console.WriteLine("Scanner processing: " + document);
    }

    public string Scan()  //Metodo que vai retornar a string Scanner scan result
    {
      return "Scanner scan result";
    }
      

  }
}
