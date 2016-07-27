using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_tCFInutilizar : Form
    {
        public FR_tCFInutilizar()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            string StrnNFInic = TB_NumNotaInicio.Text;
            string StrnNFFim = TB_NumNotaFim.Text;
            string StrNSerie = TB_NumSerie.Text;
            string StrJustificativa = TB_Justificativa.Text;
            int iRetorno;

            iRetorno = Declaracoes.tCFInutilizar_NFCe_Daruma(StrnNFInic, StrnNFFim, StrNSerie, StrJustificativa);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);


        }
    }
}
