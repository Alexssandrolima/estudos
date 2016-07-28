namespace DarumaFramework_NFCe
{
    partial class FR_iCFReImprimir
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
            this.TB_Parametro1 = new System.Windows.Forms.TextBox();
            this.TB_Parametro3 = new System.Windows.Forms.TextBox();
            this.TB_Parametro2 = new System.Windows.Forms.TextBox();
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parâmetro 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parâmetro 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parâmetro 3:";
            // 
            // TB_Parametro1
            // 
            this.TB_Parametro1.Location = new System.Drawing.Point(85, 20);
            this.TB_Parametro1.Name = "TB_Parametro1";
            this.TB_Parametro1.Size = new System.Drawing.Size(272, 20);
            this.TB_Parametro1.TabIndex = 3;
            // 
            // TB_Parametro3
            // 
            this.TB_Parametro3.Location = new System.Drawing.Point(85, 106);
            this.TB_Parametro3.Name = "TB_Parametro3";
            this.TB_Parametro3.Size = new System.Drawing.Size(272, 20);
            this.TB_Parametro3.TabIndex = 4;
            // 
            // TB_Parametro2
            // 
            this.TB_Parametro2.Location = new System.Drawing.Point(85, 61);
            this.TB_Parametro2.Name = "TB_Parametro2";
            this.TB_Parametro2.Size = new System.Drawing.Size(272, 20);
            this.TB_Parametro2.TabIndex = 5;
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(175, 144);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(88, 23);
            this.BT_Enviar.TabIndex = 13;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(269, 144);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(88, 23);
            this.BT_Fechar.TabIndex = 12;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // FR_iCFReImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 186);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Controls.Add(this.TB_Parametro2);
            this.Controls.Add(this.TB_Parametro3);
            this.Controls.Add(this.TB_Parametro1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FR_iCFReImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Método iCFReImprimir_NFCe_Daruma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Parametro1;
        private System.Windows.Forms.TextBox TB_Parametro3;
        private System.Windows.Forms.TextBox TB_Parametro2;
        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
    }
}