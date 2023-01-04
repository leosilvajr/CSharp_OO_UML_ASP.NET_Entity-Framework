
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsumirWebService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var _url = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
            var _action = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            //iniciar chamada assíncrona para solicitação da web.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspende este thread até que a chamada seja concluída. você pode querer
            // faça algo útil aqui, como atualizar sua IU.
            asyncResult.AsyncWaitHandle.WaitOne();

            // obtém a resposta da solicitação da Web concluída.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=ISO-8859-1";
            webRequest.Accept = "application/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument xml = new XmlDocument();
            string xmlEstados = @"<?xml version=""1.0"" encoding=""ISO-8859-1"" ?><praticsistemas><praticServiceValidarEntrada>
            <tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>
            </praticServiceValidarEntrada><selecionar_estados><selecionar>true</selecionar></selecionar_estados></praticsistemas>";

            string xmlMunicipios = @"<?xml version=""1.0"" encoding=""ISO-8859-1"" ?><praticsistemas><praticServiceValidarEntrada>
            <tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>
            </praticServiceValidarEntrada><selecionar_municipios><selecionar>true</selecionar></selecionar_municipios></praticsistemas>";

            xml.LoadXml(xmlEstados);
            return xml;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    
    }
}
