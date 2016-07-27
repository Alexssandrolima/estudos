using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DarumaFramework_NFCe
{
    public partial class FR_VendaBufferizada : Form
    {
        public FR_VendaBufferizada()
        {
            InitializeComponent();
        }

        private void BT_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Enviar_Click(object sender, EventArgs e)
        {
            int Int_Qtd_Cupom; //Guarda a Quantidade de Cupom desejado
            int Int_Qtd_Itens; //Guarda a Quantidade de Item desejado
            string Str_Qtd_Cupom; //Recebe do InputBox a Qtd desejada
            string Str_Qtd_Itens; //Recebe do InputBox a Qtd desejada
            string Str_TimeFinal;
            string Str_TimeInicial;
            int iRetorno;
            int Int_Contador;            
            long Int_Codigo;
            Str_Qtd_Cupom = TB_numCupom.Text.Trim();
            Str_Qtd_Itens = TB_numItem.Text.Trim();
            Int_Contador = 1;
            Int_Codigo = 1234567890;
            if ((Str_Qtd_Cupom == "") || (Str_Qtd_Itens == ""))
            {
                return;
            }
            Int_Qtd_Cupom = int.Parse(Str_Qtd_Cupom);
            Str_TimeInicial = DateTime.Now.ToLongTimeString();
            while (Int_Qtd_Cupom != 0)
            {
                Int_Qtd_Itens = int.Parse(Str_Qtd_Itens);
                //AbreCupom
                
                iRetorno = Declaracoes.aCFAbrir_NFCe_Daruma("", "", "", "", "", "", "", "", "");
                while (Int_Qtd_Itens != 0)
                {
                    //Vende Item
                    //iRetorno = 0;
                    iRetorno = Declaracoes.aCFVender_NFCe_Daruma("F1", "1,00", "0,10", "D%", "0,00", Int_Codigo.ToString(), "UN", "Item" + Int_Contador.ToString() + "Teste Venda");
                    Int_Contador = Int_Contador + 1;
                    Int_Codigo = Int_Codigo + 1;
                    if (iRetorno != 1)
                    {
                        MessageBox.Show("Foi Detectado Erro na Venda de Item!! Vamos Cancelar o Cupom", "Daruma_Framework_NFCe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        iRetorno = Declaracoes.tCFCancelar_NFCe_Daruma("", "", "", "", "");
                        return;
                    }
                    Int_Qtd_Itens = Int_Qtd_Itens - 1;
                }

                iRetorno = Declaracoes.aCFTotalizar_NFCe_Daruma("D%", "0,00");
                StringBuilder StrRetorno = new StringBuilder(); 
                StrRetorno.Length = 20;
                iRetorno = Declaracoes.rInfoEstendida_NFCe_Daruma("1", StrRetorno);
                iRetorno = Declaracoes.aCFEfetuarPagamento_NFCe_Daruma("Dinheiro", StrRetorno.ToString());
                iRetorno = Declaracoes.tCFEncerrar_NFCe_Daruma("");
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);

                Int_Qtd_Cupom = Int_Qtd_Cupom - 1;
            }
            Str_TimeFinal = DateTime.Now.ToLongTimeString();

            MessageBox.Show("Time Inicial = " + Str_TimeInicial + "\n" + "TimeFinal = " + Str_TimeFinal, "DarumaFramework - NFCe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            


        }
    }
}
