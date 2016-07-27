using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_rRetornaInformacao : Form
    {
        public FR_rRetornaInformacao()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrTipoIntervalo, StrInic, StrFim, StrSerie, StrChaveAcesso, StrInfoConsulta;
            StrTipoIntervalo = CB_Tipo.Text;
            StrInic = TB_Inicio.Text;
            StrFim = TB_Fim.Text;
            StrSerie = TB_Serie.Text;
            StrChaveAcesso = TB_Chave.Text;
            StrInfoConsulta = TB_indice.Text;
            StringBuilder StrResposta = new StringBuilder();
            StrResposta.Length = 550;
            int iRetorno;

            iRetorno = Declaracoes.rRetornarInformacao_NFCe_Daruma(StrTipoIntervalo, StrInic, StrFim, StrSerie, StrChaveAcesso, StrInfoConsulta, StrResposta);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            TB_Retorno.Text = StrResposta.ToString();
        }

    

     
    }
}
