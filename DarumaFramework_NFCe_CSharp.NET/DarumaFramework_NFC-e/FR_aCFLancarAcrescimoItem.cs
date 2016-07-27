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
    public partial class FR_aCFLancarAcrescimoItem : Form
    {
        public FR_aCFLancarAcrescimoItem()
        {
            InitializeComponent();
        }

        private void FR_aCFLancarAcrescimoItem_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.aCFLancarAcrescimoItem_NFCe_Daruma(EDT_ITEM.Text, EDT_TipoAcresc.Text, EDT_VALOR.Text);
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EDT_VALOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CB_TipoAcresc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EDT_ITEM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
