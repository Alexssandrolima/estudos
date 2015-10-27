using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Drawing;
//using System.Security.Permissions;
using System.Windows.Forms;

//administra serviço do windows.
using System.ServiceProcess;
// administrando executaveis.
using System.Diagnostics;
// administrando as pastas de arquivos.
using System.IO;
using RestartGetCardServicos.Properties;

//usando web no form.
//using System.Web;


//using System.Security.CodeAccessPermission;
//using System.Security.Permissions.ResourcePermissionBase;
//using System.ServiceProcess.ServiceControllerPermission;


namespace RestartGetCardServicos
{
    public partial class FormPrincipal : Form
    {
        public bool Automaticamente { get; set; }
        public bool Ligadosim { get; set; }

        readonly string _username = Environment.ExpandEnvironmentVariables("%USERNAME%");
        readonly string _userdomain = Environment.ExpandEnvironmentVariables("%USERDOMAIN%");
        //string SystemDrive = Environment.ExpandEnvironmentVariables("%SystemDrive%");
        readonly string _varSourcePath = Environment.CurrentDirectory + "\\";


        readonly string _varMachineName = Environment.MachineName;

        public FormPrincipal()
        {
            InitializeComponent();
            
        
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Settings.Default.Automatica = checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();

                    listBoxPrincipal.Items.Add("Desligando o sistema ... ");
                    if (MessageBox.Show(Resources.Desejasairdosistema, Resources.SaindodoSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    {
                        Checharboxautomaticoligadodesligado();
                        Application.Exit();
                    }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            Settings.Default.Automatica =  checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();
            Application.Restart();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("_varMachineName >> " + _varMachineName);

            listBoxPrincipal.Items.Add(" Bom dia! " + _username);
            listBoxPrincipal.Items.Add(" Pressione Reiniciar Serviço no " + _userdomain);
            listBoxPrincipal.Items.Add(" ou Selecione \" Reiniciar Automaticamento ao iniciar na proxima vez! \" ");
            listBoxPrincipal.Items.Add(" Executando em: " + _varSourcePath);

            //checharboxautomaticoligadodesligado();

            if (Automaticamente == Settings.Default.Automatica)
            {
                Ligadosim = true;
                //MessageBox.Show("Automatico já esta ligado ... " + ligadosim + " > " + automaticamente );
                listBoxPrincipal.Items.Add("Automatico já esta ligado ... ");
                checkBoxAutomatica.Checked = Automaticamente;
                RestartartandoServicosExecutaveis();
            }


            if(Automaticamente = Settings.Default.ReiniciarVpn)
            {
                checkBoxReiniciarVpn.Checked = true;
            }
            else
            {
                checkBoxReiniciarVpn.Checked = false;
                
            }


            if(Automaticamente = Settings.Default.LigarTefDial)
            {
                checkBoxLigarTefDialReiniciar.Checked = true;
            }
            else
            {
                checkBoxLigarTefDialReiniciar.Checked = false;
            }



        }

        private void Checharboxautomaticoligadodesligado()
        {
            if (checkBoxAutomatica.Checked)
            {
                listBoxPrincipal.Items.Add("automatico ligado ... ");
                if (!Ligadosim)
                {
                    Ligadosim = true;
                    //MessageBox.Show(" configurando o check box " + ligadosim);
                }
            }
            else
            {
                Ligadosim = false;
                //MessageBox.Show(" desconfigurando o checkbox " + ligadosim);
            }

            Settings.Default.Automatica = Ligadosim;
            Settings.Default.Save();

        }

        private void buttonIniciarServiço_Click(object sender, EventArgs e)
        {
            RestartartandoServicosExecutaveis();
        }

        private void RestartartandoServicosExecutaveis()
        {

            //MessageBox.Show("" + checkBoxAutomatica.Checked);
            //MessageBox.Show("" + checkBoxReiniciarVpn.Checked);
            //MessageBox.Show("" + checkBoxLigarTefDialReiniciar.Checked);


            Settings.Default.Automatica = checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();

            
            
            //checharboxautomaticoligadodesligado();
            listBoxPrincipal.Items.Add("Iniciando ... ");

            Nomedoservicodowindows = Settings.Default.NomedoServicoWindows;
            Nomeextensaoservico = Path.GetFileNameWithoutExtension(Nomedoservicodowindows);


            Desligarexecutavel();
            if (Automaticamente = Settings.Default.ReiniciarVpn)
            {
                Desligandoservicodowindows();
                Ligandoservicodowindows();
            }
            if (Automaticamente = Settings.Default.LigarTefDial)
            {
                Ligandoexecutavel();
            }
        }

        private void Ligandoservicodowindows()
        {
            listBoxPrincipal.Items.Add("== Começando a ligar >>" + Nomedoservicodowindows + "==");
            StopService(Nomeextensaoservico, 100000);
            listBoxPrincipal.Items.Add("== Continuando a ligar>>" + Nomedoservicodowindows + "==");
        }

        private void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                
                //int millisec1 = Environment.TickCount;
                //listBoxPrincipal.Items.Add("== millisec1 >>" + millisec1 + "==");
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                //listBoxPrincipal.Items.Add("== timeout >>" + timeout + "==");

                service.MachineName = _varMachineName;

                listBoxPrincipal.Items.Add("== service.Start >>" + service.Status.ToString() + "==");
                service.Start();
                listBoxPrincipal.Items.Add("== service.Start >>" + service.Status.ToString() + "==");
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                listBoxPrincipal.Items.Add("== service.Start >>" + service.Status.ToString() + "==");
                //MessageBox.Show("verifique se startou o serviço agora");
                listBoxPrincipal.Items.Add("== service.Start >>" + service.Status.ToString() + "==");
            }
            catch (Exception ex)
            {
                listBoxPrincipal.Items.Add("Erro! >>" + ex.InnerException.Message + " >> " + ex.Message);
                MessageBox.Show(Resources.FormPrincipal_StopService_ErrorEncontrado + ex.InnerException.Message + ex.Message);
            }
        }

        public void StartService(string serviceName, int timeoutMilliseconds)
        {
            listBoxPrincipal.Items.Add("== Começando >>" + serviceName + " T:" + timeoutMilliseconds + "==");
            ServiceController service = new ServiceController(serviceName);

 
            try
            {
                //int millisec1 = Environment.TickCount;
                //listBoxPrincipal.Items.Add("== millisec1 >>" + millisec1 + "==");
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                //listBoxPrincipal.Items.Add("== timeout >>" + timeout + "==");

                service.MachineName = _varMachineName;

                listBoxPrincipal.Items.Add("== service.Stop >>" + service.Status.ToString() + "==");


                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                listBoxPrincipal.Items.Add("== service.Stop >>" + service.Status.ToString() + "==");
                //MessageBox.Show("verifique se parou o serviço agora");

            }
            catch (Exception ex)
            {

                //string texto = "Paulo Viana";
                //Label1.Text = texto;
                //Label1.ForeColor = System.Drawing.Color.Red;

                


                string nomemessagem = "Erro Encontrado no serviço. >>" + ex.InnerException.Message + " >> " + ex.Message;
                listBoxPrincipal.Items.Add(nomemessagem);
                MessageBox.Show(Resources.FormPrincipal_StopService_ErrorEncontrado + ex.InnerException.Message + ex.Message);
            }
        }


        private void Desligandoservicodowindows()
        {

            listBoxPrincipal.Items.Add("== Começando a desligar o >> " + Nomedoservicodowindows + "==");
            StartService(Nomeextensaoservico, 100000);
            listBoxPrincipal.Items.Add("== Continuando o precesso >> " + Nomedoservicodowindows + "==");

            //if (Nomedoservicodowindows != string.Empty)
            //{
            //    //MessageBox.Show("entou no if >>" + nomedoservicodowindows);
            //    var service = new ServiceController(Nomedoservicodowindows);
            //    try
            //    {

            //        //MessageBox.Show("Parando ... " + service.ServiceName);

            //        listBoxPrincipal.Items.Add("== Parando o serviço >>" + Nomedoservicodowindows + "==");
            //        listBoxPrincipal.Items.Add("Parando ... " + service.ServiceName);
            //        if ((service.Status.Equals(ServiceControllerStatus.Running)) ||
            //            (service.Status.Equals(ServiceControllerStatus.StartPending)))
            //            service.Stop();

            //        listBoxPrincipal.Items.Add("== Ligando serviço >>" + Nomedoservicodowindows + "==");
            //        listBoxPrincipal.Items.Add("Iniciando ... " + service.ServiceName);
            //        if ((service.Status.Equals(ServiceControllerStatus.Stopped)) ||
            //            (service.Status.Equals(ServiceControllerStatus.StopPending)))
            //            service.Start();
            //        MessageBox.Show("Iniciando o serviço " + service.ServiceName + "\n Aguarde um momento! ","Reiniciando Serviço" ); 
            //        listBoxPrincipal.Items.Add("Concluído ... " + service.ServiceName);

            //    }
            //    catch (Exception ex)
            //    {
            //        listBoxPrincipal.Items.Add("Erro, " + ex.Message + "Erro Encontrado no serviço.");
            //        //MessageBox.Show("Erro ao iniciar o serviço ose \n" + ex.Message);
            //    }

            //}
        }

        private void Ligandoexecutavel()
        {
            listBoxPrincipal.Items.Add("== Ligando >> " + NomeLocalextensao + "==");

//            listBoxPrincipal.Items.Add("Ligando serviço >>" + nomeLocalextensao);
            if (NomeLocalextensao != string.Empty)
            {
                listBoxPrincipal.Items.Add("Entrando para Ligar o serviço >>" + NomeLocalextensao);
                try
                {


                    if(File.Exists(NomeLocalextensao))
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo(NomeLocalextensao);

                        startInfo.WorkingDirectory = NomeDiretorio;
                        listBoxPrincipal.Items.Add("Processando o arquivo " + startInfo.FileName);



                        //var service = new ServiceController(Nomedoservicodowindows);
                        //if ((service.Status.Equals(ServiceControllerStatus.StartPending)))
                        //{
                            Process.Start(startInfo);
                        //}
                        //else
                        //{
                        //    Process.Start(startInfo);
                        //}

                        //Process.Start(nomeLocalextensao).WaitForExit();
                    }



            //        //Process currentProcess = Process.GetCurrentProcess(nomeLocalextensao);

            //        //Process[] processes = Process.GetProcesses(nomeLocalextensao);
            //        Process[] processes = Process.GetProcessesByName(nomeLocalextensao);

            //        MessageBox.Show("processes " + processes[0]);
            //        foreach (Process proc in processes)
            //        {
            //            MessageBox.Show("proc " + proc);
            //            if (File.Exists(nomeLocalextensao))
            //            {
            //                listBoxPrincipal.Items.Add("Arquivo encontrado " + proc.ProcessName);

            //                proc.Start();
            //                //proc.CloseMainWindow();
            //                //proc.WaitForExit();
            //                listBoxPrincipal.Items.Add("Executando o arquivo " + proc.ProcessName);
            //                //this.Close();
            //            }
            //            else
            //            {
            //#if DEBUG
            //                MessageBox.Show("Arquivo nâo encontrado " + proc.ProcessName);
            //#else
            //                listBoxPrincipal.Items.Add("Arquivo nâo encontrado " + proc.ProcessName);
            //#endif
            //            }
            //        }
                }
                catch (Exception erro)
                {
                    #if DEBUG
                    MessageBox.Show(erro.Message + "");
                    #else
                    listBoxPrincipal.Items.Add(erro.Message + " ");
                    #endif

                }
            }
        }

        private void Desligarexecutavel()
        {
            listBoxPrincipal.Items.Add("== Desligando >> " + NomeLocalextensao + "==");

            NomeLocalextensao = Settings.Default.NomeLocalextensao;

            // pegando o nome do arquivo junto com a extensão;
            //FileInfo fi = new FileInfo(nomeLocalextensao);
            //nomeextensao = fi.Name;

            // removendo caminho e extenção do arquivo.  
            Nomeextensao = Path.GetFileNameWithoutExtension(NomeLocalextensao);
            NomeDiretorio = Path.GetDirectoryName(NomeLocalextensao);

            //MessageBox.Show("pegando arquivo sem extensão ... " + nomeextensao);
            

            //MessageBox.Show("Parando ... " + nomeextensao);
            if (Nomeextensao != string.Empty)
            {

                listBoxPrincipal.Items.Add("desligando o executável >>" + Nomeextensao);
                try
                {
                    var processes = Process.GetProcessesByName(Nomeextensao);
                    foreach (var process in processes)
                    {
                        //MessageBox.Show("Parando o executavel " + process.ProcessName);

                        listBoxPrincipal.Items.Add("Parando o executavel " + process.ProcessName);
                        process.Kill();
                    }
                }
                catch (Exception error)
                {
                    listBoxPrincipal.Items.Add("Erro ao Finalizar programas encontrar o arquivo " + error.Message);
                    //                MessageBox.Show(errorletodb + " Erro ao Finalizar programas encontrar o arquivo \n \r letodb, xci_bcc, xci_paf, xcig_bcc, xcig_paf");
                }
            }
        }

        private void labelConfiguracao_Click(object sender, EventArgs e)
        {
            listBoxPrincipal.Items.Add("== Configurando o Sistema ==");

            var configurar = new FormConfigurar();
            configurar.ShowDialog();
        }
        public string Nomedoservicodowindows { get; set; }

        public string NomeLocalextensao { get; set; }

        public string Nomeextensao { get; set; }

        public string NomeDiretorio { get; set; }

        public string Nomeextensaoservico { get; set; }


        private void SuppressScriptErrorsOnly(WebBrowser Browser)
        {
            // Ensure that ScriptErrorsSuppressed is set to false.
            Browser.ScriptErrorsSuppressed = false;

            // Handle DocumentCompleted to gain access to the Document object.
            Browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Browser_DocumentCompleted);
        }

        public void Window_Error(object sender,HtmlElementErrorEventArgs e)
        {
            // Ignore the error and suppress the error dialog box. 
            e.Handled = true;
        }

        public bool ScriptErrorsSuppressed { get; set; }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
