// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICreator.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the ICreator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis
{

    /// <summary>
    /// The ICreator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICreator<out T> where T : Transport
    {
        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        T Create();
    }
}
