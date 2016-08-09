using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Domain.Resultado;
using AsgaSistemas.saga.CE.OiLegal.BusinessEntities.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace OiLegal.BusinessEntities.Test
{
    
    
    /// <summary>
    ///This is a test class for ChamadaMovelTest and is intended
    ///to contain all ChamadaMovelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ChamadaMovelTest
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
        ///A test for ValidarEotMovel
        ///</summary>
        [TestMethod()]
        public void ValidarEotMovelTest()
        {

            ChamadaMovel target = new ChamadaMovel
            {
                Sentido = TipoSentido.Efetuada,
                EOTB = null
            };
            var actual = target.ValidarEotMovel();
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void ValidarEotMovelTestEOTB371()
        {

            ChamadaMovel target = new ChamadaMovel
            {
                Sentido = TipoSentido.Efetuada,
                EOTB = "371"
            };
            var actual = target.ValidarEotMovel();
            Assert.IsTrue(actual);
        }
    }
}
