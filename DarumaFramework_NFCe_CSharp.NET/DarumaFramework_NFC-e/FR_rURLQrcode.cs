using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_rURLQrcode : Form
    {
        public FR_rURLQrcode()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            StringBuilder StrURL = new StringBuilder();
            StrURL.Length = 500;
            int iRetorno;

            iRetorno = Declaracoes.rURLQrcode_NFCe_Daruma(StrURL);
    
            if (iRetorno == 1)
            {
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                TB_Retorno.Text = StrURL.ToString();
            }
            else
            {
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
        }
    }
}
