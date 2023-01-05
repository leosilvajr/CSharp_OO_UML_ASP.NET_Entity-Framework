using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConsumirWebServiceView.Entities
{
    public class Municipio
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

        public void MontarMunicipio(MemoryStream stream, DataGridView dgv)
        {
            List<Municipio> municipio = new List<Municipio>();
            XElement xml = XElement.Load(stream);
            foreach (XElement x in xml.Elements())
            {
                Municipio p = new Municipio()
                {
                    codigo = x.Element("munest").Value,
                    nome = x.Element("munnom").Value,
                };
                municipio.Add(p);
            }

            dgv.DataSource = municipio;
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
