using System;
using System.Web.UI.WebControls;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Pesquisa;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums.Pesquisa.NonoDigito;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace OiLegal.BusinessEntities.Test
{
    
    
    /// <summary>
    ///This is a test class for ParametroTerminaisTest and is intended
    ///to contain all ParametroTerminaisTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ParametroTerminaisTest
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
        ///A test for RecuperarTerminais
        ///</summary>
        [TestMethod()]
        public void RecuperarTerminaisTest()
        {
            string protocolo = "0000014/10";

            string terminal = "1186419240";
            DateTime dataInicialCompleta = new DateTime(2012,04,01);
            DateTime dataFinalCompleta = new DateTime(2012,04,30);
            string fusoHorario = "-03:00";
            int tipoDaBusca = 31;
            string tipoDeNumero = "Terminal";
            EnumFlagExistenciaNonoDigito flag = EnumFlagExistenciaNonoDigito.Misto;

            var item = new ListItem(terminal,
                         string.Format("{0};{1};{2};{3};{4};{5};{6}", terminal, dataInicialCompleta,
                                       dataFinalCompleta, fusoHorario, tipoDaBusca, tipoDeNumero,
                                       (int) flag));

            var listBox = new ListBox();
            listBox.Items.Add(item);

            
            Pesquisa pesquisa = new Pesquisa();
            IList<Parametro> expected = null; 
            IList<Parametro> actual = ParametroTerminais.RecuperarTerminais(listBox.Items, protocolo, pesquisa);
            Assert.AreEqual(expected, actual);
        }
    }
}
