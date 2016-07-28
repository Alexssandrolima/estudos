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
    public partial class FR_aCFAbrir_NFCe_Daruma : Form
    {
        public FR_aCFAbrir_NFCe_Daruma()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            int iRetorno;

            if (TB_Logradouro.Text != "")
            {
                if (TB_Nome.Text == "" || TB_Bairro.Text == "" || TB_CodMun.Text == "" || TB_Municipio.Text == "" || TB_UF.Text == "" || TB_CEP.Text == "")
                {
                    MessageBox.Show("O logradouro foi informado, preencha todos os campos obrigatório", "DarumaFramework - NFCe", MessageBoxButtons.OK);

                }
                else
                {

                    iRetorno = Declaracoes.aCFAbrir_NFCe_Daruma(TB_CPF.Text, TB_Nome.Text, TB_Logradouro.Text, TB_Numero.Text, TB_Bairro.Text, TB_CodMun.Text, TB_Municipio.Text, TB_UF.Text, TB_CEP.Text);
                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                    MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);

                }


            }

            if (TB_Logradouro.Text == "")
            {
                iRetorno = Declaracoes.aCFAbrir_NFCe_Daruma(TB_CPF.Text, TB_Nome.Text, TB_Logradouro.Text, TB_Numero.Text, TB_Bairro.Text, TB_CodMun.Text, TB_Municipio.Text, TB_UF.Text, TB_CEP.Text);

                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);

                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);


            }
        }

    }
}
