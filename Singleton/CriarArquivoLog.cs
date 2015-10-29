using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace Singleton
{
    class CriarArquivoLog
    {

        // implementação de arquivo de log com interface...
        public string path = @"C:\temp\teste_Inplementacao.log"; // local onde vai gravar o log,
        private FileStream arquivo;  // arquivo que vai ser criando pele filestream
        private static CriarArquivoLog log;  // aqui esta instanciando a o log.
        //public object retorno { get; set; }
        public static object retorno { get; set; }

        internal static object criarArquivoLogsnovo(string strlogEnviar)
        {
            retorno = null;

            if (log == null)
            {
                // aqui chama a o arquivo de execução que é na verdade a classe
                log = new CriarArquivoLog();  // vai para -> private ImplementationClass();
                retorno += "\n Não Existe e Criou o Arquivo: ";
                return retorno;
            }
            else
            {
                retorno += "Existe o Arquivo: ";
                return retorno;
            }
            retorno += "\n Aconceteu algum erro ";
            // Method implementation.
            return retorno;
        }


        private CriarArquivoLog()
        {  // construtor.  privado.
            try
            {
                MessageBox.Show("criando arquivo: " + path);
                this.arquivo = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write);

                arquivo.Close();
            }
            catch (Exception error)
            {
                retorno += "\n " + error.Message;
                //return retorno;
            }
        }


    }
}
