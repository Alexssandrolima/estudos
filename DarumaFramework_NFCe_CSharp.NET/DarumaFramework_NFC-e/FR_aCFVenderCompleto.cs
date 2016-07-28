using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_aCFVenderCompleto : Form
    {
        public FR_aCFVenderCompleto()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrAliquota = TB_Aliquota.Text;
            string StrQuantidade = TB_Qtd.Text;
            string StrPrecoUnitario = TB_PrecoUni.Text;
            string StrTipoDescAcresc = TB_TipoDescAcres.Text;
            string StrValorDescAcresc = TB_ValorDescAcres.Text;
            string StrCodigoItem = TB_CodItem.Text;
            string StrNCM = TB_NCM.Text;
            string StrCFOP = TB_CFOP.Text;
            string StrUnidadeMedida = TB_UnidadeMedida.Text;
            string StrDescricaoItem = TB_Descricao.Text;
            int iRetorno;

            iRetorno = Declaracoes.aCFVenderCompleto_NFCe_Daruma(StrAliquota, StrQuantidade,StrPrecoUnitario, StrTipoDescAcresc, StrValorDescAcresc,  StrCodigoItem, StrNCM, StrCFOP, StrUnidadeMedida, StrDescricaoItem, "");
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);

        }


    }
}
