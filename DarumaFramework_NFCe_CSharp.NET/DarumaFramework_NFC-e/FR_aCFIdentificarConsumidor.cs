using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFIdentificarConsumidor : Form
    {
        public FR_aCFIdentificarConsumidor()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrCPF = TB_CPF.Text;
            string StrNome = TB_Nome.Text;
            string StrLgr = TB_Logradouro.Text;
            string StrNro = TB_Numero.Text;
            string StrBairro = TB_Bairro.Text;
            string StrMun = TB_CodMun.Text;
            string StrMunicipio = TB_Municipio.Text;
            string StrUF = TB_UF.Text;
            string StrCEP = TB_CEP.Text;
            string StrEmail = TB_CEP.Text;
            int iRetorno;

            iRetorno = Declaracoes.aCFIdentificarConsumidor_NFCe_Daruma(StrCPF, StrNome, StrLgr, StrNro, StrBairro, StrMun, StrMunicipio, StrUF, StrCEP, StrEmail);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);



        }
    }
}
