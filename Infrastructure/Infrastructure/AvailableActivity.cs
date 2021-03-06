﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AvailableActivity.cs" company="VOVANCHO-PC">
//   Infrastructure
// </copyright>
// <summary>
//   Defines the AvailableActivity type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using System.Collections.Generic;

    /// <summary>
    /// The AvailableActivity
    /// </summary>
    public class AvailableActivity
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the described activities.
        /// </summary>
        /// <value>
        /// The described activities.
        /// </value>
        public Activity DescriptionActivity { get; set; }

        /// <summary>
        /// Gets or sets the organizer.
        /// </summary>
        /// <value>
        /// The organizer.
        /// </value>
        public Organization Organizer { get; set; }

        /// <summary>
        /// Gets or sets the connected waybill.
        /// </summary>
        /// <value>
        /// The connected waybill.
        /// </value>
        public Waybill ConnectedWaybill { get; set; }

        /// <summary>
        /// Gets or sets the available venues.
        /// </summary>
        /// <value>
        /// The available venues.
        /// </value>
        public List<Venue> AvailableVenues { get; set; }
    }
}
