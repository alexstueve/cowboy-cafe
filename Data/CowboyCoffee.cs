using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining the Cowboy Coffee Drink
    /// </summary>
    public class CowboyCoffee : Drink
    {

        /// <summary>
        /// Gets and sets the size of the Cowboy Coffee
        /// </summary>
        private Size size = Size.Small;
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
        /// Gets the price of the Cowboy Coffee
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// Gets the calories of the Cowboy Coffee
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        private bool roomforcream = false;
        /// <summary>
        /// Whether or not the Cowboy Coffee will be served with room for cream
        /// </summary>
        public bool RoomForCream 
        {
            get { return roomforcream; }
            set { roomforcream = value; NotifyOfPropertyChanged("RoomForCream"); }
        }

        private bool decaf = false;
        /// <summary>
        /// Whether or not the Cowboy Coffee will be decaf or not
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; NotifyOfPropertyChanged("Decaf"); }
        }

        private bool ice = false;
        /// <summary>
        /// Whether or not the Cowboy Coffee is served with ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set { ice = value; NotifyOfPropertyChanged("Ice"); }
        }

        /// <summary>
        /// Gets the special instructions of the Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this drink
        /// </summary>
        /// <returns>The string decribing the Cowboy Coffee</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            if (Decaf) sb.Append("Decaf ");
            sb.Append("Cowboy Coffee");

            return sb.ToString();
        }

    }
}
