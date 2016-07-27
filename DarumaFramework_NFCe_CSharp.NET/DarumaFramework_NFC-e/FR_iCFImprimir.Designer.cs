namespace DarumaFramework_NFCe
{
    partial class FR_iCFImprimir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TB_PathXMLEnvio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PathXMLRetorno = new System.Windows.Forms.TextBox();
            this.TB_NumColunas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_LinkQrCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_TipoNF = new System.Windows.Forms.ComboBox();
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho do xml de envio:";
            // 
            // TB_PathXMLEnvio
            // 
            this.TB_PathXMLEnvio.Location = new System.Drawing.Point(15, 25);
            this.TB_PathXMLEnvio.Name = "TB_PathXMLEnvio";
            this.TB_PathXMLEnvio.Size = new System.Drawing.Size(257, 20);
            this.TB_PathXMLEnvio.TabIndex = 1;
            this.TB_PathXMLEnvio.Text = "C:\\documentosEnvio.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho do xml de retorno:";
            // 
            // TB_PathXMLRetorno
            // 
            this.TB_PathXMLRetorno.Location = new System.Drawing.Point(15, 79);
            this.TB_PathXMLRetorno.Name = "TB_PathXMLRetorno";
            this.TB_PathXMLRetorno.Size = new System.Drawing.Size(257, 20);
            this.TB_PathXMLRetorno.TabIndex = 3;
            this.TB_PathXMLRetorno.Text = "C:\\documentosRetorno.xml";
            // 
            // TB_NumColunas
            // 
            this.TB_NumColunas.Location = new System.Drawing.Point(15, 186);
            this.TB_NumColunas.Name = "TB_NumColunas";
            this.TB_NumColunas.Size = new System.Drawing.Size(257, 20);
            this.TB_NumColunas.TabIndex = 7;
            this.TB_NumColunas.Text = "48";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número de colunas Impressora:";
            // 
            // TB_LinkQrCode
            // 
            this.TB_LinkQrCode.Location = new System.Drawing.Point(15, 132);
            this.TB_LinkQrCode.Name = "TB_LinkQrCode";
            this.TB_LinkQrCode.Size = new System.Drawing.Size(257, 20);
            this.TB_LinkQrCode.TabIndex = 5;
            this.TB_LinkQrCode.Text = "www.desenvolvedoresdaruma.com.br";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Link para QrCode (se vazio, captura link no XML):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo NF:";
            // 
            // CB_TipoNF
            // 
            this.CB_TipoNF.FormattingEnabled = true;
            this.CB_TipoNF.Items.AddRange(new object[] {
            "1=NFCe",
            "2=NFe",
            "3=NFSe",
            "4=CTe",
            "5=CANCNFCe"});
            this.CB_TipoNF.Location = new System.Drawing.Point(15, 241);
            this.CB_TipoNF.Name = "CB_TipoNF";
            this.CB_TipoNF.Size = new System.Drawing.Size(257, 21);
            this.CB_TipoNF.TabIndex = 9;
            this.CB_TipoNF.Text = "1=NFCe";
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(90, 284);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(88, 23);
            this.BT_Enviar.TabIndex = 11;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(184, 284);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(88, 23);
            this.BT_Fechar.TabIndex = 10;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // FR_iCFImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.CB_TipoNF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_NumColunas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_LinkQrCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_PathXMLRetorno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_PathXMLEnvio);
            this.Controls.Add(this.label1);
            this.Name = "FR_iCFImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método iCFImprimir_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_PathXMLEnvio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PathXMLRetorno;
        private System.Windows.Forms.TextBox TB_NumColunas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_LinkQrCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_TipoNF;
        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
    }
}