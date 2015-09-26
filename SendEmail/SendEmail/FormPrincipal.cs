using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.Text = "Tela Principal do Aplicativo";
        }

        private void buttonEnviarEmail_Click(object sender, EventArgs e)
        {
            FormEmail teladeemail = new FormEmail();
            teladeemail.ShowDialog();
        }

        private void buttonConfigurcao_Click(object sender, EventArgs e)
        {
            FormConfigurarEmail teladeconfiguracao = new FormConfigurarEmail();
            teladeconfiguracao.ShowDialog();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
