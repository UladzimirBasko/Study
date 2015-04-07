// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Order.cs" company="VOVANCHO-PC">
//   Infrastructure
// </copyright>
// <summary>
//   Defines the Order type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Infrastructure
{
    /// <summary>
    /// The Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the ordered waybill.
        /// </summary>
        /// <value>
        /// The ordered waybill.
        /// </value>
        public Waybill OrderedWaybill { get; set; }

        /// <summary>
        /// Gets or sets the ordered client.
        /// </summary>
        /// <value>
        /// The ordered client.
        /// </value>
        public Client OrderedClient { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}
