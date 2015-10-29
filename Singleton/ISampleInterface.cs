using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    interface ISampleInterface
    {
        //aqui esta a classe inferface
        void SampleMethod();
        object SampleMethod(string testoaenviar);
        //aqui estou criando uma metodo da interface
        object criarArquivoLogs(string strlogEnviar);

    }
}
