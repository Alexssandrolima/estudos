namespace LendoGravandoArquivoIni
{
    partial class Form1
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
            this.textBoxDanfe = new System.Windows.Forms.TextBox();
            this.listBoxArquivoIni = new System.Windows.Forms.ListBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.textBoxLetoIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local arquivo danfe:";
            // 
            // textBoxDanfe
            // 
            this.textBoxDanfe.Location = new System.Drawing.Point(174, 68);
            this.textBoxDanfe.Name = "textBoxDanfe";
            this.textBoxDanfe.Size = new System.Drawing.Size(359, 20);
            this.textBoxDanfe.TabIndex = 1;
            // 
            // listBoxArquivoIni
            // 
            this.listBoxArquivoIni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxArquivoIni.FormattingEnabled = true;
            this.listBoxArquivoIni.Location = new System.Drawing.Point(12, 183);
            this.listBoxArquivoIni.Name = "listBoxArquivoIni";
            this.listBoxArquivoIni.Size = new System.Drawing.Size(581, 225);
            this.listBoxArquivoIni.TabIndex = 2;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(456, 452);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 3;
            this.buttonGravar.Text = "Gravar ini";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // textBoxLetoIP
            // 
            this.textBoxLetoIP.Location = new System.Drawing.Point(176, 96);
            this.textBoxLetoIP.Name = "textBoxLetoIP";
            this.textBoxLetoIP.Size = new System.Drawing.Size(359, 20);
            this.textBoxLetoIP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "leto ip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "leto ip:";
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Location = new System.Drawing.Point(176, 126);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(357, 21);
            this.comboBoxIp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 503);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLetoIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.listBoxArquivoIni);
            this.Controls.Add(this.textBoxDanfe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDanfe;
        private System.Windows.Forms.ListBox listBoxArquivoIni;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.TextBox textBoxLetoIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxIp;
    }
}

