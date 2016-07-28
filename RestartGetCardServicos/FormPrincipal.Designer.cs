namespace RestartGetCardServicos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.webBbanner1 = new System.Windows.Forms.WebBrowser();
            this.labelConfiguracao = new System.Windows.Forms.Label();
            this.buttonIniciarServiço = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.listBoxPrincipal = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPrincipal = new System.Windows.Forms.GroupBox();
            this.groupBoxConfiguracao = new System.Windows.Forms.GroupBox();
            this.groupBoxAutomaticamente = new System.Windows.Forms.GroupBox();
            this.checkBoxReiniciarVpn = new System.Windows.Forms.CheckBox();
            this.checkBoxLigarTefDialReiniciar = new System.Windows.Forms.CheckBox();
            this.checkBoxAutomatica = new System.Windows.Forms.CheckBox();
            this.labelVersao = new System.Windows.Forms.Label();
            this.progressBarRodape = new System.Windows.Forms.ProgressBar();
            this.timerSistema = new System.Windows.Forms.Timer(this.components);
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAutomaticamente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Controls.Add(this.progressBarRodape);
            this.panelPrincipal.Controls.Add(this.labelVersao);
            this.panelPrincipal.Controls.Add(this.webBbanner1);
            this.panelPrincipal.Controls.Add(this.labelConfiguracao);
            this.panelPrincipal.Controls.Add(this.buttonIniciarServiço);
            this.panelPrincipal.Controls.Add(this.buttonCancelar);
            this.panelPrincipal.Controls.Add(this.buttonSair);
            this.panelPrincipal.Controls.Add(this.listBoxPrincipal);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.groupBoxPrincipal);
            this.panelPrincipal.Controls.Add(this.groupBoxConfiguracao);
            this.panelPrincipal.Controls.Add(this.groupBoxAutomaticamente);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1025, 461);
            this.panelPrincipal.TabIndex = 0;
            // 
            // webBbanner1
            // 
            this.webBbanner1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.webBbanner1.Location = new System.Drawing.Point(639, 12);
            this.webBbanner1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBbanner1.Name = "webBbanner1";
            this.webBbanner1.ScrollBarsEnabled = false;
            this.webBbanner1.Size = new System.Drawing.Size(364, 431);
            this.webBbanner1.TabIndex = 12;
            this.webBbanner1.Url = new System.Uri("http://vciga.dyndns.org/banner.html", System.UriKind.Absolute);
            // 
            // labelConfiguracao
            // 
            this.labelConfiguracao.AutoSize = true;
            this.labelConfiguracao.Location = new System.Drawing.Point(527, 19);
            this.labelConfiguracao.Name = "labelConfiguracao";
            this.labelConfiguracao.Size = new System.Drawing.Size(100, 13);
            this.labelConfiguracao.TabIndex = 8;
            this.labelConfiguracao.Text = "<< Configuração >> ";
            this.labelConfiguracao.Click += new System.EventHandler(this.labelConfiguracao_Click);
            // 
            // buttonIniciarServiço
            // 
            this.buttonIniciarServiço.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarServiço.Location = new System.Drawing.Point(12, 331);
            this.buttonIniciarServiço.Name = "buttonIniciarServiço";
            this.buttonIniciarServiço.Size = new System.Drawing.Size(269, 94);
            this.buttonIniciarServiço.TabIndex = 6;
            this.buttonIniciarServiço.Text = "Reiniciar &Serviço GET";
            this.buttonIniciarServiço.UseVisualStyleBackColor = true;
            this.buttonIniciarServiço.Click += new System.EventHandler(this.buttonIniciarServiço_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(465, 393);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(91, 33);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "S&alvar e Sair";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(561, 393);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 33);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sai&r";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listBoxPrincipal
            // 
            this.listBoxPrincipal.FormattingEnabled = true;
            this.listBoxPrincipal.Location = new System.Drawing.Point(23, 85);
            this.listBoxPrincipal.Name = "listBoxPrincipal";
            this.listBoxPrincipal.Size = new System.Drawing.Size(365, 225);
            this.listBoxPrincipal.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestartGetCardServicos.Properties.Resources.cartao;
            this.pictureBox1.Location = new System.Drawing.Point(394, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 229);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restartando GetCard e Serviços";
            // 
            // groupBoxPrincipal
            // 
            this.groupBoxPrincipal.Location = new System.Drawing.Point(12, 68);
            this.groupBoxPrincipal.Name = "groupBoxPrincipal";
            this.groupBoxPrincipal.Size = new System.Drawing.Size(621, 257);
            this.groupBoxPrincipal.TabIndex = 3;
            this.groupBoxPrincipal.TabStop = false;
            this.groupBoxPrincipal.Text = "Ações Andamento";
            // 
            // groupBoxConfiguracao
            // 
            this.groupBoxConfiguracao.Location = new System.Drawing.Point(519, 3);
            this.groupBoxConfiguracao.Name = "groupBoxConfiguracao";
            this.groupBoxConfiguracao.Size = new System.Drawing.Size(114, 39);
            this.groupBoxConfiguracao.TabIndex = 9;
            this.groupBoxConfiguracao.TabStop = false;
            // 
            // groupBoxAutomaticamente
            // 
            this.groupBoxAutomaticamente.Controls.Add(this.checkBoxReiniciarVpn);
            this.groupBoxAutomaticamente.Controls.Add(this.checkBoxLigarTefDialReiniciar);
            this.groupBoxAutomaticamente.Controls.Add(this.checkBoxAutomatica);
            this.groupBoxAutomaticamente.Location = new System.Drawing.Point(287, 327);
            this.groupBoxAutomaticamente.Name = "groupBoxAutomaticamente";
            this.groupBoxAutomaticamente.Size = new System.Drawing.Size(174, 98);
            this.groupBoxAutomaticamente.TabIndex = 10;
            this.groupBoxAutomaticamente.TabStop = false;
            // 
            // checkBoxReiniciarVpn
            // 
            this.checkBoxReiniciarVpn.AutoSize = true;
            this.checkBoxReiniciarVpn.Location = new System.Drawing.Point(17, 43);
            this.checkBoxReiniciarVpn.Name = "checkBoxReiniciarVpn";
            this.checkBoxReiniciarVpn.Size = new System.Drawing.Size(131, 17);
            this.checkBoxReiniciarVpn.TabIndex = 14;
            this.checkBoxReiniciarVpn.Text = "Reiniciar Serviço VPN";
            this.checkBoxReiniciarVpn.UseVisualStyleBackColor = true;
            // 
            // checkBoxLigarTefDialReiniciar
            // 
            this.checkBoxLigarTefDialReiniciar.AutoSize = true;
            this.checkBoxLigarTefDialReiniciar.Location = new System.Drawing.Point(17, 19);
            this.checkBoxLigarTefDialReiniciar.Name = "checkBoxLigarTefDialReiniciar";
            this.checkBoxLigarTefDialReiniciar.Size = new System.Drawing.Size(145, 17);
            this.checkBoxLigarTefDialReiniciar.TabIndex = 13;
            this.checkBoxLigarTefDialReiniciar.Text = "Ligar TefDial ao Reiniciar";
            this.checkBoxLigarTefDialReiniciar.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutomatica
            // 
            this.checkBoxAutomatica.AutoSize = true;
            this.checkBoxAutomatica.Location = new System.Drawing.Point(17, 66);
            this.checkBoxAutomatica.Name = "checkBoxAutomatica";
            this.checkBoxAutomatica.Size = new System.Drawing.Size(154, 17);
            this.checkBoxAutomatica.TabIndex = 7;
            this.checkBoxAutomatica.Text = "Automaticamente ao Iniciar";
            this.checkBoxAutomatica.UseVisualStyleBackColor = true;
            // 
            // labelVersao
            // 
            this.labelVersao.AutoSize = true;
            this.labelVersao.Location = new System.Drawing.Point(556, 52);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(79, 13);
            this.labelVersao.TabIndex = 13;
            this.labelVersao.Text = "Versão 2.00.00";
            // 
            // progressBarRodape
            // 
            this.progressBarRodape.Location = new System.Drawing.Point(12, 432);
            this.progressBarRodape.Name = "progressBarRodape";
            this.progressBarRodape.Size = new System.Drawing.Size(621, 16);
            this.progressBarRodape.TabIndex = 14;
            // 
            // timerSistema
            // 
            this.timerSistema.Enabled = true;
            this.timerSistema.Tick += new System.EventHandler(this.timerSistema_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 461);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restartando o GetCard e Serviços do windows";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAutomaticamente.ResumeLayout(false);
            this.groupBoxAutomaticamente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxPrincipal;
        private System.Windows.Forms.GroupBox groupBoxPrincipal;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.CheckBox checkBoxAutomatica;
        private System.Windows.Forms.Button buttonIniciarServiço;
        private System.Windows.Forms.Label labelConfiguracao;
        private System.Windows.Forms.GroupBox groupBoxConfiguracao;
        private System.Windows.Forms.GroupBox groupBoxAutomaticamente;
        private System.Windows.Forms.WebBrowser webBbanner1;
        private System.Windows.Forms.CheckBox checkBoxReiniciarVpn;
        private System.Windows.Forms.CheckBox checkBoxLigarTefDialReiniciar;
        private System.Windows.Forms.Label labelVersao;
        private System.Windows.Forms.ProgressBar progressBarRodape;
        private System.Windows.Forms.Timer timerSistema;
    }
}

