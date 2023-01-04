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
                Console.WriteLine(soapResult);
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

    }
}

