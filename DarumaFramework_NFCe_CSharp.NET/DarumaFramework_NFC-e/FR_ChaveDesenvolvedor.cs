using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_ChaveDesenvolvedor : Form
    {
        public FR_ChaveDesenvolvedor()
        {
            InitializeComponent();
        }

        private void BTN_FECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ENVIAR_Click(object sender, EventArgs e)
        {
            int iRetorno;
            string Str_Chave = EDT_CHAVEDESENVOLVEDOR.Text.Trim();

            //iRetorno = Declaracoes.regAlterarValor_Daruma("FRAMEWORKGNE\\CONFIGURACAO\\EmpPK",Str_Chave);
            iRetorno = Declaracoes.regAlterarValor_NFCe_Daruma("CONFIGURACAO\\EmpPK", Str_Chave);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                System.Diagnostics.Process process = new System.Diagnostics.Process();

                process.StartInfo.FileName = "http://simula.invoicy.com.br/cadastro.aspx";

                process.Start();
            
        }
    }
}
