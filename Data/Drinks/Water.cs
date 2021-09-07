/* Water.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class describing the Water Drink
    /// </summary>
    public class Water : Drink
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
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
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
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Backing variable for Lemon
        /// </summary>
        private bool _lemon = false;

        /// <summary>
        // Whether to serve with lemon
        /// </summary>
        public bool Lemon { get => _lemon; set { _lemon = value; InvokePropertyChanged("Lemon"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Special instructions for the preparation of this Drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

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
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
