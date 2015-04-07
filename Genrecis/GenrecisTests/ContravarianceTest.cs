// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContravarianceTest.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the ContravarianceTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenrecisTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Genrecis;
    using Genrecis.Implementation;

    /// <summary>
    /// The ContravarianceTest
    /// </summary>
    [TestClass]
    public class ContravarianceTest
    {
        /// <summary>
        /// Contravariances the test method.
        /// </summary>
        [TestMethod]
        public void ContravarianceTestMethod()
        {
            IDescriptor<Transport> transportDescriptor = new TransportDescriptor();
            IDescriptor<Auto> autoDescriptor = new AutoDescriptor();
            autoDescriptor = transportDescriptor;
        }
    }
}
