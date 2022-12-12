using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProblemaDiamante.Devices
{
  class ComboDevice : Device, IScanner, IPrinter
  {
    public void Print(string document)
    {
      Console.WriteLine("ComoDevice print "+ document);
    }

    public override void ProcessDoc(string document)
    {
      Console.WriteLine("ComoDevice processing " + document);
    }

    public string Scan()
    {
      return "ComoDevice scan result";
    }
  }
}
