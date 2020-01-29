/*
 * Alex Stueve
 * RustlersRibs.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class represented the Rustler's Ribs entree.
    /// </summary>
    class RustlersRibs
    {
        /// <summary>
        /// The price of the ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

    }
}
