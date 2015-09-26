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
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
            this.Text = "Enviando Email Via C#";

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            


        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            if (textBoxTo.Text != string.Empty && textBoxSubject.Text != string.Empty && textBoxBody.Text != string.Empty)
            {
                ClsEnviarEmail.Enviodeemailrecebendodados(textBoxTo.Text, textBoxSubject.Text, textBoxBody.Text);
            }
            else
            {
                textBoxTo.Text = " faltando dados";
            }



        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
