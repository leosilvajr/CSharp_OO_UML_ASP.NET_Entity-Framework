using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumirWebService.Services
{
    public class Connect
    {
        String url = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
        String action = "http://www.praticteste.praticsistemas2.com.br/PraticSite/PraticAppRHServlet";
        public  HttpWebRequest CreateWebRequest()
        {

            HttpWebRequest web = (HttpWebRequest)WebRequest.Create(url);
            web.Headers.Add("SOAPAction", action);
            web.ContentType = "text/xml;charset=ISO-8859-1";
            web.Accept = "application/xml";
            web.Method = "POST";
            return web;
        }
    }
}
