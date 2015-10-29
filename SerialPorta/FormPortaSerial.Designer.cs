namespace SerialPorta
{
    partial class FormPortaSerial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPortaSerial = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelMessagem = new System.Windows.Forms.Label();
            this.textBoxMessagem = new System.Windows.Forms.TextBox();
            this.labelbaudRate = new System.Windows.Forms.Label();
            this.textBoxbaudRate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelbaudRate);
            this.panel1.Controls.Add(this.textBoxbaudRate);
            this.panel1.Controls.Add(this.labelMessagem);
            this.panel1.Controls.Add(this.textBoxMessagem);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.labelPortaSerial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 425);
            this.panel1.TabIndex = 0;
            // 
            // labelPortaSerial
            // 
            this.labelPortaSerial.AutoSize = true;
            this.labelPortaSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPortaSerial.Location = new System.Drawing.Point(12, 9);
            this.labelPortaSerial.Name = "labelPortaSerial";
            this.labelPortaSerial.Size = new System.Drawing.Size(487, 37);
            this.labelPortaSerial.TabIndex = 0;
            this.labelPortaSerial.Text = "Tabalhando com portas seriais";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(147, 113);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(352, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(16, 120);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelMessagem
            // 
            this.labelMessagem.AutoSize = true;
            this.labelMessagem.Location = new System.Drawing.Point(16, 157);
            this.labelMessagem.Name = "labelMessagem";
            this.labelMessagem.Size = new System.Drawing.Size(67, 13);
            this.labelMessagem.TabIndex = 4;
            this.labelMessagem.Text = "Messangem:";
            // 
            // textBoxMessagem
            // 
            this.textBoxMessagem.Location = new System.Drawing.Point(147, 150);
            this.textBoxMessagem.Name = "textBoxMessagem";
            this.textBoxMessagem.Size = new System.Drawing.Size(352, 20);
            this.textBoxMessagem.TabIndex = 3;
            // 
            // labelbaudRate
            // 
            this.labelbaudRate.AutoSize = true;
            this.labelbaudRate.Location = new System.Drawing.Point(16, 187);
            this.labelbaudRate.Name = "labelbaudRate";
            this.labelbaudRate.Size = new System.Drawing.Size(57, 13);
            this.labelbaudRate.TabIndex = 6;
            this.labelbaudRate.Text = "baudRate:";
            // 
            // textBoxbaudRate
            // 
            this.textBoxbaudRate.Location = new System.Drawing.Point(147, 180);
            this.textBoxbaudRate.Name = "textBoxbaudRate";
            this.textBoxbaudRate.Size = new System.Drawing.Size(352, 20);
            this.textBoxbaudRate.TabIndex = 5;
            // 
            // FormPortaSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 425);
            this.Controls.Add(this.panel1);
            this.Name = "FormPortaSerial";
            this.Text = "Tabalhando com porta serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPortaSerial;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelMessagem;
        private System.Windows.Forms.TextBox textBoxMessagem;
        private System.Windows.Forms.Label labelbaudRate;
        private System.Windows.Forms.TextBox textBoxbaudRate;
    }
}

