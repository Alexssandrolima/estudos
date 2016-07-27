namespace DarumaFramework_NFCe
{
    partial class FR_rInfoEstendida
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
            this.TB_indice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_informacao = new System.Windows.Forms.TextBox();
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indice:";
            // 
            // TB_indice
            // 
            this.TB_indice.Location = new System.Drawing.Point(57, 12);
            this.TB_indice.Name = "TB_indice";
            this.TB_indice.Size = new System.Drawing.Size(142, 20);
            this.TB_indice.TabIndex = 1;
            this.TB_indice.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informação Retornada:";
            // 
            // TB_informacao
            // 
            this.TB_informacao.Location = new System.Drawing.Point(12, 78);
            this.TB_informacao.Multiline = true;
            this.TB_informacao.Name = "TB_informacao";
            this.TB_informacao.Size = new System.Drawing.Size(444, 125);
            this.TB_informacao.TabIndex = 3;
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(300, 222);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(75, 23);
            this.BT_Enviar.TabIndex = 8;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(381, 222);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(75, 23);
            this.BT_Fechar.TabIndex = 7;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // FR_rInfoEstendida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 262);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.TB_informacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_indice);
            this.Controls.Add(this.label1);
            this.Name = "FR_rInfoEstendida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método rInfoEstendida_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_indice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_informacao;
        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
    }
}