using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        //intanciado uma interface
        ISampleInterface obj = new ImplementationClass();
        // criando objetos no projeto.
        public object callintefacechamando { get; set; }
        public object callintefacechamando2 { get; set; }
        public object alexssandrolima { get; set; }
        public object alex2 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ArquivoLog arq  = new ArquivoLog.getInstance();
            // ArquivoLog arq2 = new ArquivoLog.getInstance();
            MessageBox.Show("vai instanciar o arquivolog.getinstance");

            //ArquivoLog.getInstance();

            //MessageBox.Show("ja instanciou o arquivolog.getinstance");
            //MessageBox.Show("vai novamente.");

            string[] strenviararquivo = {"teste1"};
            string[] strenviararquivo2 = {"teste2"};

            alexssandrolima = ArquivoLog.getInstance();
            alex2 = ArquivoLog.getInstance();
            MessageBox.Show("vou mostra o alexssandrolima -> " + alexssandrolima
                       + "\n Vou mostra o alex2           -> " + alex2
                 );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Declare an interface instance.

            // Call the member.
            obj.SampleMethod();

            string testoaenviar =  "Primeiro testo a enviar";
            string testoaenviar2 = "Segundo  testo a enviar";

            callintefacechamando = obj.SampleMethod(testoaenviar);
            callintefacechamando2 = obj.SampleMethod(testoaenviar2);

            MessageBox.Show("recebendo a chamada do samplemethod 1: " + callintefacechamando
            + "\n recebendo a chamada do samplemethod 2: " + callintefacechamando2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strlogEnviar = "Error: \n Ocorreu um Erro Ao Executar um Arquivo \n";
            callintefacechamando = obj.criarArquivoLogs(strlogEnviar);

            MessageBox.Show("Recebido da Interface: \n" + callintefacechamando
                );
        }
    }
}
