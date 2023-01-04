using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsumirWebService.Entities
{
     public class Estados
    {
        public string Cod { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"Cod: {Cod} Nome: {Nome}"; 
        }
    }
}
