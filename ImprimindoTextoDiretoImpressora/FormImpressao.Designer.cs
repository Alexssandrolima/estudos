namespace ImprimindoTextoDiretoImpressora
{
    partial class FormImpressao
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
            this.comboBoxImpressoras = new System.Windows.Forms.ComboBox();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.textBoxImpressao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxImpressoras
            // 
            this.comboBoxImpressoras.FormattingEnabled = true;
            this.comboBoxImpressoras.Location = new System.Drawing.Point(12, 12);
            this.comboBoxImpressoras.Name = "comboBoxImpressoras";
            this.comboBoxImpressoras.Size = new System.Drawing.Size(459, 21);
            this.comboBoxImpressoras.TabIndex = 0;
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(477, 10);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(75, 23);
            this.buttonImprimir.TabIndex = 1;
            this.buttonImprimir.Text = "&Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // textBoxImpressao
            // 
            this.textBoxImpressao.Location = new System.Drawing.Point(12, 39);
            this.textBoxImpressao.Multiline = true;
            this.textBoxImpressao.Name = "textBoxImpressao";
            this.textBoxImpressao.Size = new System.Drawing.Size(540, 344);
            this.textBoxImpressao.TabIndex = 2;
            // 
            // FormImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.textBoxImpressao);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.comboBoxImpressoras);
            this.Name = "FormImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão de Texto Diretamente na Impressora";
            this.Load += new System.EventHandler(this.FormImpressao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxImpressoras;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.TextBox textBoxImpressao;
    }
}

