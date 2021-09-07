/* Entree.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Entree class
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Entree Price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Entree Calorie Count
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Entree special instructions
        /// </summary>
        /// <returns></returns>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method to trigger PropertyChanged events
        /// </summary>
        /// <param name="propertyName"></param>
        protected void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
