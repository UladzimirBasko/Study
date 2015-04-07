// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDescriptor.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the IDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis
{
    /// <summary>
    /// The IDescriptor
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDescriptor<in T> where T : Transport
    {
        /// <summary>
        /// Abouts the specified transport.
        /// </summary>
        /// <param name="transport">The transport.</param>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        string About(T transport);
    }
}
