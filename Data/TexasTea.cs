using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
    {
        /// <summary>
        /// Gets the price of the Texas Tea
        /// </summary>
        public override double Price
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// Gets the calories of the Texas Tea
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        if (Sweet) return 10;
                        else return 5;
                    case Size.Medium:
                        if (Sweet) return 22;
                        else return 11;
                    case Size.Large:
                        if (Sweet) return 36;
                        else return 18;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        private bool sweet = true;
        /// <summary>
        /// Whether or not the Texas Tea is served sweet
        /// </summary>
        public bool Sweet { get => sweet; set => sweet = value; }

        private bool lemon = false;
        /// <summary>
        /// Whether or not the Texas Tea is served with a lemon
        /// </summary>
        public bool Lemon { get => lemon; set => lemon = value; }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Texas Tea is served with ice
        /// </summary>
        public override bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// Gets the special instructions of the Texas Tea
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
        /// <returns>The string decribing the Texas Tea</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            sb.Append("Texas ");
            if (Sweet) sb.Append("Sweet ");
            else sb.Append("Plain ");
            sb.Append("Tea");

            return sb.ToString();
        }
    }
}
