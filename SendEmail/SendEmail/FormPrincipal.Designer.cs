﻿namespace SendEmail
{
    partial class FormPrincipal
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
            this.buttonEnviarEmail = new System.Windows.Forms.Button();
            this.buttonConfiguracao = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEnviarEmail
            // 
            this.buttonEnviarEmail.Location = new System.Drawing.Point(426, 156);
            this.buttonEnviarEmail.Name = "buttonEnviarEmail";
            this.buttonEnviarEmail.Size = new System.Drawing.Size(181, 95);
            this.buttonEnviarEmail.TabIndex = 0;
            this.buttonEnviarEmail.Text = "Enviar &Email";
            this.buttonEnviarEmail.UseVisualStyleBackColor = true;
            this.buttonEnviarEmail.Click += new System.EventHandler(this.buttonEnviarEmail_Click);
            // 
            // buttonConfiguracao
            // 
            this.buttonConfiguracao.Location = new System.Drawing.Point(239, 156);
            this.buttonConfiguracao.Name = "buttonConfiguracao";
            this.buttonConfiguracao.Size = new System.Drawing.Size(181, 95);
            this.buttonConfiguracao.TabIndex = 0;
            this.buttonConfiguracao.Text = "&Configuração";
            this.buttonConfiguracao.Click += new System.EventHandler(this.buttonConfigurcao_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(532, 365);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 15;
            this.buttonFechar.Text = "&Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enviando E-mail e configurando";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonConfiguracao);
            this.Controls.Add(this.buttonEnviarEmail);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEnviarEmail;
        private System.Windows.Forms.Button buttonConfiguracao;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Label label1;
    }
}