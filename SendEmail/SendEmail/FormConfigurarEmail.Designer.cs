namespace SendEmail
{
    partial class FormConfigurarEmail
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxSmtpServer = new System.Windows.Forms.TextBox();
            this.labelSmtp = new System.Windows.Forms.Label();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonGravarDados = new System.Windows.Forms.Button();
            this.groupBoxConfigurarEmail = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.groupBoxConfigurarEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(73, 67);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(455, 20);
            this.textBoxPassword.TabIndex = 18;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 67);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(73, 41);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(455, 20);
            this.textBoxUserName.TabIndex = 16;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(6, 41);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(60, 13);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "User Name";
            // 
            // textBoxSmtpServer
            // 
            this.textBoxSmtpServer.Location = new System.Drawing.Point(73, 93);
            this.textBoxSmtpServer.Name = "textBoxSmtpServer";
            this.textBoxSmtpServer.Size = new System.Drawing.Size(455, 20);
            this.textBoxSmtpServer.TabIndex = 14;
            // 
            // labelSmtp
            // 
            this.labelSmtp.AutoSize = true;
            this.labelSmtp.Location = new System.Drawing.Point(6, 93);
            this.labelSmtp.Name = "labelSmtp";
            this.labelSmtp.Size = new System.Drawing.Size(65, 13);
            this.labelSmtp.TabIndex = 13;
            this.labelSmtp.Text = "Smtp Server";
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(378, 344);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 20;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonGravarDados
            // 
            this.buttonGravarDados.Location = new System.Drawing.Point(459, 344);
            this.buttonGravarDados.Name = "buttonGravarDados";
            this.buttonGravarDados.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarDados.TabIndex = 19;
            this.buttonGravarDados.Text = "&Gravar";
            this.buttonGravarDados.UseVisualStyleBackColor = true;
            this.buttonGravarDados.Click += new System.EventHandler(this.buttonGravarDados_Click);
            // 
            // groupBoxConfigurarEmail
            // 
            this.groupBoxConfigurarEmail.Controls.Add(this.labelPort);
            this.groupBoxConfigurarEmail.Controls.Add(this.textBoxPort);
            this.groupBoxConfigurarEmail.Controls.Add(this.labelUsername);
            this.groupBoxConfigurarEmail.Controls.Add(this.labelSmtp);
            this.groupBoxConfigurarEmail.Controls.Add(this.textBoxSmtpServer);
            this.groupBoxConfigurarEmail.Controls.Add(this.textBoxPassword);
            this.groupBoxConfigurarEmail.Controls.Add(this.textBoxUserName);
            this.groupBoxConfigurarEmail.Controls.Add(this.labelPassword);
            this.groupBoxConfigurarEmail.Location = new System.Drawing.Point(12, 0);
            this.groupBoxConfigurarEmail.Name = "groupBoxConfigurarEmail";
            this.groupBoxConfigurarEmail.Size = new System.Drawing.Size(536, 180);
            this.groupBoxConfigurarEmail.TabIndex = 21;
            this.groupBoxConfigurarEmail.TabStop = false;
            this.groupBoxConfigurarEmail.Text = "Configurar Email";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 125);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 19;
            this.labelPort.Text = "Port";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(73, 125);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(455, 20);
            this.textBoxPort.TabIndex = 20;
            // 
            // FormConfigurarEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 379);
            this.Controls.Add(this.groupBoxConfigurarEmail);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGravarDados);
            this.Name = "FormConfigurarEmail";
            this.Text = "FormConfigurarEmail";
            this.Load += new System.EventHandler(this.FormConfigurarEmail_Load);
            this.groupBoxConfigurarEmail.ResumeLayout(false);
            this.groupBoxConfigurarEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxSmtpServer;
        private System.Windows.Forms.Label labelSmtp;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonGravarDados;
        private System.Windows.Forms.GroupBox groupBoxConfigurarEmail;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxPort;
    }
}