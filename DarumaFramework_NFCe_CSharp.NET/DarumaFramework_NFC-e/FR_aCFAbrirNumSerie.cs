using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFAbrirNumSerie : Form
    {
        public FR_aCFAbrirNumSerie()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrNNF = TB_NumNota.Text;
            string StrNSerie = TB_NumSerie.Text;
            string StrCPF = TB_CPF.Text;
            string StrNome = TB_Nome.Text;
            string StrLgr = TB_Logradouro.Text;
            string StrNro = TB_Numero.Text;
            string StrBairro = TB_Bairro.Text;
            string StrMun = TB_CodMun.Text;
            string StrMunicipio = TB_Municipio.Text;
            string StrUF = TB_UF.Text;
            string StrCEP = TB_CEP.Text;
            int iRetorno;

            iRetorno = Declaracoes.aCFAbrirNumSerie_NFCe_Daruma(StrNNF, StrNSerie, StrCPF, StrNome, StrLgr, StrNro, StrBairro, StrMun, StrMunicipio, StrUF, StrCEP);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);     

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FR_aCFAbrirNumSerie_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



 

    }
}
