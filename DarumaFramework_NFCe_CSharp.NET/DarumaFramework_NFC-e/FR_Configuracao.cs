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
    public partial class FR_Configuracao : Form
    {
        public FR_Configuracao()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Str_Velocidade = EDT_VELOCIDADE.Text.Trim();
            string Str_PORTAIP = EDT_PORTAIP.Text.Trim();
            int iRetorno;

            iRetorno = Declaracoes.regAlterarValor_Daruma("DUAL\\PortaComunicacao", Str_PORTAIP);
            iRetorno = Declaracoes.regAlterarValor_Daruma("DUAL\\Velocidade", Str_Velocidade);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            
        }
    }
}
