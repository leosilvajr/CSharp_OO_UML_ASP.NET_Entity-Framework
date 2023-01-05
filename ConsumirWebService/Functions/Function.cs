using ConsumirWebService.Entities;
using ConsumirWebService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsumirWebService.Functions
{
    public class Function
    {
        Connect connect = new Connect();
        Estados estados = new Estados();
        string arquivoXml = @"C:\C#\XML.xml";
        public string ObterResposta(string soapResult, HttpWebRequest webRequest, IAsyncResult asyncResult)
        {
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream(), Encoding.GetEncoding("ISO-8859-1")))
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

        public void GravarXml(string s)
        {
            String charset = null;
            GravarXml(s, charset);
        }

            public void GravarXml(string s, String charset)
        {
            var encoding = Encoding.GetEncoding("ISO-8859-1");
            using (StreamWriter sw = new StreamWriter(arquivoXml, false, encoding))
            {
                sw.WriteLine(s);
                sw.Close();
            }
        }
    }

}

//public  void DesSerializarListaDeObjeto()
//{
//    List<Estados> estados = null;
//    using (StreamReader stream = new StreamReader(arquivoXml))
//    {
//        XmlSerializer serializador = new XmlSerializer(typeof(List<Estados>));
//        estados = (List<Estados>)serializador.Deserialize(stream);
//    }
//}

//public string LerXmlArquivo()
//{
//    return File.ReadAllText(arquivoXml);
//}



