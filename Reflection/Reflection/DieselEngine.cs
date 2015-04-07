// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DieselEngine.cs" company="VOVANCHO-PC">
//   Reflection
// </copyright>
// <summary>
//   The DieselEngine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection
{
    /// <summary>
    /// The DieselEngine
    /// </summary>
    [AlternativeName(Value = "DE")]
    public class DieselEngine : CumbustionEngine
    {
        /// <summary>
        /// Gets or sets the number of cylinders.
        /// </summary>
        /// <value>
        /// The number of cylinders.
        /// </value>
        public int NumberOfCylinders { get; set; }
    }
}
