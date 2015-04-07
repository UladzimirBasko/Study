// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CovarianceTest.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the CovarianceTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenrecisTests 
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Genrecis;
    using Genrecis.Implementation;

    /// <summary>
    /// The CovarianceTest
    /// </summary>
    [TestClass]
    public class CovarianceTest
    {
        /// <summary>
        /// Covariances the test method.
        /// </summary>
        [TestMethod]
        public void CovarianceTestMethod()
        {
           ICreator<Transport> transportCreator = new TransportCreator();
           ICreator<Auto> autoCreator = new AutoCreator();
            transportCreator = autoCreator;
        }
    }
}
