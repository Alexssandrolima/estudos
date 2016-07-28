using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections;
//using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;



using LendoGravandoArquivoIni.Properties;

namespace LendoGravandoArquivoIni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static readonly string VarSourcePath = Environment.CurrentDirectory + @"\";

        static readonly string StrLocalArquivoRetorno = Settings.Default.StrArquivoIni;

        readonly string _arquivocompleto = VarSourcePath + StrLocalArquivoRetorno;



        private void Form1_Load(object sender, EventArgs e)
        {


            Process d = new Process();
            d.StartInfo = new ProcessStartInfo("cmd.exe", "/c net use");
            d.StartInfo.UseShellExecute = false;
            d.StartInfo.RedirectStandardOutput = true;
            d.Start();



            Value = d.StandardOutput.ReadToEnd();

            foreach (var drv in Value)
            {
                listBoxArquivoIni.Items.Add(drv);
            }

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("cmd.exe", "/c net view");
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            //textBox1.Text = p.StandardOutput.ReadToEnd().ToString();
            listBoxArquivoIni.Items.Add(p.StandardOutput.ReadToEnd());
            comboBoxIp.Items.Add(p.StandardOutput.ReadToEnd());

            //Value = p.StandardOutput.ReadToEnd().ToString(CultureInfo.InvariantCulture);

            //ArrayList arr = new ArrayList();
            //arr.Add(p.StandardOutput.ReadToEnd());
            //comboBoxIp.DataSource = arr;
            //comboBoxIp.DisplayMember = "SERVIDOR";
            //comboBoxIp.ValueMember = "valor";
            //p.WaitForExit();




            //MessageBox.Show(@"local e arquivo " + _arquivocompleto );

            
            MetodoLerArquivoIni();


            //string[] value = INIFile.ReadValue("DRIVER", "DIRETORIO_DANFE", _arquivocompleto);
        }

        public string Value { get; set; }


        private void buttonGravar_Click(object sender, EventArgs e)
        {
            string novovalorDanfe = textBoxDanfe.Text;
            string novovalorIp = textBoxLetoIP.Text;
            MetodoGravarArquivoIni(novovalorDanfe,novovalorIp);
            MetodoLerArquivoIni();
        }

        private void MetodoLerArquivoIni()
        {
            textBoxDanfe.Text = INIFile.ReadValue("DRIVER", "DIRETORIO_DANFE", _arquivocompleto);
            textBoxLetoIP.Text = INIFile.ReadValue("LETO", "LETO_IP", _arquivocompleto);
            listBoxArquivoIni.Items.Add(INIFile.ReadValue("DRIVER", "DIRETORIO_DANFE", _arquivocompleto));
            listBoxArquivoIni.Items.Add(INIFile.ReadValue("LETODB", "LETO_IP", _arquivocompleto));
        
        }

        private void MetodoGravarArquivoIni(string novovalorDanfe, string novovalorIp)
        {
            INIFile.WriteValue("DRIVER", "DIRETORIO_DANFE", novovalorDanfe, _arquivocompleto);
            INIFile.WriteValue("LETO", "LETO_IP", novovalorIp, _arquivocompleto);
        }
    }
}
