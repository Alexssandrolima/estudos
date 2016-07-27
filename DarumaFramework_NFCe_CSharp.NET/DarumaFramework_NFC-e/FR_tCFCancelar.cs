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
    public partial class FR_tCFCancelar : Form
    {
        public FR_tCFCancelar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iRetorno = 0;
                iRetorno = Declaracoes.tCFCancelar_NFCe_Daruma(EDT_Nnota.Text, EDT_Nserie.Text, EDT_Chave.Text, EDT_Protocolo.Text, EDT_Justificativa.Text);

                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar função. Erro= " + ex.Message);
            }
        }
    }
}
