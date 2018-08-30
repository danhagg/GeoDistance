using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;


namespace GeoDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        private void button1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = textUri.Text;

            debugOutput("rest Client Created");

            string strResponse = string.Empty;
            
            strResponse = rClient.makeRequest();

            debugOutput(strResponse);

        }


        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                textResponse.Text = textResponse.Text + strDebugText + Environment.NewLine;
                textResponse.SelectionStart = textResponse.TextLength;
                textResponse.ScrollToCaret();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString()+Environment.NewLine);
            }
        }
    }
}
