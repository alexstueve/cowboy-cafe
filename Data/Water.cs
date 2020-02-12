﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining the Water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets the price of the Water
        /// </summary>
        public override double Price { get => 0.12; }

        /// <summary>
        /// Gets the calories of the Water
        /// </summary>
        public override uint Calories { get => 0; }

        private bool lemon = false;
        /// <summary>
        /// Whether or not the Water is served with a lemon
        /// </summary>
        public bool Lemon { get => lemon; set => lemon = value; }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Water is served with ice
        /// </summary>
        public override bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// Gets the special instructions of the Water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");

                return instructions;
            }
        }
    }
}