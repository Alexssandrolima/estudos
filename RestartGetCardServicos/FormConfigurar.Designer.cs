namespace RestartGetCardServicos
{
    partial class FormConfigurar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigurar));
            this.panelConfigurar = new System.Windows.Forms.Panel();
            this.buttonProcurarArquivo = new System.Windows.Forms.Button();
            this.textBoxNomedoServicoWindows = new System.Windows.Forms.TextBox();
            this.labelNomeServicoWindows = new System.Windows.Forms.Label();
            this.textBoxNomeLocalextensao = new System.Windows.Forms.TextBox();
            this.labelNomeTefdial = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelConfigurar = new System.Windows.Forms.Label();
            this.panelConfigurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfigurar
            // 
            this.panelConfigurar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConfigurar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConfigurar.Controls.Add(this.buttonProcurarArquivo);
            this.panelConfigurar.Controls.Add(this.textBoxNomedoServicoWindows);
            this.panelConfigurar.Controls.Add(this.labelNomeServicoWindows);
            this.panelConfigurar.Controls.Add(this.textBoxNomeLocalextensao);
            this.panelConfigurar.Controls.Add(this.labelNomeTefdial);
            this.panelConfigurar.Controls.Add(this.buttonCancelar);
            this.panelConfigurar.Controls.Add(this.buttonSalvar);
            this.panelConfigurar.Controls.Add(this.labelConfigurar);
            this.panelConfigurar.Location = new System.Drawing.Point(0, 0);
            this.panelConfigurar.Name = "panelConfigurar";
            this.panelConfigurar.Size = new System.Drawing.Size(659, 440);
            this.panelConfigurar.TabIndex = 0;
            this.panelConfigurar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConfigurar_Paint);
            // 
            // buttonProcurarArquivo
            // 
            this.buttonProcurarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcurarArquivo.Location = new System.Drawing.Point(620, 50);
            this.buttonProcurarArquivo.Name = "buttonProcurarArquivo";
            this.buttonProcurarArquivo.Size = new System.Drawing.Size(25, 23);
            this.buttonProcurarArquivo.TabIndex = 7;
            this.buttonProcurarArquivo.Text = "...";
            this.buttonProcurarArquivo.UseVisualStyleBackColor = true;
            this.buttonProcurarArquivo.Click += new System.EventHandler(this.buttonProcurarArquivo_Click);
            // 
            // textBoxNomedoServicoWindows
            // 
            this.textBoxNomedoServicoWindows.Location = new System.Drawing.Point(214, 84);
            this.textBoxNomedoServicoWindows.Name = "textBoxNomedoServicoWindows";
            this.textBoxNomedoServicoWindows.Size = new System.Drawing.Size(402, 20);
            this.textBoxNomedoServicoWindows.TabIndex = 6;
            // 
            // labelNomeServicoWindows
            // 
            this.labelNomeServicoWindows.AutoSize = true;
            this.labelNomeServicoWindows.Location = new System.Drawing.Point(14, 91);
            this.labelNomeServicoWindows.Name = "labelNomeServicoWindows";
            this.labelNomeServicoWindows.Size = new System.Drawing.Size(151, 13);
            this.labelNomeServicoWindows.TabIndex = 5;
            this.labelNomeServicoWindows.Text = "Nome do Serviço do windows:";
            // 
            // textBoxNomeLocalextensao
            // 
            this.textBoxNomeLocalextensao.Location = new System.Drawing.Point(214, 54);
            this.textBoxNomeLocalextensao.Name = "textBoxNomeLocalextensao";
            this.textBoxNomeLocalextensao.Size = new System.Drawing.Size(402, 20);
            this.textBoxNomeLocalextensao.TabIndex = 4;
            // 
            // labelNomeTefdial
            // 
            this.labelNomeTefdial.AutoSize = true;
            this.labelNomeTefdial.Location = new System.Drawing.Point(14, 57);
            this.labelNomeTefdial.Name = "labelNomeTefdial";
            this.labelNomeTefdial.Size = new System.Drawing.Size(194, 13);
            this.labelNomeTefdial.TabIndex = 3;
            this.labelNomeTefdial.Text = "Local Nome e extenção do Executável:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(489, 403);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.Location = new System.Drawing.Point(570, 403);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelConfigurar
            // 
            this.labelConfigurar.AutoSize = true;
            this.labelConfigurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfigurar.Location = new System.Drawing.Point(12, 9);
            this.labelConfigurar.Name = "labelConfigurar";
            this.labelConfigurar.Size = new System.Drawing.Size(284, 25);
            this.labelConfigurar.TabIndex = 0;
            this.labelConfigurar.Text = "Configuração de Arquivos";
            // 
            // FormConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 440);
            this.Controls.Add(this.panelConfigurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigurar";
            this.Load += new System.EventHandler(this.FormConfigurar_Load);
            this.panelConfigurar.ResumeLayout(false);
            this.panelConfigurar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConfigurar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelConfigurar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNomedoServicoWindows;
        private System.Windows.Forms.Label labelNomeServicoWindows;
        private System.Windows.Forms.TextBox textBoxNomeLocalextensao;
        private System.Windows.Forms.Label labelNomeTefdial;
        private System.Windows.Forms.Button buttonProcurarArquivo;
    }
}