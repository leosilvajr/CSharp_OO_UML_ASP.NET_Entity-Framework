using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_e_Contrato.Model.Entities
{
  class Circle : AbstractShape //Herda da Classe Shape
  {
    public double Radius { get; set; }


    //IMPLEMENTANDO A OPERACAO DE AREA DO CIRCULO
    public override double Area()
    {
      return Math.PI * Radius * Radius;  
    }

    public override string ToString()
    {
      return "Circle color = "
        + Color
        + ", RADIUS = "
        + Radius.ToString("F2", CultureInfo.InvariantCulture)
        + ", AREA = "
        + Area().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
