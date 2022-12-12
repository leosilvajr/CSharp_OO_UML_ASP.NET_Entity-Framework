using Herdar_e_Contrato.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Herdar_e_Contrato.Model.Entities
{
  //Essa Classe AbastractShape vai implementar IShape
   abstract class AbstractShape : IShape
  {
    public Color Color { get; set; }

    public abstract double Area();
  }
}
