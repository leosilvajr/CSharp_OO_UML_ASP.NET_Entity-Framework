using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsumirWebServiceView.Functions
{
    public class FunctionView
    {
        public void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {

            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }

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

        public void ConvertStringToStream(string xmlPronto)
        {
            byte[] byteArray = Encoding.Default.GetBytes(xmlPronto);
            MemoryStream stream = new MemoryStream(byteArray);
        }

        public void GravarXml(string s)
        {
            var encoding = Encoding.GetEncoding("ISO-8859-1");
            using (StreamWriter sw = new StreamWriter(@"C:\C#\XML.xml", false, encoding))
            {
                sw.WriteLine(s);
                sw.Close();
            }
        }

        public T ObterObjetoXml<T>(string arquivo) where T : class
        {            //processo de converter as propriedades e campos públicos de um objeto em um formato serial
            var serialize = new XmlSerializer(typeof(T));

            try
            {
                //Le o arquivo XML carregado atravez de um arquivo.
                var xmlArquivo = XmlReader.Create(arquivo);
                return (T)serialize.Deserialize(xmlArquivo);
            }

            catch (Exception)
            {
                return null;
            }
        }
    }
}
