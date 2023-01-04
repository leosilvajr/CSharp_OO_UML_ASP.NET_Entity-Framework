using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsumirWebService.Functions
{
     public static class Serializa
    {
        public static string SerializaParaString<T>(this T valor)
        {
            XmlSerializer xml = new XmlSerializer(valor.GetType());
            StringWriter retorno = new StringWriter();
            xml.Serialize(retorno, valor);
            return retorno.ToString();
        }

        public static object DeserializaParaObjeto(string valor, Type tipo)
        {
            XmlSerializer xml = new XmlSerializer(tipo);
            var valorSerealizado = new StringReader(valor);
            return xml.Deserialize(valorSerealizado);
        }


    }
}
