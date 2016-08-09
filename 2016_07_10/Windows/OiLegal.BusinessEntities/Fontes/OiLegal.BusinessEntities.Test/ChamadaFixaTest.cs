using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;
namespace OiLegal.BusinessEntities.Test
{
    
    
    /// <summary>
    ///This is a test class for ChamadaFixaTest and is intended
    ///to contain all ChamadaFixaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChamadaFixaTest
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
        ///A test for ValidarEotFixa
        ///</summary>
        [TestMethod()]
        public void ValidarEotFixaTest()
        {
            ChamadaFixa target = new ChamadaFixa
                                     {
                                         Sentido = TipoSentido.Recebida,
                                         Ama550_Eot_Assinante_A = null
                                     }; 
            bool actual;
            actual = target.ValidarEotFixa();
            Assert.IsTrue(actual);
        }
    }
}
