using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DarumaFramework_NFC_e;
using DarumaFramework_NFCe;


namespace DarumaFramework_NFCe
{
    public partial class FR_aCFEfetuarPagamento : Form
    {
        public FR_aCFEfetuarPagamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.aCFEfetuarPagamento_NFCe_Daruma(EDT_Pgto.Text, EDT_VALOR.Text);

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
