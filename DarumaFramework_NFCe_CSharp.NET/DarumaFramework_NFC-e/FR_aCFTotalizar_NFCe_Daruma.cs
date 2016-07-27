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
    public partial class FR_aCFTotalizar_NFCe_Daruma : Form
    {
        public FR_aCFTotalizar_NFCe_Daruma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EDT_VALOR.Text != "")
            {
                try
                {
                    int iRetorno = 0;
                    iRetorno = Declaracoes.aCFTotalizar_NFCe_Daruma(CB_TipoDescAcresc.Text, EDT_VALOR.Text);

                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                    MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
                }
            }
            else {

                MessageBox.Show("Informe o valor! ", "DarumaFramework_NFCe_Daruma", MessageBoxButtons.OK);
            }
        }
    }
}
