// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AlternativeName.cs" company="VOVANCHO-PC">
//   Reflection
// </copyright>
// <summary>
//   The AlternativeName.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Reflection
{
    using System;

    /// <summary>
    /// The attribute for AlternativeName.
    /// </summary>
    public class AlternativeName : Attribute
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public string Value { get; set; }
    }
}
