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
        public string codigo;
        public string nome;
        public string Cod 
        {
            get { return codigo; }
            set { codigo = value; } 
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public override string ToString()
        {
            return $"[Cod: {Cod} ]   [Nome: {Nome}]"; 
        }
    }
}
