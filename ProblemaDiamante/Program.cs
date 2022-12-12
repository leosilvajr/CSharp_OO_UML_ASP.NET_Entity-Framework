using ProblemaDiamante.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProblemaDiamante
{
  /*HERANÇA: A herança multiplia pode gerar o problema do diamante,
   * uma ambiguidade causada pela existencia do mesmo metodo em mais de uma superclasse.
   */

  /* HERANÇA: Multipla não é permitida na maioria das linguagens.
   */

  internal class Program
  {
    static void Main(string[] args)
    {

      Printer p = new Printer() { SerialNumber = 1080};
      p.ProcessDoc("My Letter");   //Vai executar  o Metodo ProcessDoc do Printer
      p.Print("My Letter");
      Console.WriteLine(  );

      Scanner scanner= new Scanner() { SerialNumber = 2003 };
      scanner.ProcessDoc("My E-Mail");
      Console.WriteLine(scanner.Scan());
      Console.WriteLine();

      ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
      c.ProcessDoc("My dissertation");
      c.Print("My dissertation");
      Console.WriteLine(c.Scan());
    }
  }
}
