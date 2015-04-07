// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GasolineEngine.cs" company="VOVANCHO-PC">
//   Reflection
// </copyright>
// <summary>
//   The GasolineEngine.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection
{
    /// <summary>
    /// The GasolineEngine
    /// </summary>
    [AlternativeName(Value = "GE")]
    public class GasolineEngine : CumbustionEngine, INoise
    {
        /// <summary>
        /// The Noise level
        /// </summary>
        private readonly int noiseLevel;

        /// <summary>
        /// Initializes a new instance of the <see cref="GasolineEngine"/> class.
        /// </summary>
        /// <param name="noiseLevel">The noise level.</param>
        public GasolineEngine(int noiseLevel)
        {
            this.noiseLevel = noiseLevel;
        }

        /// <summary>
        /// Gets or sets the consumption.
        /// </summary>
        /// <value>
        /// The consumption.
        /// </value>
        public int Consumption { get; set; }

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
