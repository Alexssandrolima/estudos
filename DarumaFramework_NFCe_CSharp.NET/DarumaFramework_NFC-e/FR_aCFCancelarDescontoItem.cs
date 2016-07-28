using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarumaFramework_NFC_e;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFCancelarDescontoItem : Form
    {
        public FR_aCFCancelarDescontoItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.aCFCancelarDescontoItem_NFCe_Daruma(EDT_ITEM.Text);
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
