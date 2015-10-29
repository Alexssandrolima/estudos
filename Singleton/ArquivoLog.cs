using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Singleton
{
    class ArquivoLog    {
        private FileStream arquivo;  // em java FileWriter
        private static ArquivoLog log;

        string path = @"C:\temp\teste_singleton.log"; // local onde vai gravar o log,

        private ArquivoLog() 
        {  // construtor.  privado.
            try
            {
                MessageBox.Show("criando arquivo: " + path);
                this.arquivo = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write);
                
                arquivo.Close();            
            }
            catch (Exception error)            
            {
                MessageBox.Show("error em: " +error );            
            }
        }
        
        
        internal static ArquivoLog getInstance() {         // retornar uma nova instancia ou uma ja existente.
            if(log == null)
            {
                MessageBox.Show("Chamando o log que nao existe e criando arquivo! ");            
                log = new ArquivoLog();
            }
            MessageBox.Show("Retornando o log do arquivo criado! ");
            return log;
        }





        internal static void getInstance(object alexssandrolima)
        {
            throw new NotImplementedException();
        }
    }
}
