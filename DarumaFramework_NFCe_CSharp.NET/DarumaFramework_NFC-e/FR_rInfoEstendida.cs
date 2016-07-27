using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_rInfoEstendida : Form
    {
        public FR_rInfoEstendida()
        {
            InitializeComponent();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrIndice;
            StrIndice = TB_indice.Text;
            StringBuilder StrRetorno = new StringBuilder(); 
            StrRetorno.Length = 20;
            int iRetorno;

            
            iRetorno = Declaracoes.rInfoEstendida_NFCe_Daruma(StrIndice, StrRetorno);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            TB_informacao.Text = StrRetorno.ToString();

        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
