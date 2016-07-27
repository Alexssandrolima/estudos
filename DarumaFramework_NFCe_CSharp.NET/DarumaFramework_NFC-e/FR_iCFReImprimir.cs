using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_iCFReImprimir : Form
    {
        public FR_iCFReImprimir()
        {
            InitializeComponent();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            int iRetorno;
            iRetorno = Declaracoes.iCFReImprimir_NFCe_Daruma("", "", "");
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
