/* JerkedSoda.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class describing the JerkedSoda Drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of this Drink
        /// </summary>
        public override double Price {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie content of this Drink
        /// </summary>
        public override uint Calories { 
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Backing variable for Flavor
        /// </summary>
        private SodaFlavor _flavor;

        /// <summary>
        /// The SodaFlavor (enum) of this Drink
        /// </summary>
        public SodaFlavor Flavor { get => _flavor; set { _flavor = value; InvokePropertyChanged("Flavor"); } }

        /// <summary>
        /// Special instructions for the preparation of this Drink
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            switch (Size)
            {
                case Size.Small:
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
                default:
                    throw new NotImplementedException();
            }

            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    sb.Append("Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append("Orange Soda ");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append("Sarsparilla ");
                    break;
                case SodaFlavor.BirchBeer:
                    sb.Append("Birch Beer ");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append("Root Beer ");
                    break;
                default:
                    throw new NotImplementedException();
            }

            return sb.ToString() + "Jerked Soda";
        }
    }
}
