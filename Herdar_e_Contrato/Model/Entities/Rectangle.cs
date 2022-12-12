﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_e_Contrato.Model.Entities
{
   class Rectangle : AbstractShape
  {
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
      return Width* Height; 
    }

    public override string ToString()
    {
      return "Rectangle Color = "
        + Color
        + ", Widht = "
        + Width.ToString("F2", CultureInfo.InvariantCulture)
        + ", Height = "
        + Height.ToString("F2", CultureInfo.InvariantCulture)
        + ", Area= "
        + Area().ToString("F2", CultureInfo.InvariantCulture);

    }
  }
}
