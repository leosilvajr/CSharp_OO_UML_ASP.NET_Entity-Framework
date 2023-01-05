using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsumirWebServiceView.Entities
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

        public void MontarEstado(MemoryStream stream, DataGridView dgv)
        {
            List<Estados> estados = new List<Estados>();
            XElement xml = XElement.Load(stream);
            foreach (XElement x in xml.Elements())
            {
                Estados p = new Estados()
                {
                    codigo = x.Element("estcod").Value,
                    nome = x.Element("estnom").Value,
                };
                estados.Add(p);
            }

            dgv.DataSource = estados;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
