/* Side.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing variable for Size
        /// </summary>
        private Size _size = Size.Small;
        /// <summary>
        /// The drink's size (enum)
        /// </summary>
        public Size Size { get => _size; set { _size = value; InvokePropertyChanged("Size"); InvokePropertyChanged("Calories"); InvokePropertyChanged("Price"); } }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the preparation of the side
        /// </summary>
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
