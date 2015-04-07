// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TransportDescriptor.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the TransportDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis.Implementation
{
    /// <summary>
    /// The TransportDescriptor
    /// </summary>
    public class TransportDescriptor : IDescriptor<Transport>
    {
        /// <summary>
        /// Abouts the specified transport.
        /// </summary>
        /// <param name="transport">The transport.</param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string About(Transport transport)
        {
            return transport.Description;
        }
    }
}
