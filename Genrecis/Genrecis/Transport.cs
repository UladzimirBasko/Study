// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Transport.cs" company="VOVANCHO-PC">
//   Genrecis
// </copyright>
// <summary>
//   Defines the Transport type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Genrecis
{
    /// <summary>
    /// The Transport
    /// </summary>
   public class Transport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transport"/> class.
        /// </summary>
        /// <param name="description">The description.</param>
       public Transport(string description)
       {
           this.Description = description;
       }

       /// <summary>
       /// Gets or sets the description.
       /// </summary>
       /// <value>
       /// The description.
       /// </value>
       public string Description { get; set; }
    }
}
