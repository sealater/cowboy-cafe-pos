/* CowpokeChilli.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {
        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Backing variable for Cheese
        /// </summary>
        private bool _cheese = true;

        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese { get => _cheese; set { _cheese = value; InvokePropertyChanged("Cheese"); InvokePropertyChanged("SpecialInstructions"); } }


        /// <summary>
        /// Backing variable for SourCream
        /// </summary>
        private bool _sourCream = true;

        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream { get => _sourCream; set { _sourCream = value; InvokePropertyChanged("SourCream"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for GreenOnions
        /// </summary>
        private bool _greenOnions = true;

        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions { get => _greenOnions; set { _greenOnions = value; InvokePropertyChanged("GreenOnions"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for TortillaStrips
        /// </summary>
        private bool _tortillaStrips = true;

        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips { get => _tortillaStrips; set { _tortillaStrips = value; InvokePropertyChanged("TortillaStrips"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Cheese) instructions.Add("hold cheese");
                if (!SourCream) instructions.Add("hold sour cream");
                if (!GreenOnions) instructions.Add("hold green onions");
                if (!TortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }
    }
}

