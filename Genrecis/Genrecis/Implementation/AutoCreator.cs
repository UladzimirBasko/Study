// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoCreator.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the AutoCreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis.Implementation
{
    /// <summary>
    /// The AutoCreator
    /// </summary>
    public class AutoCreator : ICreator<Auto>
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>
        /// The <see cref="Auto"/>.
        /// </returns>
        public Auto Create()
        {
            return  new Auto("Auto description", "Minibus");
        }
    }
}
