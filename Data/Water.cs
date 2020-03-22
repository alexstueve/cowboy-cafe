using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining the Water drink
    /// </summary>
    public class Water : Drink
    {

        private Size size = Size.Small;
        /// <summary>
        /// Gets and sets the size of the Water
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");
            }
        }

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
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; NotifyOfPropertyChanged("Lemon"); }
        }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Water is served with ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; NotifyOfPropertyChanged("Ice"); }
        }

        /// <summary>
        /// Gets the special instructions of the Water
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
        /// Returns the string representation of this drink
        /// </summary>
        /// <returns>The string decribing the Water</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            sb.Append("Water");

            return sb.ToString();
        }
    }
}
