using ConsumirWebService.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ConsumirWebService.Services
{
    public class Connect
    {
        string url = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
        string action = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
        //string arquivoXml = @"C:\C#\XML.xml";

        string xmlEstados = @"<?xml version=""1.0"" encoding=""ISO-8859-1"" ?><praticsistemas><praticServiceValidarEntrada>
            <tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>
            </praticServiceValidarEntrada><selecionar_estados><selecionar>true</selecionar></selecionar_estados></praticsistemas>";

        string xmlMunicipios = @"<?xml version=""1.0"" encoding=""ISO-8859-1"" ?><praticsistemas><praticServiceValidarEntrada>
            <tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>
            </praticServiceValidarEntrada><selecionar_municipios><selecionar>true</selecionar></selecionar_municipios></praticsistemas>";

        public  HttpWebRequest CreateWebRequest()
        {

            HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
            web.Headers.Add("SOAPAction", action);
            web.ContentType = "text/xml;charset=ISO-8859-1";
            web.Accept = "application/xml";
            web.Method = "POST";
            return web;
        }

        public XmlDocument CreateSoapEnvelope()
        {

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlEstados);
            return xml;
        }

    }
}
