using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDiamante.Devices
{
  //Classe abstrata
  //Possui o Serial Number
  // e Possui a declaração do ProcessDoc
  abstract class Device
  {
    public int SerialNumber { get; set; }

    public abstract void ProcessDoc(string document);

  }
}
