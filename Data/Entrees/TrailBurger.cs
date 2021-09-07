﻿/* TrailBurger.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Backing variable for Bun
        /// </summary>
        private bool _bun = true;

        /// <summary>
        // If the entree has a bun
        /// </summary>
        public bool Bun { get => _bun; set { _bun = value; InvokePropertyChanged("Bun"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Ketchup
        /// </summary>
        private bool _ketchup = true;

        /// <summary>
        // If the entree has ketchup
        /// </summary>
        public bool Ketchup { get => _ketchup; set { _ketchup = value; InvokePropertyChanged("Ketchup"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Mustard
        /// </summary>
        private bool _mustard = true;

        /// <summary>
        // If the entree has mustard
        /// </summary>
        public bool Mustard { get => _mustard; set { _mustard = value; InvokePropertyChanged("Mustard"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Pickle
        /// </summary>
        private bool _pickle = true;

        /// <summary>
        // If the entree has pickle
        /// </summary>
        public bool Pickle { get => _pickle; set { _pickle = value; InvokePropertyChanged("Pickle"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Backing variable for Cheese
        /// </summary>
        private bool _cheese = true;

        /// <summary>
        // If the entree has cheese
        /// </summary>
        public bool Cheese { get => _cheese; set { _cheese = value; InvokePropertyChanged("Cheese"); InvokePropertyChanged("SpecialInstructions"); } }

        /// <summary>
        /// Special instructions for the preparation of the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }

        /// <summary>
        /// Returns string representation of the object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}

