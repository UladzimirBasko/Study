// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Waybill.cs" company="VOVANCHO-PC">
//   Infrastructure
// </copyright>
// <summary>
//   Defines the Waybill type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    using System.Collections.Generic;

    /// <summary>
    /// The Waybill
    /// </summary>
    public class Waybill
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public double Cost { get; set; }

        /// <summary>
        /// Gets or sets the booked activities.
        /// </summary>
        /// <value>
        /// The booked activities.
        /// </value>
        public List<AvailableActivities> BookedActivities { get; set; }

        /// <summary>
        /// Gets or sets the maintainability order.
        /// </summary>
        /// <value>
        /// The maintainability order.
        /// </value>
        public Order MaintainabilityOrder { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}
