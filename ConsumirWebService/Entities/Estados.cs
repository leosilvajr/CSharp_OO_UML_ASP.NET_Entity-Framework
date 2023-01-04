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

        [XmlElement(ElementName = "estcod")]
        public string Cod { get; set; }

        [XmlElement(ElementName = "estnom")]
        public string Nome { get; set; }

        public Estados() { }
        public Estados(string cod, string nome)
        {
            Cod = cod;
            Nome = nome;
        }
       
    }
}
