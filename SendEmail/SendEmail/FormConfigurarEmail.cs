using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;

namespace SendEmail
{
    public partial class FormConfigurarEmail : Form
    {
        public FormConfigurarEmail()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
 

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfigurarEmail_Load(object sender, EventArgs e)
        {
            try
            {

                textBoxUserName.Text = Properties.Settings.Default.usermane;
                textBoxPassword.Text = Properties.Settings.Default.Password;
                textBoxSmtpServer.Text = Properties.Settings.Default.smtpserver;
                textBoxPort.Text = Convert.ToString(Properties.Settings.Default.port);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex.Message);
            }

        }

        private void buttonGravarDados_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != string.Empty && textBoxPassword.Text != string.Empty && textBoxSmtpServer.Text != string.Empty && textBoxPort.Text != string.Empty)
            {
                Properties.Settings.Default["usermane"] = textBoxUserName.Text;
                Properties.Settings.Default["Password"] = textBoxPassword.Text;
                Properties.Settings.Default["smtpserver"] = textBoxSmtpServer.Text;
                Properties.Settings.Default["port"] = textBoxPort.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados em branco!" ,"Error ");
            }


        }

       
    }
}
