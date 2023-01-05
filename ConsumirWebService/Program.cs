
using ConsumirWebService.Entities;
using ConsumirWebService.Functions;
using ConsumirWebService.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsumirWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            string soapResult = null;
            Function function = new Function();
            Connect connect = new Connect();

            XmlDocument soapEnvelopeXml = connect.CreateSoapEnvelope();
            HttpWebRequest webRequest = connect.CreateWebRequest();


            function.InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            //iniciar chamada assíncrona para solicitação da web.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);


            // obtém a resposta da solicitação da Web concluída.
            var xmlPronto = function.ObterResposta(soapResult, webRequest, asyncResult);

            // convert string to stream
            byte[] byteArray = Encoding.Default.GetBytes(xmlPronto);           
            MemoryStream stream = new MemoryStream(byteArray);

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
            foreach (var list in estados)
            {
                Console.WriteLine(list);
            }

            function.GravarXml(xmlPronto);

        }
    }
}
