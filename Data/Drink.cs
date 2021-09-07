/* Drink.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Abstract Drink base class
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing variable for Size
        /// </summary>
        private Size _size = Size.Small;
        /// <summary>
        /// The drink's size (enum)
        /// </summary>
        public Size Size { get => _size; set { _size = value; InvokePropertyChanged("Size"); InvokePropertyChanged("Price"); InvokePropertyChanged("Calories"); } }

        /// <summary>
        /// The drink's price
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The drink's calorie content
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Backing variable for Ice
        /// </summary>
        private bool _ice = false;
        /// <summary>
        /// Whether the drink will contain ice
        /// </summary>
        public bool Ice { get => _ice; set { _ice = value; InvokePropertyChanged("Ice"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// A list of the drink's special instructions
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
