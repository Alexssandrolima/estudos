namespace DarumaFramework_NFCe
{
    partial class FR_VendaBufferizada
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
            this.BT_Enviar = new System.Windows.Forms.Button();
            this.BT_Fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_numCupom = new System.Windows.Forms.TextBox();
            this.TB_numItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_Enviar
            // 
            this.BT_Enviar.Location = new System.Drawing.Point(90, 95);
            this.BT_Enviar.Name = "BT_Enviar";
            this.BT_Enviar.Size = new System.Drawing.Size(88, 23);
            this.BT_Enviar.TabIndex = 17;
            this.BT_Enviar.Text = "Enviar";
            this.BT_Enviar.UseVisualStyleBackColor = true;
            this.BT_Enviar.Click += new System.EventHandler(this.BT_Enviar_Click);
            // 
            // BT_Fechar
            // 
            this.BT_Fechar.Location = new System.Drawing.Point(184, 95);
            this.BT_Fechar.Name = "BT_Fechar";
            this.BT_Fechar.Size = new System.Drawing.Size(88, 23);
            this.BT_Fechar.TabIndex = 16;
            this.BT_Fechar.Text = "Fechar";
            this.BT_Fechar.UseVisualStyleBackColor = true;
            this.BT_Fechar.Click += new System.EventHandler(this.BT_Fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Número de Cupons:";
            // 
            // TB_numCupom
            // 
            this.TB_numCupom.Location = new System.Drawing.Point(119, 14);
            this.TB_numCupom.Name = "TB_numCupom";
            this.TB_numCupom.Size = new System.Drawing.Size(153, 20);
            this.TB_numCupom.TabIndex = 19;
            this.TB_numCupom.Text = "5";
            // 
            // TB_numItem
            // 
            this.TB_numItem.Location = new System.Drawing.Point(119, 49);
            this.TB_numItem.Name = "TB_numItem";
            this.TB_numItem.Size = new System.Drawing.Size(153, 20);
            this.TB_numItem.TabIndex = 21;
            this.TB_numItem.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Número de Itens:";
            // 
            // FR_VendaBufferizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.TB_numItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_numCupom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Enviar);
            this.Controls.Add(this.BT_Fechar);
            this.Name = "FR_VendaBufferizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste de Venda Bufferizada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Enviar;
        private System.Windows.Forms.Button BT_Fechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_numCupom;
        private System.Windows.Forms.TextBox TB_numItem;
        private System.Windows.Forms.Label label2;
    }
}