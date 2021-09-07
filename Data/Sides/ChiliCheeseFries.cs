/* ChiliCheeseFries.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The price of this side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calorie content of this side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the side
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                // None

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
                    return "Small Chili Cheese Fries";
                case Size.Medium:
                    return "Medium Chili Cheese Fries";
                case Size.Large:
                    return "Large Chili Cheese Fries";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}