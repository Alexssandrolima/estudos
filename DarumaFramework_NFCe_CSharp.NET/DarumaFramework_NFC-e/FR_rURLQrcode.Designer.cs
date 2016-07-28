namespace DarumaFramework_NFCe
{
    partial class FR_rURLQrcode
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
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.TB_Retorno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(269, 194);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(88, 23);
            this.BT_Enviar.TabIndex = 19;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(363, 194);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(88, 23);
            this.BT_Fechar.TabIndex = 18;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // TB_Retorno
            // 
            this.TB_Retorno.Location = new System.Drawing.Point(12, 26);
            this.TB_Retorno.Multiline = true;
            this.TB_Retorno.Name = "TB_Retorno";
            this.TB_Retorno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Retorno.Size = new System.Drawing.Size(439, 145);
            this.TB_Retorno.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "URL Retornada:";
            // 
            // FR_rURLQrcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 229);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.TB_Retorno);
            this.Controls.Add(this.label7);
            this.Name = "FR_rURLQrcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método rURLQrcode_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
        private System.Windows.Forms.TextBox TB_Retorno;
        private System.Windows.Forms.Label label7;
    }
}