using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DarumaFramework_NFCe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testarSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = Declaracoes.rStatusWS_NFCe_Daruma();
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);


        }

        private void aCFAbrirNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFAbrir_NFCe_Daruma FormPrincipal = new FR_aCFAbrir_NFCe_Daruma();
            FormPrincipal.Show();

        }

        private void aCFVenderNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFVender_NFCe_Daruma FormPrincipal = new FR_aCFVender_NFCe_Daruma();
            FormPrincipal.Show();
        }

        private void aCFTotalizarNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFTotalizar_NFCe_Daruma FormPrincipal = new FR_aCFTotalizar_NFCe_Daruma();
            FormPrincipal.Show();

        }

        private void aCFEfetuarPagamentoNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFEfetuarPagamento FormPrincipal = new FR_aCFEfetuarPagamento();
            FormPrincipal.Show();
        }

        private void tCFEncerrarNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_tCFEncerrar_NFCe_Daruma FormPrincipal = new FR_tCFEncerrar_NFCe_Daruma();
            FormPrincipal.Show();
        }

        private void detectarMiniImpressoraAutomaticamenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Str_Produto = "DUAL";
            string Str_Valor = "";
            string Str_Chave = "PortaComunicacao";
            string Str_ChaveV = "Velocidade";
            string Str_ValorVelocidade = "";
            StringBuilder Str_Velocidade = new StringBuilder();
            StringBuilder Str_Porta = new StringBuilder();
            Str_Velocidade.Length = 100;
            Str_Porta.Length = 100;

            int iRetorno;
            iRetorno = Declaracoes.eBuscarPortaVelocidade_DUAL_DarumaFramework();
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);


            if (iRetorno == 1)
            {
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);

                iRetorno = Declaracoes.regRetornaValorChave_DarumaFramework(Str_Produto, Str_Chave, Str_Porta);
                iRetorno = Declaracoes.regRetornaValorChave_DarumaFramework(Str_Produto, Str_ChaveV, Str_Velocidade);
                MessageBox.Show("PORTA: " + Str_Porta.ToString() + " /  VELOCIDADE: " + Str_Velocidade.ToString());
            }
            else
            {

                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }

        }

        private void configurarMiniImpressoraDUALToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testarImpressoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurarMiniImpressoraDUALToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FR_Configuracao FormPrincipal = new FR_Configuracao();
            FormPrincipal.Show();
        }

        private void testarImpressoraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = Declaracoes.iImprimirTexto_DUAL_DarumaFramework("<bmp></bmp>Daruma Developers<l></l>" +
            "CNPJ-00.000.000/0000-00   I.E-000000000000<l></l>" +
            "Av. Shishima, Urbanova, São José dos Campos-SP<l></l>" +
            "------------------------------------------------<l></l>" +
            "DANFE NFC-e - Documento Auxiliar<l></l>" +
                          "DOCUMENTO DE TESTE<l></l>" +
            "<b>Não permite aproveitamento de crédito de ICMS</b><l></l>" +
            "------------------------------------------------<l></l>" +
            "<c>Item  Cod.   Descricao         Qtde Un   VlrUnit   VlrTot</c><l></l>" +
            "------------------------------------------------<l></l>" +
            "<c>001 12345678909876 Bolacha  53.56  C X  5.25  281.19</c><l></l>" +
            "<c>002 123456  Chinelo de dedo 500  kg X  62.30  31150.00</c><l></l>" +
            "------------------------------------------------<l></l>" +
            "QTD. TOTAL DE ITENS                          002<l></l>" +
            "VALOR TOTAL R$                           5143.56<l></l>" +

            "FORMA DE PAGAMENTO                    Valor Pago<l></l>" +
            "Cheque                                     35.75<l></l>" +
            "------------------------------------------------<l></l>" +
            "Informação dos Tributos Totais Incidentes(Lei Federal 12.741/2012)                          1,00------------------------------------------------" +
            "             AREA DE MENSAGEM FISCAL<l></l>" +
            "<c>Número:00000089 Série:0   Emissão:00/00/2000 00:00:00 <l></l><ce> Via</ce><c>" +
            "<c> <ce>Consumidor</ce></c><l></l>" +
            "Consulte pela Chave de Acesso em: http://www.desenvolvedoresdaruma.com.br<l></l>" +
            "                   CHAVE DE ACESSO<l></l>" +
            "<c>  0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000</c><l></l>" +
            "------------------------------------------------<l></l>" +
            "                   CONSUMIDOR<l></l>" +
            "      CNPJ/CPF/ID Estrangeiro - 00000000000<l></l>" +
            "------------------------------------------------<l></l>" +
            "         Consulta via leitor de QR Code<l></l>" +
            "<ce><qrcode>http://www.desenvolvedoresdaruma.com.br</qrcode></ce><l></l>" +
            "<c> Protocolo de Autorização: 99999999 00/00/0000 00:00:00</c><sl>4</sl><gui></gui><l></l>", 0);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);

        }

        private void configurarChaveDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_ChaveDesenvolvedor FormPrincipal = new FR_ChaveDesenvolvedor();
            FormPrincipal.Show();
        }

        private void aCFLançarDescontoItemNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFLancarDescontoItem FormPrincipal = new FR_aCFLancarDescontoItem();
            FormPrincipal.Show();
        }

        private void aCFLançarAcrescimoItemNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFLancarAcrescimoItem FormPrincipal = new FR_aCFLancarAcrescimoItem();
            FormPrincipal.Show();

        }

        private void métodoACFCancelarItemParcialNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFCancelarItemParcial FormPrincipal = new FR_aCFCancelarItemParcial();
            FormPrincipal.Show();
        }

        private void descontoEAcréscimoDeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aCFCancelarItemNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFCancelarItem_NFCe_Daruma FormPrincipal = new FR_aCFCancelarItem_NFCe_Daruma();
            FormPrincipal.Show();
        }

        private void métodoACFCancelarAcrescimoItemNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFCancelarAcrescimoItem FormPrincipal = new FR_aCFCancelarAcrescimoItem();
            FormPrincipal.Show();
        }

        private void métodoACFCancelarDescontoItemNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFCancelarDescontoItem FormPrincipal = new FR_aCFCancelarDescontoItem();
            FormPrincipal.Show();
        }

        private void métodoTCFCancelarNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_tCFCancelar FormPrincipal = new FR_tCFCancelar();
            FormPrincipal.Show();
        }


   
        private void métodoICFImprimirNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_iCFImprimir FormPrincipal = new FR_iCFImprimir();
            FormPrincipal.Show();
        }



        private void métodoACFValorLeiImpostoNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iRetorno;
            int posX = ((SystemInformation.WorkingArea.Width / 2) - 150);
            int posY = ((SystemInformation.WorkingArea.Height / 2) - 150);

            string StrValorImposto = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor do Imposto já na formatação que será impresso: ", "Daruma Framework", "1,00", posX, posY);


            iRetorno = Declaracoes.aCFValorLeiImposto_NFCe_Daruma(StrValorImposto);
            string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
            MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);


        }

        private void métodoACFAbrirNumSerieNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFAbrirNumSerie FormPrincipal = new FR_aCFAbrirNumSerie();
            FormPrincipal.Show();
        }

        private void métodoACFVenderCompletoNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFVenderCompleto FormPrincipal = new FR_aCFVenderCompleto();
            FormPrincipal.Show();
        }

   

        private void métodoACFIdentificarConsumidorNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_aCFIdentificarConsumidor FormPrincipal = new FR_aCFIdentificarConsumidor();
            FormPrincipal.Show();
        }

        private void métodoTCFInutilizarNFCeDarumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_tCFInutilizar FormPrincipal = new FR_tCFInutilizar();
            FormPrincipal.Show();
        }

        private void métodoRAvisoErroNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StringBuilder StrCodigo = new StringBuilder();
            StrCodigo.Length = 4;
            StringBuilder StrMensagem = new StringBuilder(); 
            StrMensagem.Length = 600;
            int iRetorno;

            iRetorno = Declaracoes.rAvisoErro_NFCe_Daruma(StrCodigo, StrMensagem);
            if (iRetorno == 1)
            {
                MessageBox.Show("Código do Aviso/Erro: " + StrCodigo.ToString() + " - " + StrMensagem.ToString(), "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            else
            {
                string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }

        }

        private void métodoRURLQrcodeNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_rURLQrcode FormPrincipal = new FR_rURLQrcode();
            FormPrincipal.Show();

        }

        private void métodoRRetornaInformacaoNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_rRetornaInformacao FormPrincipal = new FR_rRetornaInformacao();
            FormPrincipal.Show();
        }

        private void métodoRCFVerificarStatusNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int iRetorno;

            iRetorno = Declaracoes.rCFVerificarStatus_NFCe_Daruma();
            if (iRetorno == 0)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - Cupom Fechado.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 1)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e Aberta, sem itens.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 2)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e Aberta e com itens registrados.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 3)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e Totalizada.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 4)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e Totalmente Paga.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 5)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e já Encerrada.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
            if (iRetorno == 6)
            {
                MessageBox.Show("[" + iRetorno.ToString() + "] - NFC-e Cancelada.", "DarumaFramework - NFCe", MessageBoxButtons.OK);
            }
        }

        private void métodoRInfoEstendidaNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_rInfoEstendida FormPrincipal = new FR_rInfoEstendida();
            FormPrincipal.Show();
        }

        private void testeDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_VendaBufferizada FormPrincipal = new FR_VendaBufferizada();
            FormPrincipal.Show();
        }

        private void métodoICFReImprimirNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_iCFReImprimir FormPrincipal = new FR_iCFReImprimir();
            FormPrincipal.Show();
        }

        private void configurarDadosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FR_ConfiguraCliente FormPrincipal = new FR_ConfiguraCliente();
            FormPrincipal.Show();
        }

        private void métodoRegAlterarValorNFCeDarumaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int iRetorno;
            int posX = ((SystemInformation.WorkingArea.Width / 2) - 150);
            int posY = ((SystemInformation.WorkingArea.Height / 2) - 150);

            string Str_Chave = Microsoft.VisualBasic.Interaction.InputBox("Digite o path da Chave: ", "Método regAlterarValor_NFCe_Daruma", "CONFIGURACAO\\TipoAmbiente", posX, posY);
            string Str_ValorChave = Microsoft.VisualBasic.Interaction.InputBox("Digite o valor da Chave: ", "Método regAlterarValor_NFCe_Daruma", "3", posX, posY);

            if ((Str_Chave != "") || (Str_ValorChave != ""))
            {
                iRetorno = Declaracoes.regAlterarValor_NFCe_Daruma(Str_Chave, Str_ValorChave);
                if (iRetorno == 1)
                {
                    MessageBox.Show("Valor da Chave Configurada: " + Str_Chave + "\\" + Str_ValorChave, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
                else
                {
                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                    MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
            }
            

        }

        private void métodoRegRetornarValorNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int iRetorno;
            int posX = ((SystemInformation.WorkingArea.Width / 2) - 150);
            int posY = ((SystemInformation.WorkingArea.Height / 2) - 150);
            StringBuilder StrValorRetornado = new StringBuilder(); 
            StrValorRetornado.Length = 400;


            string Str_Chave = Microsoft.VisualBasic.Interaction.InputBox("Digite o caminho completo da tag que deseja consultar: ", "Método regRetornarValor_NFCe_Daruma", "CONFIGURACAO\\EmpPK", posX, posY);
           
            if (Str_Chave != "")
            {
                iRetorno = Declaracoes.regRetornarValor_NFCe_Daruma(Str_Chave, StrValorRetornado);
                if (iRetorno == 1)
                {
                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                    MessageBox.Show("Valor Retornando: " + StrValorRetornado.ToString(), "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
                else
                {
                    string strMsgRetorno = Declaracoes.TrataRetorno(iRetorno);
                    MessageBox.Show("Retorno do método: " + strMsgRetorno, "DarumaFramework - NFCe", MessageBoxButtons.OK);
                }
            }
            
        }

        private void métodoACFIdentificarTransportadoraNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_aCFIdentificarTransportadora FormPrincipal = new FR_aCFIdentificarTransportadora();
            FormPrincipal.Show();
        }

        private void métodoACFEstornarPagamentoNFCeDarumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FR_aCFEstornarPagamento FormPrincipal = new FR_aCFEstornarPagamento();
            FormPrincipal.Show();
        }

  



    }
}

