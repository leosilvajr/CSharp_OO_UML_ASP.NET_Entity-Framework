using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsumirWebServiceView.Services
{
    public class ConnectView
    {
        public XmlDocument CreateSoapEnvelope(string s)
        {

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s);
            return xml;
        }

        public HttpWebRequest CreateWebRequest(string url)
        {

            HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
            web.Headers.Add("SOAPAction", url);
            web.ContentType = "text/xml;charset=ISO-8859-1";
            web.Accept = "application/xml";
            web.Method = "POST";
            return web;
        }
    }
}
