using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class ImplementationClass : ISampleInterface
    {

        // Explicit interface member implementation: 
        void ISampleInterface.SampleMethod()
        {
            // Method implementation.
        }

        object ISampleInterface.SampleMethod(string testoaenviar)
        {
            // Method implementation.
            testoaenviar += "\n AQUI NA INTERFACE RECEBEU ESTE TESTO";
            return testoaenviar;
        }


        // implementação de arquivo de log com interface...
        public object retorno { get; set; }


        object ISampleInterface.criarArquivoLogs(string strlogEnviar)
        {
            return retorno = CriarArquivoLog.criarArquivoLogsnovo(strlogEnviar);
        }


    }
}
