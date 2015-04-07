// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Organization.cs" company="VOVANCHO-PC">
//   Infrastructure
// </copyright>
// <summary>
//   Defines the Organization type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Organization
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the carried out activities.
        /// </summary>
        /// <value>
        /// The carried out activities.
        /// </value>
        public List<AvailableActivities> CarriedOutActivities { get; set; }
    }
}
