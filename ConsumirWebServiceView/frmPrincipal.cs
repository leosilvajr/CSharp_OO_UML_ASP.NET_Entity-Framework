using ConsumirWebService.Services;
using ConsumirWebServiceView.Functions;
using ConsumirWebServiceView.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using ConsumirWebService.Functions;
using ConsumirWebServiceView.Entities;

namespace ConsumirWebServiceView
{
    public partial class frmPrincipal : Form
    {
        ConnectView connect = new ConnectView();
        FunctionView function = new FunctionView();
        Estados estados = new Estados();
        Municipio municipio = new Municipio();
        string soapResult = null;

        string xmlEstado = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?><praticsistemas><praticServiceValidarEntrada>" +
            "<tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>" +
            "</praticServiceValidarEntrada><selecionar_estados><selecionar>true</selecionar></selecionar_estados></praticsistemas>";

        string xmlMunicipio = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?><praticsistemas><praticServiceValidarEntrada>" +
            "<tokenPraticAppRHAutenticacao>ksklsd9034nmsd4jf9023nmmgf034vxa,mbnvsd73bf9lsgwb0ldhweqktrlhbgmxçshynh06</tokenPraticAppRHAutenticacao>" +
            "</praticServiceValidarEntrada><selecionar_municipios><selecionar>true</selecionar></selecionar_municipios></praticsistemas>";
        public frmPrincipal()
        {
            InitializeComponent();
            txtXml.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
            HttpWebRequest webRequest = connect.CreateWebRequest(txtUrl.Text);
            XmlDocument soapEnvelopeXml = connect.CreateSoapEnvelope(txtXml.Text);
            function.InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // obtém a resposta da solicitação da Web concluída.
            var xmlPronto = function.ObterResposta(soapResult, webRequest, asyncResult);

            // convert string to stream
            byte[] byteArray = Encoding.Default.GetBytes(xmlPronto);

            MemoryStream stream = new MemoryStream(byteArray);

            if (radEstado.Checked == true && radMunicipio.Checked == false)
            {
            estados.MontarEstado(stream, dgv);
            }

            if (radMunicipio.Checked == true && radEstado.Checked == false)
            {
            municipio.MontarMunicipio(stream, dgv);
            }

        }

        private void radEstado_CheckedChanged(object sender, EventArgs e)
        {
            txtXml.Text = xmlEstado.ToString(); 
        }

        private void radMunicipio_CheckedChanged(object sender, EventArgs e)
        {
            txtXml.Text = xmlMunicipio.ToString(); 

        }

        private void btnLimparGrid_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;
        }
    }


}
