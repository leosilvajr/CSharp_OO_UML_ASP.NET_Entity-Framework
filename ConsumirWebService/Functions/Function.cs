using ConsumirWebService.Entities;
using ConsumirWebService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsumirWebService.Functions
{
    public class Function
    {
        Connect connect = new Connect();
        Estados estados = new Estados();

        public string ObterResposta(string soapResult, HttpWebRequest webRequest, IAsyncResult asyncResult)
        {
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();                    
                }
            }

            return soapResult;

        }

        public void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {

            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

        private string UTF8_to_ISO(string value)
        {

            Encoding isoEncoding = Encoding.GetEncoding("ISO-8859-1");
            Encoding utfEncoding = Encoding.UTF8;

            // Converte os bytes 
            byte[] bytesIso = utfEncoding.GetBytes(value);

            //  Obtém os bytes da string UTF 
            byte[] bytesUtf = Encoding.Convert(utfEncoding, isoEncoding, bytesIso);

            // Obtém a string ISO a partir do array de bytes convertido
            string textoISO = utfEncoding.GetString(bytesUtf);

            return textoISO;

        }

        public void GravarXml(string s)
        {


            using (StreamWriter sw = new StreamWriter(UTF8_to_ISO(@"C:\C#\XML.xml")))
            {
                
                sw.WriteLine(s);
                sw.Close();
            }
        }

        public  void DesSerializarListaDeObjeto()
        {
            List<Estados> estados = null;
            using (StreamReader stream = new StreamReader(@"C:\C#\XML.xml"))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<Estados>));
                estados = (List<Estados>)serializador.Deserialize(stream);
            }
        }

        public string LerXmlArquivo()
        {
            return File.ReadAllText(@"C:\C#\XML.xml");
        }

    }
}

