/* TexasTea.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class describing the TexasTea Drink
    /// </summary>
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                        if (Sweet) { return 10; } else { return 5; }
                    case Size.Medium:
                        if (Sweet) { return 22; } else { return 11; }
                    case Size.Large:
                        if (Sweet) { return 36; } else { return 18; }
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Backing variable for Sweet
        /// </summary>
        private bool _sweet = true;

        /// <summary>
        // Whether to serve sweet
        /// </summary>
        public bool Sweet { get => _sweet; set { _sweet = value; InvokePropertyChanged("Sweet"); } }

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
                    if (Sweet) { return "Small Texas Sweet Tea"; }
                    else { return "Small Texas Plain Tea"; }
                case Size.Medium:
                    if (Sweet) { return "Medium Texas Sweet Tea"; }
                    else { return "Medium Texas Plain Tea"; }
                case Size.Large:
                    if (Sweet) { return "Large Texas Sweet Tea"; }
                    else { return "Large Texas Plain Tea"; }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
