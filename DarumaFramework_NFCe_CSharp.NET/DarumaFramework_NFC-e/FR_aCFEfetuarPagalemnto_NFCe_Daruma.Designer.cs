namespace DarumaFramework_NFCe
{
    partial class FR_aCFEfetuarPagalemnto_NFCe_Daruma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EDT_TIPOPAGAMENTO = new System.Windows.Forms.TextBox();
            this.EDT_VALOR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe os dados para forma de pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // EDT_TIPOPAGAMENTO
            // 
            this.EDT_TIPOPAGAMENTO.Location = new System.Drawing.Point(152, 59);
            this.EDT_TIPOPAGAMENTO.Name = "EDT_TIPOPAGAMENTO";
            this.EDT_TIPOPAGAMENTO.Size = new System.Drawing.Size(100, 20);
            this.EDT_TIPOPAGAMENTO.TabIndex = 3;
            // 
            // EDT_VALOR
            // 
            this.EDT_VALOR.Location = new System.Drawing.Point(152, 94);
            this.EDT_VALOR.Name = "EDT_VALOR";
            this.EDT_VALOR.Size = new System.Drawing.Size(100, 20);
            this.EDT_VALOR.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FR_aCFEfetuarPagalemnto_NFCe_Daruma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EDT_VALOR);
            this.Controls.Add(this.EDT_TIPOPAGAMENTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FR_aCFEfetuarPagalemnto_NFCe_Daruma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aCFEfetuarPagalemnto_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDT_TIPOPAGAMENTO;
        private System.Windows.Forms.TextBox EDT_VALOR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}