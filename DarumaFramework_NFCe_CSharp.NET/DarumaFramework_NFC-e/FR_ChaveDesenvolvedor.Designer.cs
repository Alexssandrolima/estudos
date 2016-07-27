namespace DarumaFramework_NFCe
{
    partial class FR_ChaveDesenvolvedor
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
            this.label2 = new System.Windows.Forms.Label();
            this.EDT_CHAVEDESENVOLVEDOR = new System.Windows.Forms.TextBox();
            this.BTN_ENVIAR = new System.Windows.Forms.Button();
            this.BTN_FECHAR = new System.Windows.Forms.Button();
            this.label3_hiperlink = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chave: ";
            // 
            // EDT_CHAVEDESENVOLVEDOR
            // 
            this.EDT_CHAVEDESENVOLVEDOR.Location = new System.Drawing.Point(62, 20);
            this.EDT_CHAVEDESENVOLVEDOR.Name = "EDT_CHAVEDESENVOLVEDOR";
            this.EDT_CHAVEDESENVOLVEDOR.Size = new System.Drawing.Size(275, 20);
            this.EDT_CHAVEDESENVOLVEDOR.TabIndex = 2;
            // 
            // BTN_ENVIAR
            // 
            this.BTN_ENVIAR.Location = new System.Drawing.Point(185, 87);
            this.BTN_ENVIAR.Name = "BTN_ENVIAR";
            this.BTN_ENVIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENVIAR.TabIndex = 3;
            this.BTN_ENVIAR.Text = "Enviar";
            this.BTN_ENVIAR.UseVisualStyleBackColor = true;
            this.BTN_ENVIAR.Click += new System.EventHandler(this.BTN_ENVIAR_Click);
            // 
            // BTN_FECHAR
            // 
            this.BTN_FECHAR.Location = new System.Drawing.Point(266, 87);
            this.BTN_FECHAR.Name = "BTN_FECHAR";
            this.BTN_FECHAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_FECHAR.TabIndex = 4;
            this.BTN_FECHAR.Text = "Fechar";
            this.BTN_FECHAR.UseVisualStyleBackColor = true;
            this.BTN_FECHAR.Click += new System.EventHandler(this.BTN_FECHAR_Click);
            // 
            // label3_hiperlink
            // 
            this.label3_hiperlink.AutoSize = true;
            this.label3_hiperlink.Location = new System.Drawing.Point(12, 56);
            this.label3_hiperlink.Name = "label3_hiperlink";
            this.label3_hiperlink.Size = new System.Drawing.Size(238, 13);
            this.label3_hiperlink.TabIndex = 5;
            this.label3_hiperlink.Text = "Essa mensagem você recebeu via e-mail após o ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(245, 56);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cadastro.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FR_ChaveDesenvolvedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 128);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3_hiperlink);
            this.Controls.Add(this.BTN_FECHAR);
            this.Controls.Add(this.BTN_ENVIAR);
            this.Controls.Add(this.EDT_CHAVEDESENVOLVEDOR);
            this.Controls.Add(this.label2);
            this.Name = "FR_ChaveDesenvolvedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Chave Desenvolvedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDT_CHAVEDESENVOLVEDOR;
        private System.Windows.Forms.Button BTN_ENVIAR;
        private System.Windows.Forms.Button BTN_FECHAR;
        private System.Windows.Forms.Label label3_hiperlink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}