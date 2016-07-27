using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_ConfiguraCliente : Form
    {
        public FR_ConfiguraCliente()
        {
            InitializeComponent();
        }
  
        private void BT_Enviar_Click(object sender, EventArgs e)
        {
        String StrcUF = TB_cUf.Text;
        String StrcMunFG = TB_cMunFG.Text;
        String StrCNPJ = TB_CNPJ.Text;
        String StrCPF = TB_CPF.Text;
        String StrxNome = TB_Nome.Text;
        String StrxLgr = TB_Lgr.Text;
        String StrNro = TB_Nro.Text;
        String StrxBairro = TB_Bairro.Text;
        String StrcMun = TB_CMun.Text;
        String StrxMun = TB_Municipio.Text;
        String StrUF = TB_Uf.Text;
        String StrCEP = TB_Cep.Text;
        String StrIE = TB_Ie.Text;
        String StrCRT = TB_Crt.Text;
        int iRetorno;
                

        if ( (StrcUF != "") & (StrCNPJ != "") & (StrCPF != "") & (StrxNome != "") & (StrxLgr != "") & (StrNro != "") & 
            (StrxBairro != "") & (StrcMun != "") & (StrxMun != "") & (StrUF != "") & (StrCEP != "") & (StrIE != "") & (StrCRT != "")) 
            {
                
                Declaracoes.regAlterarValor_NFCe_Daruma("IDE\\cUF", StrcUF);
                Declaracoes.regAlterarValor_NFCe_Daruma("IDE\\cMunFG", StrcMunFG);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\CNPJ", StrCNPJ);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\CPF", StrCPF);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\xNome", StrxNome);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\xLgr", StrxLgr);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\Nro", StrNro);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\xBairro", StrxBairro);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\cMun", StrcMun);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\xMun", StrxMun);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\UF", StrUF);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\ENDEREMIT\\CEP", StrCEP);
                Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\IE", StrIE);
                iRetorno = Declaracoes.regAlterarValor_NFCe_Daruma("EMIT\\CRT", StrCRT);

                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);     
            }       
            
        else
            {
            MessageBox.Show("Preencha todos os campos!", "Daruma DLL Framework", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
