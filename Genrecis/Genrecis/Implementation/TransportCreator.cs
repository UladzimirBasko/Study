// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TransportCreator.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the TransportCreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis.Implementation
{
    /// <summary>
    /// The Transport Creator
    /// </summary>
    public class TransportCreator : ICreator<Transport>
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>
        ///   <see cref="Transport"/>
        /// </returns>
        public Transport Create()
        {
            return new Transport("Transport Description");
        }
    }
}
