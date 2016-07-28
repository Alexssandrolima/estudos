namespace FormListExtraindoTxt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnBuscarTxt = new System.Windows.Forms.Button();
            this.dGVArquivoTexto = new System.Windows.Forms.DataGridView();
            this.lbCabecario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnAcessarSite = new System.Windows.Forms.Button();
            this.statusStripRodape = new System.Windows.Forms.StatusStrip();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArquivoTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarTxt
            // 
            this.btnBuscarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTxt.Location = new System.Drawing.Point(731, 53);
            this.btnBuscarTxt.Name = "btnBuscarTxt";
            this.btnBuscarTxt.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTxt.TabIndex = 0;
            this.btnBuscarTxt.Text = "Buscar&Texto";
            this.btnBuscarTxt.UseVisualStyleBackColor = true;
            this.btnBuscarTxt.Click += new System.EventHandler(this.btnBuscarTxt_Click);
            // 
            // dGVArquivoTexto
            // 
            this.dGVArquivoTexto.AllowUserToAddRows = false;
            this.dGVArquivoTexto.AllowUserToDeleteRows = false;
            this.dGVArquivoTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVArquivoTexto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVArquivoTexto.Location = new System.Drawing.Point(12, 86);
            this.dGVArquivoTexto.Name = "dGVArquivoTexto";
            this.dGVArquivoTexto.ReadOnly = true;
            this.dGVArquivoTexto.Size = new System.Drawing.Size(794, 308);
            this.dGVArquivoTexto.TabIndex = 1;
            this.dGVArquivoTexto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVArquivoTexto_CellClick);
            this.dGVArquivoTexto.SelectionChanged += new System.EventHandler(this.dGVArquivoTexto_SelectionChanged);
            // 
            // lbCabecario
            // 
            this.lbCabecario.AutoSize = true;
            this.lbCabecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecario.Location = new System.Drawing.Point(12, 9);
            this.lbCabecario.Name = "lbCabecario";
            this.lbCabecario.Size = new System.Drawing.Size(317, 16);
            this.lbCabecario.TabIndex = 2;
            this.lbCabecario.Text = "Exportando do arquivo texto para o GridView";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(44, 58);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(46, 13);
            this.lbUsuario.TabIndex = 3;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(242, 58);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 4;
            this.lbSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(289, 55);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(140, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // btnAcessarSite
            // 
            this.btnAcessarSite.Location = new System.Drawing.Point(435, 53);
            this.btnAcessarSite.Name = "btnAcessarSite";
            this.btnAcessarSite.Size = new System.Drawing.Size(75, 23);
            this.btnAcessarSite.TabIndex = 7;
            this.btnAcessarSite.Text = "Acessar&Site";
            this.btnAcessarSite.UseVisualStyleBackColor = true;
            this.btnAcessarSite.Click += new System.EventHandler(this.btnAcessarSite_Click);
            // 
            // statusStripRodape
            // 
            this.statusStripRodape.Location = new System.Drawing.Point(0, 425);
            this.statusStripRodape.Name = "statusStripRodape";
            this.statusStripRodape.Size = new System.Drawing.Size(818, 22);
            this.statusStripRodape.TabIndex = 8;
            this.statusStripRodape.Text = "statusStrip1";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Location = new System.Drawing.Point(731, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 447);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.statusStripRodape);
            this.Controls.Add(this.btnAcessarSite);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbCabecario);
            this.Controls.Add(this.dGVArquivoTexto);
            this.Controls.Add(this.btnBuscarTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessamdo Arquivos Textos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVArquivoTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarTxt;
        private System.Windows.Forms.DataGridView dGVArquivoTexto;
        private System.Windows.Forms.Label lbCabecario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessarSite;
        private System.Windows.Forms.StatusStrip statusStripRodape;
        private System.Windows.Forms.Button btnSair;
    }
}

