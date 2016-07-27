using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFCancelarItem_NFCe_Daruma : Form
    {
        public FR_aCFCancelarItem_NFCe_Daruma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.aCFCancelarItem_NFCe_Daruma(EDT_ITEM.Text);

                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
            }

        }

        private void EDT_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
