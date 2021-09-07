/* BakedBeans.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Baked Beans side
    /// </summary>
    public class BakedBeans : Side
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
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
                    return "Small Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Large:
                    return "Large Baked Beans";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}