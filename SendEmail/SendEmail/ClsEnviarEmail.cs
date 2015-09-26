using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Mail;
using System.Windows.Forms;
using System.Configuration;

namespace SendEmail
{
    class ClsEnviarEmail
    {
        internal static void Enviodeemailrecebendodados(string to, string subject, string body)
        {
            port = Properties.Settings.Default.port;
            smtp = Properties.Settings.Default.smtpserver;
            username = Properties.Settings.Default.usermane;
            password = Properties.Settings.Default.Password;

            MessageBox.Show(" " + port + smtp + username + password);


            MailMessage mail = new MailMessage(username, to, subject, body);
            SmtpClient client = new SmtpClient(smtp, Convert.ToInt16( port));
            client.Credentials = new System.Net.NetworkCredential(username,password);
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                MessageBox.Show("Envio de Email! ", "Sucesso", MessageBoxButtons.OK);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Envio de Email! \r \n " + ex, "Error", MessageBoxButtons.OK);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Envio de Email! \r \n " + exp, "Error", MessageBoxButtons.OK);

            }
        }

        public static string port { get; set; }

        public static string smtp { get; set; }

        public static string username { get; set; }

        public static string password { get; set; }
    }
}
