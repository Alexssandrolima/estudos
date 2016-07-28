using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestConstrutorSQL
{
    [TestClass]
    public class GetSqlTestes
    {
        [TestMethod]
        public void DeveMontarComandoDeleteComClassePessoa()
        {
            // arrange
            var jetSql = new JetSql();
            var instancia = new Pessoa();

            //action
            var sql = jetSql.MontarDelete(instancia);

            //assert
            Assert.AreEqual("DELETE FROM Pessoa",sql);

        }
        [TestMethod]
        public void DeveMontarComandoDeleteComClasseSeriado()
        {
            // arrange
            var jetSql = new JetSql();
            var instancia = new Seriado();

            //action
            var sql = jetSql.MontarDelete(instancia);

            //assert
            Assert.AreEqual("DELETE FROM Seriado", sql);

        }
        
        [TestMethod]
        public void DeveMontarComandoSelectComClassePessoa()
        {
            // arrange
            var jetSql = new JetSql();
            var instancia = new Pessoa{ Twitter = "@alexssandrolima"};

            //action
            var sql = jetSql.MontarSelect(instancia);

            //assert
            Assert.AreEqual("SELECT Twitter FROM Pessoa", sql);

        }

        [TestMethod]
        public void DeveMontarComandoSelectComClasseSeriado()
        {
            // arrange
            var jetSql = new JetSql();
            var instancia = new Seriado { Nome = "Doutor Hwo" };

            //action
            var sql = jetSql.MontarSelect(instancia);

            //assert
            Assert.AreEqual("SELECT Nome FROM Seriado", sql);

        }
    }
}
