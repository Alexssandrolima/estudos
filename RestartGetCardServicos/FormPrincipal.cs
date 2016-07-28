using System;
using System.Windows.Forms;

//administra serviço do windows.
using System.ServiceProcess;
// administrando executaveis.
using System.Diagnostics;
// administrando as pastas de arquivos.
using System.IO;
using RestartGetCardServicos.Properties;
using System.Threading;

//using System.Security.CodeAccessPermission;
//using System.Security.Permissions.ResourcePermissionBase;
//using System.ServiceProcess.ServiceControllerPermission;


namespace RestartGetCardServicos
{
    public partial class FormPrincipal : Form
    {
        #region " Variaveis de anbiente "
        public bool _iniciarAutomaticamente { get; set; }
        //public bool _iniciarAutoLigadoSimNao { get; set; }

        readonly string _usuarioNome = Environment.ExpandEnvironmentVariables("%USERNAME%");
        readonly string _usuarioDominio = Environment.ExpandEnvironmentVariables("%USERDOMAIN%");
        //string SystemDrive = Environment.ExpandEnvironmentVariables("%SystemDrive%");
        readonly string _varPastaLocalInicaldaAplicacao = Environment.CurrentDirectory + "\\";

        readonly string _varNomedaMaquina = Environment.MachineName;

        public string _statusrodandooservico { get; set; }
        public int _tempoexecusaoservico { get; set; }

        public string _nomedoservicodowindows { get; set; }
        public string _nomeLocalextensao { get; set; }
        public string _nomeextensao { get; set; }
        public string _nomeDiretorio { get; set; }
        public string _nomeextensaoservico { get; set; }

        public string _sVerificacao { get; set; }
        public bool _automaticamenteVpn { get; set; }
        public bool _automaticamenteTefDial { get; set; }

        public bool ScriptErrorsSuppressed { get; set; }

        ServiceController service;

        #endregion " Variaveis de anbiente "

        #region " Inicialização da aplicação "

        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _iniciarAutomaticamente = Settings.Default.Automatica;
 
            //MessageBox.Show("_varMachineName >> " + _varMachineName);

            listBoxPrincipal.Items.Add(" Bom dia! " + _usuarioNome);
            listBoxPrincipal.Items.Add(" Pressione Reiniciar Serviço no " + _usuarioDominio);
            listBoxPrincipal.Items.Add(" ou Selecione \" Reiniciar Automaticamento ao iniciar na proxima vez! \" ");
            listBoxPrincipal.Items.Add(" Executando em: " + _varPastaLocalInicaldaAplicacao);

            //checharboxautomaticoligadodesligado();

            _automaticamenteVpn = Settings.Default.ReiniciarVpn;
            if (_automaticamenteVpn)            {
                checkBoxReiniciarVpn.Checked = true;
            }
            else            {
                checkBoxReiniciarVpn.Checked = false;
            }

            _automaticamenteTefDial = Settings.Default.LigarTefDial;
            if (_automaticamenteTefDial)            {
                checkBoxLigarTefDialReiniciar.Checked = true;
            }
            else            {
                checkBoxLigarTefDialReiniciar.Checked = false;
            }

            if (_iniciarAutomaticamente)            {
                //MessageBox.Show("Automatico já esta ligado ... " + ligadosim + " > " + automaticamente );
                listBoxPrincipal.Items.Add("Seleção Automatico esta ligado ... ");
                checkBoxAutomatica.Checked = true;
                progressBarRodape.Value = 0;
                buttonIniciarServiço.Enabled = false;
                buttonCancelar.Enabled = false;
                RestartartandoServicosExecutaveis();
                buttonCancelar.Enabled = true;
                buttonIniciarServiço.Enabled = true;
                progressBarRodape.Value = 100;
            }
        }

        #endregion " Inicialização da aplicação "

        #region " Butões da aplicação "
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Settings.Default.Automatica = checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();

            listBoxPrincipal.Items.Add("Desligando o sistema ... ");
            if (MessageBox.Show(Resources.Desejasairdosistema, Resources.SaindodoSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
            {
                //Checharboxautomaticoligadodesligado();
                Application.Exit();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Settings.Default.Automatica = checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();
            //Application.Exit(); 
            Application.Restart();
        }

        private void buttonIniciarServiço_Click(object sender, EventArgs e)
        {
            progressBarRodape.Value = 0;
            buttonIniciarServiço.Enabled = false;
            buttonCancelar.Enabled = false;
            RestartartandoServicosExecutaveis();
            buttonCancelar.Enabled = true;
            buttonIniciarServiço.Enabled = true;
            progressBarRodape.Value = 100;
        }

        private void labelConfiguracao_Click(object sender, EventArgs e)
        {
            listBoxPrincipal.Items.Add("== Configurando o Sistema ==");

            var configurar = new FormConfigurar();
            configurar.ShowDialog();
        }

        #endregion " Butões da aplicação "

        #region " Metodos executados "

        //private void Checharboxautomaticoligadodesligado()
        //{
        //    if (checkBoxAutomatica.Checked)
        //    {
        //        listBoxPrincipal.Items.Add("Realmente o automatico esta ligado ... ");
        //        if (!_iniciarAutoLigadoSimNao)
        //        {
        //            _iniciarAutoLigadoSimNao = true;
        //            //MessageBox.Show(" configurando o check box " + ligadosim);
        //        }
        //    }
        //    else
        //    {
        //        _iniciarAutoLigadoSimNao = false;
        //        //MessageBox.Show(" desconfigurando o checkbox " + ligadosim);
        //    }
        //    Settings.Default.Automatica = _iniciarAutoLigadoSimNao;
        //    Settings.Default.Save();
        //}

        public void RestartartandoServicosExecutaveis()
        {
            listBoxPrincipal.Items.Clear();
            progressBarRodape.Value = progressBarRodape.Value + 2;
            //MessageBox.Show("" + checkBoxAutomatica.Checked);
            //MessageBox.Show("" + checkBoxReiniciarVpn.Checked);
            //MessageBox.Show("" + checkBoxLigarTefDialReiniciar.Checked);

            progressBarRodape.Value = progressBarRodape.Value + 2;
            Settings.Default.Automatica = checkBoxAutomatica.Checked;
            Settings.Default.ReiniciarVpn = checkBoxReiniciarVpn.Checked;
            Settings.Default.LigarTefDial = checkBoxLigarTefDialReiniciar.Checked;
            Settings.Default.Save();

            progressBarRodape.Value = progressBarRodape.Value + 2;
            
            //checharboxautomaticoligadodesligado();
            listBoxPrincipal.Items.Add("Vamos iniciar agora! ... ");

            _nomedoservicodowindows = Settings.Default.NomedoServicoWindows;
            progressBarRodape.Value = progressBarRodape.Value + 2; 
            


            //bool sVerificaArquivo = Convert.ToBoolean( );
            _nomeextensaoservico = Path.GetFileNameWithoutExtension(_nomedoservicodowindows);

            
            _tempoexecusaoservico = 100000;
            progressBarRodape.Value = progressBarRodape.Value + 2;

            Desligarexecutavel();

            progressBarRodape.Value = progressBarRodape.Value + 2;

            _automaticamenteVpn = Settings.Default.ReiniciarVpn;
            if (_automaticamenteVpn)
            {
                Desligandoservicodowindows();

                progressBarRodape.Value = progressBarRodape.Value + 2;    
                
                //colocar uma pause aqui

                Ligandoservicodowindows();
            }
            _automaticamenteTefDial = Settings.Default.LigarTefDial;
            if (_automaticamenteTefDial)
            {
                //colocar uma pausa aqui
                progressBarRodape.Value = progressBarRodape.Value + 2; 
                Ligandoexecutavel();
                progressBarRodape.Value = progressBarRodape.Value + 2;
            }

            if (_automaticamenteVpn)listBoxPrincipal.Items.Add("Status do serviço no windows agora! >> " + service.Status);
            
            progressBarRodape.Value = progressBarRodape.Value + 2;

        }

        public void Desligandoservicodowindows()
        {
            listBoxPrincipal.Items.Add("== Desligando o serviço no windows! >> " + _nomedoservicodowindows + " ==");
            progressBarRodape.Value = progressBarRodape.Value + 2;
            StopService(_nomeextensaoservico, _tempoexecusaoservico);
            progressBarRodape.Value = progressBarRodape.Value + 2;
            listBoxPrincipal.Items.Add("== Desligado e Executando o próximo passo >> " + _nomedoservicodowindows + " ==");
        }

        public void Ligandoservicodowindows()
        {
            listBoxPrincipal.Items.Add("== Ligando o serviço no windows! >> " + _nomedoservicodowindows + " ==");
            progressBarRodape.Value = progressBarRodape.Value + 2;
            StartService(_nomeextensaoservico, _tempoexecusaoservico);
            progressBarRodape.Value = progressBarRodape.Value + 2;
            listBoxPrincipal.Items.Add("== Ligado e Executando o próximo passo >> " + _nomedoservicodowindows + " ==");
        }

        public void StartService(string serviceName, int timeoutMilliseconds)
        {
            _sVerificacao = service.Status.ToString();

            if (_sVerificacao != "Running")
            {
                listBoxPrincipal.Items.Add("== Inicio da Execursão do serviço!  >> " + serviceName + " T:" + timeoutMilliseconds + " ==");
                service = new ServiceController(serviceName);

                progressBarRodape.Value = progressBarRodape.Value + 2;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                

                //int millisec1 = Environment.TickCount;
                //listBoxPrincipal.Items.Add("== millisec1 >> " + millisec1 + " ==");
                //listBoxPrincipal.Items.Add("== timeout >> " + timeout + " ==");
                progressBarRodape.Value = progressBarRodape.Value + 2;

                //                service.MachineName = _varMachineName;

                //listBoxPrincipal.Items.Add("== " + Nomedoservicodowindows + " seu estado é >> ");
                listBoxPrincipal.Items.Add("== Seu estatus agora é: >> " + service.Status.ToString() + " ==");
                progressBarRodape.Value = progressBarRodape.Value + 2;
                try
                {

                    //service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    listBoxPrincipal.Items.Add(" >> Executando: " + service.Status.ToString() + " em " + timeout + " ==");

                    //service.Status = Stopped
                    //service.Status = Running
                    
                    
                    _sVerificacao = service.Status.ToString();


                    //bool sverificastatuscanpause = Convert.ToBoolean(service.CanPauseAndContinue.ToString());
                    //string sverificastatuscan = service.CanStop.ToString();
                    //string sverificastatustatus = service.Status.ToString();


                    //listBoxPrincipal.Items.Add("Status = " + service.Status);
                    //listBoxPrincipal.Items.Add("Can Pause and Continue = " + service.CanPauseAndContinue);
                    //listBoxPrincipal.Items.Add("Can ShutDown = " + service.CanShutdown);
                    //listBoxPrincipal.Items.Add("Can Stop = " + service.CanStop);

                    //listBoxPrincipal.Items.Add("ServiceControllerStatus = " + ServiceControllerStatus.Stopped);
                    progressBarRodape.Value = progressBarRodape.Value + 2;

                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                        service.Start();
                        while (service.Status == ServiceControllerStatus.Stopped)
                        {
                            progressBarRodape.Value = progressBarRodape.Value + 2;
                            Thread.Sleep(1000);
                            service.Refresh();
                            if (progressBarRodape.Value <= 90) progressBarRodape.Value = 0;
                        }
                        listBoxPrincipal.Items.Add("== ServiceControllerStatus Start é >> " + service.Status.ToString() + " ==");

                        
                        while (service.Status == ServiceControllerStatus.StartPending)
                        {

                            progressBarRodape.Value = progressBarRodape.Value + 2;
                            Thread.Sleep(1000);
                            service.Refresh();
                            if (progressBarRodape.Value <= 90) progressBarRodape.Value = 0;
                        }
                        listBoxPrincipal.Items.Add("== ServiceControllerStatus StartPending é >> " + service.Status.ToString() + " ==");
                    }
                    
                    //if(!sverificastatuscanpause) service.Start();

                    //if (sverificastatuscanpause) service.Continue();
                    //sverificacao = service.Status.ToString();

                    //if (sverificacao == "Running") service.WaitForStatus(ServiceControllerStatus.Running, timeout);

                    //sverificacao = service.Status.ToString();
                    //if (sverificacao == "Running") service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                    //if (sverificacao == "Running") listBoxPrincipal.Items.Add(" >> 1 - ServiceControllerStatus.Running: " + service.Status.ToString() + " em " + timeout + " ==");
                    
                    //if (sverificacao == "Stopped") service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    //if (sverificacao == "Stopped") listBoxPrincipal.Items.Add(" >> 1 - ServiceControllerStatus.Stopped: " + service.Status.ToString() + " em " + timeout + " ==");
                    
                    //if (sverificacao == "Stopped") service.Start();
                    //sverificacao = service.Status.ToString();

                    //if (sverificacao == "Running") service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                    //if (sverificacao == "Running") listBoxPrincipal.Items.Add(" >> 2 - ServiceControllerStatus.Running: " + service.Status.ToString() + " em " + timeout + " ==");
                    //if (sverificacao == "Stopped") service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    //sverificacao = service.Status.ToString();
                    //if (sverificacao == "Stopped") listBoxPrincipal.Items.Add(" >> 2 - ServiceControllerStatus.Stopped: " + service.Status.ToString() + " em " + timeout + " ==");


                    listBoxPrincipal.Items.Add("== Após a execusão, start do serviço esta: " + service.Status.ToString() + " ==");
                    //sverificacao = service.Status.ToString();


                    //progressBarRodape.Value = progressBarRodape.Value + 2;
                    //listBoxPrincipal.Items.Add("== service.Start Depois >> " + service.Status.ToString() + " ==");
                    progressBarRodape.Value = progressBarRodape.Value + 2;

                    //statusrodandooservico = service.Status.ToString();
                    //listBoxPrincipal.Items.Add("== " + Nomedoservicodowindows + " Verificando seu estado apos o start >> " + service.Status.ToString() + " em " + timeout + " ==");
                    //MessageBox.Show("== " + Nomedoservicodowindows + " Verificando seu estado apos o start >> " + service.Status.ToString() + " em " + timeout + " ==");


                    //service.Status = Stopped
                    //service.Status = Running
                    //if (sverificacao == "Running")
                    //{
                    //    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                    //    listBoxPrincipal.Items.Add("== Verificando != Stopped >> " + service.Status.ToString() + " ==");
                    //}

                    //if (sverificacao == "Stopped")
                    //{
                    //    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    //    listBoxPrincipal.Items.Add("== ServiceControllerStatus Stopped é >> " + service.Status.ToString() + " ==");
                    //    service.Start();
                    //    sverificacao = service.Status.ToString();
                    //    listBoxPrincipal.Items.Add("== Verificando == Stopped >> " + service.Status.ToString() + " ==");
                    //    if (sverificacao == "Running")
                    //    {
                    //        service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                    //        listBoxPrincipal.Items.Add("== Verificando != Stopped >> " + service.Status.ToString() + " ==");
                    //    }
                    //}

                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    //MessageBox.Show("verifique se startou o serviço agora");
                    //listBoxPrincipal.Items.Add("== Status do serviço ao iniciar >> " + service.Status.ToString() + " ==");
                    //progressBarRodape.Value = progressBarRodape.Value + 2;
                }
                catch (Exception ex)
                {
                    string nomemessagem = "Erro ao iniciar o serviço! >> ";

                    // if(ex.InnerException.Message != null) nomemessagem +=  ex.InnerException.Message + " >> ";
                    if (ex.Message != null) nomemessagem += ex.Message;

                    listBoxPrincipal.Items.Add(nomemessagem);

                    //listBoxPrincipal.Items.Add(ex.InnerException.Message  + ex.Message);
                    MessageBox.Show(Resources.FormPrincipal_StopService_ErrorEncontrado + " \n " + ex.Message);
                    Application.Restart();

                }
            }
        }

        public void StopService(string serviceName, int timeoutMilliseconds)
        {
            listBoxPrincipal.Items.Add("== Executando o desligamento do serviço no windows! >> " + serviceName + " em T:" + timeoutMilliseconds + " ==");

            service = new ServiceController(serviceName);

            
            progressBarRodape.Value = progressBarRodape.Value + 2;
            listBoxPrincipal.Items.Add("== " + _nomedoservicodowindows + " O serviço neste momento! >> " + service.Status.ToString() + " ==");
            progressBarRodape.Value = progressBarRodape.Value + 2;

            _sVerificacao = service.Status.ToString();

            //service.Status = Stopped
            //service.Status = Running
            if (_sVerificacao != "Stopped")
            {
                try
                {
                    //int millisec1 = Environment.TickCount;
                    //listBoxPrincipal.Items.Add("== millisec1 >> " + millisec1 + " ==");
                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    //listBoxPrincipal.Items.Add("== timeout >> " + timeout + " ==");

                    service.MachineName = _varNomedaMaquina;
                    progressBarRodape.Value = progressBarRodape.Value + 2;

                    //listBoxPrincipal.Items.Add("== " + Nomedoservicodowindows + " seu estado é >> " + service.Status.ToString() + " ==");

                    //listBoxPrincipal.Items.Add("== service.Stop Antes >> " + service.Status.ToString() + " ==");
                    progressBarRodape.Value = progressBarRodape.Value + 2;



                    if (service.Status != ServiceControllerStatus.Stopped)
                    {
                        progressBarRodape.Value = progressBarRodape.Value + 2;
                        service.Stop();

                        while (service.Status != ServiceControllerStatus.Stopped)
                        {
                            progressBarRodape.Value = progressBarRodape.Value + 2;
                            Thread.Sleep(1000);
                            service.Refresh();
                            if (progressBarRodape.Value <= 90) progressBarRodape.Value = 0;
                        }
                        listBoxPrincipal.Items.Add("== ServiceControllerStatus Stop é >> " + service.Status.ToString() + " ==");
                        while (service.Status != ServiceControllerStatus.StopPending)
                        {
                            progressBarRodape.Value = progressBarRodape.Value + 2;
                            Thread.Sleep(1000);
                            service.Refresh();
                            if (progressBarRodape.Value <= 90) progressBarRodape.Value = 0;

                        }
                        listBoxPrincipal.Items.Add("== ServiceControllerStatus StopPending é >> " + service.Status.ToString() + " ==");
                        
                    }
                    
                    //service.Stop();
                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    //listBoxPrincipal.Items.Add("== service.Stop Depois >> " + service.Status.ToString() + " ==");

                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    _statusrodandooservico = service.Status.ToString();

                    listBoxPrincipal.Items.Add("== WaitForStatus now! >> " + service.Status.ToString() + " ==");

                    //listBoxPrincipal.Items.Add("== service.Stop >> " + service.Status.ToString() + " ==");
                    progressBarRodape.Value = progressBarRodape.Value + 2;
                    //MessageBox.Show("verifique se parou o serviço agora");
                    progressBarRodape.Value = progressBarRodape.Value + 2;

                }
                catch (Exception ex)
                {
                    //string texto = "Paulo Viana";
                    //Label1.Text = texto;
                    //Label1.ForeColor = System.Drawing.Color.Red;

                    string nomemessagem = "Erro Encontrado ao parar o serviço. >> " ;
                    listBoxPrincipal.Items.Add(nomemessagem);
                    listBoxPrincipal.Items.Add(ex.InnerException.Message + " >> " + ex.Message);
                    MessageBox.Show(Resources.FormPrincipal_StopService_ErrorEncontrado + ex.InnerException.Message + ex.Message);
                    Application.Restart();

                }

            }
        }

        public void Ligandoexecutavel()
        {
            listBoxPrincipal.Items.Add("== Ligando >> " + _nomeLocalextensao + " ==");

//            listBoxPrincipal.Items.Add("Ligando serviço >> " + nomeLocalextensao);
            if (_nomeLocalextensao != string.Empty)
            {
                listBoxPrincipal.Items.Add("Entrando para Ligar o  >> " + _nomeLocalextensao);
                //listBoxPrincipal.Items.Add("Status do serviço do windows! >> " + statusrodandooservico);


                //service.Status = Stopped
                //service.Status = Running
                if (_sVerificacao == "Running")
                {
                    try
                    {
                        if (File.Exists(_nomeLocalextensao))
                        {
                            ProcessStartInfo startInfo = new ProcessStartInfo(_nomeLocalextensao);

                            startInfo.WorkingDirectory = _nomeDiretorio;
                            listBoxPrincipal.Items.Add("local do arquivo " + startInfo.WorkingDirectory);
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
        }

        public void Desligarexecutavel()
        {
            _nomeLocalextensao = Settings.Default.NomeLocalextensao;
            listBoxPrincipal.Items.Add("== Desligando >> " + _nomeLocalextensao + " ==");
            // pegando o nome do arquivo junto com a extensão;
            //FileInfo fi = new FileInfo(nomeLocalextensao);
            //nomeextensao = fi.Name;

            // removendo caminho e extenção do arquivo.  
            _nomeextensao = Path.GetFileNameWithoutExtension(_nomeLocalextensao);
            _nomeDiretorio = Path.GetDirectoryName(_nomeLocalextensao);

            //MessageBox.Show("pegando arquivo sem extensão ... " + nomeextensao);
            

            //MessageBox.Show("Parando ... " + nomeextensao);
            if (_nomeextensao != string.Empty)
            {

                listBoxPrincipal.Items.Add("== Começar a Desligar o executável >> " + _nomeextensao);
                try
                {
                    //var processes2 = Process.GetProcesses(_nomeextensao);


                    var processes = Process.GetProcessesByName(_nomeextensao);
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

        public void SuppressScriptErrorsOnly(WebBrowser Browser)
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

        public void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ((WebBrowser)sender).Document.Window.Error += new HtmlElementErrorEventHandler(Window_Error);
        }

        private void timerSistema_Tick(object sender, EventArgs e)
        {
            #region Data e hora do sistema atual.
            //try
            //{
            //    if (progressBarRodape.Value < 100)
            //    {
            //        progressBarRodape.Value = progressBarRodape.Value + 2;
            //    }
            //    else
            //    {
            //        timerSistema.Stop();
                   
            //    }
            //}
            //catch (Exception)
            //{
            //    timerSistema.Stop();
                
            //}
            #endregion

        }

        #endregion " metodos executados "

    }
}
