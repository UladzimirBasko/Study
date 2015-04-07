// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoDescriptor.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the AutoDescriptor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis.Implementation
{
    /// <summary>
    /// The AutoDescriptor
    /// </summary>
    public class AutoDescriptor : IDescriptor<Auto>
    {
        /// <summary>
        /// Abouts the specified auto.
        /// </summary>
        /// <param name="auto">The auto.</param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string About(Auto auto)
        {
            return auto.Description + ":" + auto.Type;
        }
    }
}
