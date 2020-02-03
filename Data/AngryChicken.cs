/*
 * Alex Stueve
 * AngryChicken.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class defines the Angry Chicken entree
    /// </summary>
    public class AngryChicken : Entree
    {
        private bool bread = true;
        /// <summary>
        /// If the chicken is served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If the chicken is topped with pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the chicken
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

    }
}
