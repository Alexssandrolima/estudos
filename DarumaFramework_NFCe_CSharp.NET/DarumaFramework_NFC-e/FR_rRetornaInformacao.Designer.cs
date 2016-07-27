namespace DarumaFramework_NFCe
{
    partial class FR_rRetornaInformacao
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
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Inicio = new System.Windows.Forms.TextBox();
            this.TB_Fim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Chave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Serie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_indice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Retorno = new System.Windows.Forms.TextBox();
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "DATA",
            "CHAVE",
            "NUM"});
            this.CB_Tipo.Location = new System.Drawing.Point(94, 12);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(129, 21);
            this.CB_Tipo.TabIndex = 0;
            this.CB_Tipo.Text = "DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Intervalo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fim:";
            // 
            // TB_Inicio
            // 
            this.TB_Inicio.Location = new System.Drawing.Point(55, 52);
            this.TB_Inicio.Name = "TB_Inicio";
            this.TB_Inicio.Size = new System.Drawing.Size(126, 20);
            this.TB_Inicio.TabIndex = 4;
            this.TB_Inicio.Text = "01012014";
            // 
            // TB_Fim
            // 
            this.TB_Fim.Location = new System.Drawing.Point(313, 52);
            this.TB_Fim.Name = "TB_Fim";
            this.TB_Fim.Size = new System.Drawing.Size(126, 20);
            this.TB_Fim.TabIndex = 5;
            this.TB_Fim.Text = "31012014";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chave de Acesso:";
            // 
            // TB_Chave
            // 
            this.TB_Chave.Location = new System.Drawing.Point(110, 89);
            this.TB_Chave.Name = "TB_Chave";
            this.TB_Chave.Size = new System.Drawing.Size(329, 20);
            this.TB_Chave.TabIndex = 7;
            this.TB_Chave.Text = "123456789012345678901234567890123456789";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Série:";
            // 
            // TB_Serie
            // 
            this.TB_Serie.Location = new System.Drawing.Point(54, 132);
            this.TB_Serie.Name = "TB_Serie";
            this.TB_Serie.Size = new System.Drawing.Size(127, 20);
            this.TB_Serie.TabIndex = 9;
            this.TB_Serie.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Índice:";
            // 
            // TB_indice
            // 
            this.TB_indice.Location = new System.Drawing.Point(245, 132);
            this.TB_indice.Name = "TB_indice";
            this.TB_indice.Size = new System.Drawing.Size(195, 20);
            this.TB_indice.TabIndex = 11;
            this.TB_indice.Text = "1+2+3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Retorno:";
            // 
            // TB_Retorno
            // 
            this.TB_Retorno.Location = new System.Drawing.Point(13, 193);
            this.TB_Retorno.Multiline = true;
            this.TB_Retorno.Name = "TB_Retorno";
            this.TB_Retorno.Size = new System.Drawing.Size(427, 145);
            this.TB_Retorno.TabIndex = 13;
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(258, 355);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(88, 23);
            this.BT_Enviar.TabIndex = 15;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(352, 355);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(88, 23);
            this.BT_Fechar.TabIndex = 14;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // FR_rRetornaInformacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 401);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.TB_Retorno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_indice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Serie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Chave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Fim);
            this.Controls.Add(this.TB_Inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Tipo);
            this.Name = "FR_rRetornaInformacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método rRetornaInformacao_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Inicio;
        private System.Windows.Forms.TextBox TB_Fim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_Chave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Serie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_indice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Retorno;
        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
    }
}