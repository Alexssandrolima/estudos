using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_iCFImprimir : Form
    {
        public FR_iCFImprimir()
        {
            InitializeComponent();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string PathXMLEntrada,PathXMLSaida, sTipoNF, sLinkQRCode;
            int iNumColunas, iTipoNF, iRetorno;

            sLinkQRCode = TB_LinkQrCode.Text;
            PathXMLEntrada = TB_PathXMLEnvio.Text;
            PathXMLSaida = TB_PathXMLRetorno.Text;
            iNumColunas = Convert.ToInt32(TB_NumColunas.Text);
            sTipoNF = CB_TipoNF.Text;
            iTipoNF = 0;

            if (sTipoNF == "1=NFCe"){iTipoNF = 1;}
            if (sTipoNF == "2=NFe") { iTipoNF = 2; }
            if (sTipoNF == "3=NFSe") { iTipoNF = 3; }
            if (sTipoNF == "4=CTe") { iTipoNF = 4; }
            if (sTipoNF == "5=CANCNFCe") { iTipoNF = 5; }

            iRetorno = Declaracoes.iCFImprimir_NFCe_Daruma(PathXMLEntrada, PathXMLSaida, sLinkQRCode, iNumColunas, iTipoNF);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            

        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
