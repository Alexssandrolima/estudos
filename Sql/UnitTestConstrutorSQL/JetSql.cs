using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestConstrutorSQL
{
    class JetSql
    {
        //um metodo deve ser especialista deve ter uma unica responsabilidade.
        internal object MontarDelete(object instancia)
        {
            return "DELETE FROM " + ObterNomeClasse(instancia); //abstração.
        }

        private static string ObterNomeClasse(object instancia)
        {
            return instancia.GetType().Name;
        }

        internal object MontarSelect(object instancia)
        {
            return "SELECT "+ instancia.GetType().GetProperties()[0].Name+" FROM " + ObterNomeClasse(instancia); //abstração.;
        }
    }
}
