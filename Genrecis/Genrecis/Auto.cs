// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Auto.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the Auto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis
{
    /// <summary>
    /// The Auto.
    /// </summary>
    public class Auto:Transport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auto"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
        /// <param name="type">The type.</param>
        public Auto(string description, string type)
            : base(description)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }
    }
}
