using RestartGetCardServicos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestRestartGetCardServicos
{
    
    
    /// <summary>
    ///This is a test class for FormPrincipalTest and is intended
    ///to contain all FormPrincipalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FormPrincipalTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Desligarexecutavel
        ///</summary>
        [TestMethod()]
        public void DesligarexecutavelTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            target.Desligarexecutavel();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Desligandoservicodowindows
        ///</summary>
        [TestMethod()]
        public void DesligandoservicodowindowsTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            target.Desligandoservicodowindows();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FormPrincipal_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void FormPrincipal_LoadTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.FormPrincipal_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void InitializeComponentTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Ligandoexecutavel
        ///</summary>
        [TestMethod()]
        public void LigandoexecutavelTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            target.Ligandoexecutavel();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Ligandoservicodowindows
        ///</summary>
        [TestMethod()]
        public void LigandoservicodowindowsTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            target.Ligandoservicodowindows();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for RestartartandoServicosExecutaveis
        ///</summary>
        [TestMethod()]
        public void RestartartandoServicosExecutaveisTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            target.RestartartandoServicosExecutaveis();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for StartService
        ///</summary>
        [TestMethod()]
        public void StartServiceTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string serviceName = string.Empty; // TODO: Initialize to an appropriate value
            int timeoutMilliseconds = 0; // TODO: Initialize to an appropriate value
            target.StartService(serviceName, timeoutMilliseconds);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for StopService
        ///</summary>
        [TestMethod()]
        public void StopServiceTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string serviceName = string.Empty; // TODO: Initialize to an appropriate value
            int timeoutMilliseconds = 0; // TODO: Initialize to an appropriate value
            target.StopService(serviceName, timeoutMilliseconds);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SuppressScriptErrorsOnly
        ///</summary>
        [TestMethod()]
        public void SuppressScriptErrorsOnlyTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            WebBrowser Browser = null; // TODO: Initialize to an appropriate value
            target.SuppressScriptErrorsOnly(Browser);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Window_Error
        ///</summary>
        [TestMethod()]
        public void Window_ErrorTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            HtmlElementErrorEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Window_Error(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for buttonCancelar_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void buttonCancelar_ClickTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.buttonCancelar_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for buttonIniciarServiço_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void buttonIniciarServiço_ClickTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.buttonIniciarServiço_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for buttonSair_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void buttonSair_ClickTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.buttonSair_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for labelConfiguracao_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void labelConfiguracao_ClickTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.labelConfiguracao_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for timerSistema_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void timerSistema_TickTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.timerSistema_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ScriptErrorsSuppressed
        ///</summary>
        [TestMethod()]
        public void ScriptErrorsSuppressedTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.ScriptErrorsSuppressed = expected;
            actual = target.ScriptErrorsSuppressed;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _automaticamenteTefDial
        ///</summary>
        [TestMethod()]
        public void _automaticamenteTefDialTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target._automaticamenteTefDial = expected;
            actual = target._automaticamenteTefDial;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _automaticamenteVpn
        ///</summary>
        [TestMethod()]
        public void _automaticamenteVpnTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target._automaticamenteVpn = expected;
            actual = target._automaticamenteVpn;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _iniciarAutomaticamente
        ///</summary>
        [TestMethod()]
        public void _iniciarAutomaticamenteTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target._iniciarAutomaticamente = expected;
            actual = target._iniciarAutomaticamente;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _nomeDiretorio
        ///</summary>
        [TestMethod()]
        public void _nomeDiretorioTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._nomeDiretorio = expected;
            actual = target._nomeDiretorio;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _nomeLocalextensao
        ///</summary>
        [TestMethod()]
        public void _nomeLocalextensaoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._nomeLocalextensao = expected;
            actual = target._nomeLocalextensao;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _nomedoservicodowindows
        ///</summary>
        [TestMethod()]
        public void _nomedoservicodowindowsTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._nomedoservicodowindows = expected;
            actual = target._nomedoservicodowindows;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _nomeextensao
        ///</summary>
        [TestMethod()]
        public void _nomeextensaoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._nomeextensao = expected;
            actual = target._nomeextensao;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _nomeextensaoservico
        ///</summary>
        [TestMethod()]
        public void _nomeextensaoservicoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._nomeextensaoservico = expected;
            actual = target._nomeextensaoservico;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _sVerificacao
        ///</summary>
        [TestMethod()]
        public void _sVerificacaoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._sVerificacao = expected;
            actual = target._sVerificacao;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _statusrodandooservico
        ///</summary>
        [TestMethod()]
        public void _statusrodandooservicoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target._statusrodandooservico = expected;
            actual = target._statusrodandooservico;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for _tempoexecusaoservico
        ///</summary>
        [TestMethod()]
        public void _tempoexecusaoservicoTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target._tempoexecusaoservico = expected;
            actual = target._tempoexecusaoservico;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("RestartGetCardServicos.exe")]
        public void DisposeTest()
        {
            FormPrincipal_Accessor target = new FormPrincipal_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Browser_DocumentCompleted
        ///</summary>
        [TestMethod()]
        public void Browser_DocumentCompletedTest()
        {
            FormPrincipal target = new FormPrincipal(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            WebBrowserDocumentCompletedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Browser_DocumentCompleted(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
