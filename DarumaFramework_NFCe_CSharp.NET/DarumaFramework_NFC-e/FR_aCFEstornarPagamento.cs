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
    public partial class FR_aCFEstornarPagamento : Form
    {
        public FR_aCFEstornarPagamento()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.aCFEstornarPagamento_NFCe_Daruma(EDT_PgtoEstornada.Text, EDT_PgtoEfetivada.Text, EDT_VALOR.Text);

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

        private void FR_aCFEstornarPagamento_Load(object sender, EventArgs e)
        {

        }

        private void EDT_VALOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EDT_PgtoEstornada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
