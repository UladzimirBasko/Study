// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Activity.cs" company="VOVANCHO-PC">
//   Infrastructure
// </copyright>
// <summary>
//   Defines the Activity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using System.Collections.Generic;

    /// <summary>
    /// The Activity
    /// </summary>
    public class Activity
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
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the described activities.
        /// </summary>
        /// <value>
        /// </value>
        public AvailableActivity DescribedActivities { get; set; }
    }
}
