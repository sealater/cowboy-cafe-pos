/* CowboyCoffee.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class describing the CowboyCoffee Drink
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of this Drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie content of this Drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Backing variable for Ice
        /// </summary>
        private bool _ice = false;

        /// <summary>
        // Whether to add ice
        /// </summary>
        public new bool Ice { get => _ice; set { _ice = value; InvokePropertyChanged("Ice"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Decaf
        /// </summary>
        private bool _decaf = false;

        /// <summary>
        // Whether to serve as decaf
        /// </summary>
        public bool Decaf { get => _decaf; set { _decaf = value; InvokePropertyChanged("Decaf"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for RoomForCream
        /// </summary>
        private bool _roomForCream = false;

        /// <summary>
        // Whether to serve with room for cream
        /// </summary>
        public bool RoomForCream { get => _roomForCream; set { _roomForCream = value; InvokePropertyChanged("RoomForCream"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Special instructions for the preparation of this Drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if (Decaf) { return "Small Decaf Cowboy Coffee"; }
                    else { return "Small Cowboy Coffee";  }
                case Size.Medium:
                    if (Decaf) { return "Medium Decaf Cowboy Coffee"; }
                    else { return "Medium Cowboy Coffee"; }
                case Size.Large:
                    if (Decaf) { return "Large Decaf Cowboy Coffee"; }
                    else { return "Large Cowboy Coffee"; }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
