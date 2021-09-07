﻿/* PecosPulledPork.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Backing variable for Bread
        /// </summary>
        private bool _bread = true;

        /// <summary>
        // If the entree has bread
        /// </summary>
        public bool Bread { get => _bread; set { _bread = value; InvokePropertyChanged("Bread"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Pickle
        /// </summary>
        private bool _pickle = true;

        /// <summary>
        // If the entree has pickle
        /// </summary>
        public bool Pickle { get => _pickle; set { _pickle = value; InvokePropertyChanged("Pickle"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}

