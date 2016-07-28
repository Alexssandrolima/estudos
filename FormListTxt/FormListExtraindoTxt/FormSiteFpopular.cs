using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormListExtraindoTxt
{
    public partial class FormSiteFpopular : Form
    {
        private string p1;
        private string p2;

        public FormSiteFpopular()
        {
            InitializeComponent();
        }

        public FormSiteFpopular(string p1, string p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            InitializeComponent();
        }

        string producao = "aplicacao.saude.gov.br/portalfarmacia/login.jsf";

        private void FormSiteFpopular_Load(object sender, EventArgs e)
        {


            MetodoAcessarSiteUriSetNome();
            Iniciancocomzero = 0;

        }

        private void MetodoAcessarSiteUriSetNome()
        {

            webFpopular.Navigating += new WebBrowserNavigatingEventHandler(webFpopular_Navigating);
            webFpopular.Navigate(producao);
        }


        private void webFpopular_DocumentCompleted(object sender,WebBrowserDocumentCompletedEventArgs e)
        {


            this.Text = e.Url.ToString() + @" loaded" + Iniciancocomzero;
            var htmlDocument = ((WebBrowser)sender).Document;
            if (htmlDocument != null)
            {

                //HtmlElementCollection htmlcol22 = GetElementFromPoint()



                //   public HtmlElementCollection GetElementsByTagName("input");

                //for (int i = 1; i <= 5; i++)

                DisplayMetaDescription();


                    //HtmlElementCollection htmlcol = htmlDocument.GetElementsByTagName("input");
                    //if (htmlcol.Count != 0)
                    //{
                    //        htmlcol.GetElementsByName("no_login")[0].SetAttribute("value", p1);
                    //        htmlcol.GetElementsByName("formLogin:senha")[0].SetAttribute("value", p2);
                    //        htmlcol.GetElementsByName("formLogin:j_id35")[0].InvokeMember("click");
                    //}
            }
        }

        private void DisplayMetaDescription()
        {
            if (webFpopular.Document != null)
            {
                HtmlElementCollection elems = webFpopular.Document.GetElementsByTagName("input");
                foreach (HtmlElement elem in elems)
                {
                    String nameStr = elem.GetAttribute("name");
                    if (nameStr != null && nameStr.Length != 0)
                    {
                        Iniciancocomzero++;

                        if (Iniciancocomzero == 2)
                        {
                            if (nameStr == "no_login") elem.SetAttribute("value", p1);
                        }
                        if (Iniciancocomzero == 3)
                        {
                            if (nameStr == "formLogin:senha") elem.SetAttribute("value", p2);
                        }
                        if (Iniciancocomzero == 4)
                        {
                            if (nameStr == "formLogin:j_id35") elem.InvokeMember("click");
                        }                            //if (nameStr != "j_id19");
                            //String contentStr = elem.GetAttribute("content");
                            //MessageBox.Show("Document: " + webFpopular.Url.ToString() + "\n \n Description: " + contentStr
                            //    + "\n \n name str: " + nameStr);
                     }
                }
            }
        }



        private void webFpopular_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = @"Navegando, aguarde um momento." + Iniciancocomzero;

        }




        public int Iniciancocomzero { get; set; }
    }
}
