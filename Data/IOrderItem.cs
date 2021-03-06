/* IOrderItem.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
