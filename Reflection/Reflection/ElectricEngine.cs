// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElectricEngine.cs" company="VOVANCHO-PC">
//   Reflection
// </copyright>
// <summary>
//   The ElectricEngine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection
{
    /// <summary>
    /// The ElectricEngine
    /// </summary>
    [AlternativeName(Value = "EE")]
    public class ElectricEngine : INoise
    {
        /// <summary>
        /// The Noise level.
        /// </summary>
       private readonly int noiseLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEngine"/> class.
        /// </summary>
        /// <param name="noiseLevel">The noise level.</param>
        public ElectricEngine(int noiseLevel)
        {
            this.noiseLevel = noiseLevel;
        }

        /// <summary>
        /// Gets or sets the power.
        /// </summary>
        /// <value>
        /// The power.
        /// </value>
        public int Power { get; set; }

        /// <summary>
        /// Noises the level.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetNoiseLevel()
        {
            return this.noiseLevel;
        }
    }
}
