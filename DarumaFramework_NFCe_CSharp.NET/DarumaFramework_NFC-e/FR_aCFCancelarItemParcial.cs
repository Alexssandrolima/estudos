using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarumaFramework_NFC_e;
using DarumaFramework_NFCe;


namespace DarumaFramework_NFCe
{
    public partial class FR_aCFCancelarItemParcial : Form
    {
        public FR_aCFCancelarItemParcial()
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
                iRetorno = Declaracoes.aCFCancelarItemParcial_NFCe_Daruma(EDT_ITEM.Text, EDT_QUANTIDADE.Text);
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EDT_QUANTIDADE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
