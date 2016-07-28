using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//usando e administrando arquivos.
using System.IO;
// retirar retundancia da classe
using RestartGetCardServicos.Properties;

namespace RestartGetCardServicos
{
    public partial class FormConfigurar : Form
    {
        public FormConfigurar()
        {
            InitializeComponent();
        }

        public string Filefilter = "tef_dial.exe|*.exe";
        public string FileTitle = "Pegando o arquivo executavel do tefdial.exe";
        public string FileService = "OpenVPNService.exe";
        
        private OpenFileDialog _openFile;

        private void buttonProcurarArquivo_Click(object sender, EventArgs e)
        {
            _openFile = new OpenFileDialog            {
                InitialDirectory = "C:\\TEF_DIAL\\",
                Filter = Filefilter,
                Title = FileTitle,
                FileName = @"tef_dial.exe"
            };
            _openFile.ShowDialog();

            if (_openFile.FileName != null)
            {
                textBoxNomeLocalextensao.Text = _openFile.FileName; // aqui você pega o local + nome do arquivo completo.
                textBoxNomedoServicoWindows.Text = FileService;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            Settings.Default.NomeLocalextensao = textBoxNomeLocalextensao.Text;
            Settings.Default.NomedoServicoWindows = textBoxNomedoServicoWindows.Text;
            Settings.Default.Save();

            Close();
        }

        private void FormConfigurar_Load(object sender, EventArgs e)
        {
            textBoxNomeLocalextensao.Text = Settings.Default.NomeLocalextensao;
            textBoxNomedoServicoWindows.Text = Settings.Default.NomedoServicoWindows;
        }

 
    }
}
