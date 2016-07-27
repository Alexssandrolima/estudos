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
    public partial class FR_aCFVender_NFCe_Daruma : Form
    {
        public FR_aCFVender_NFCe_Daruma()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EDT_ALIQUOTA.Text != "" & EDT_QUANTIDADE.Text != "" & EDT_VALOR.Text != "" & EDT_DESCONTO.Text != "" & EDT_VALORDESCONTO.Text != "" & EDT_CODIGO.Text != "" & EDT_UNIDADEMEDIDA.Text != "" & EDT_DESCRICAO.Text != "")
            {

                try
                {
                    int iRetorno = 0;
                    iRetorno = Declaracoes.aCFVender_NFCe_Daruma(EDT_ALIQUOTA.Text, EDT_QUANTIDADE.Text, EDT_VALOR.Text, EDT_DESCONTO.Text, EDT_VALORDESCONTO.Text, EDT_CODIGO.Text, EDT_UNIDADEMEDIDA.Text, EDT_DESCRICAO.Text);

                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                    MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
                }
            }
            else {
                MessageBox.Show("Informe os campos obrigatórios!", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDT_ALIQUOTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
