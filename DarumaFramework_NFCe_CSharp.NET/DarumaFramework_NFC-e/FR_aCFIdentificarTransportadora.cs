using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFIdentificarTransportadora : Form
    {
        public FR_aCFIdentificarTransportadora()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string strCPF_CNPJ = TB_CPF.Text;
            string strNome = TB_Nome.Text;
            string strIE = TB_IE.Text;
            string strEndereco = TB_Endereco.Text;
            string strMunicipio = TB_Municipio.Text;
            string strUF = TB_UF.Text;
            int iRetorno;

            iRetorno = Declaracoes.aCFIdentificarTransportadora_NFCe_Daruma(strCPF_CNPJ, strNome, strIE, strEndereco, strMunicipio,strUF);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK); 
        }
    }
}
