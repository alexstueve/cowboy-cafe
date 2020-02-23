using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class defining the Jerked Soda drink
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// Gets the price of the Jerked Soda
        /// </summary>
        public override double Price
        {
            
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// Gets the calories of the Jerked Soda
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// Gets and sets the flavor of the Jerked Soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        private bool ice = true;
        /// <summary>
        /// Whether or not the Jerked Soda is served with ice
        /// </summary>
        public override bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// Gets the special instructions of the Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this drink
        /// </summary>
        /// <returns>The string decribing the Jerked Soda</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    sb.Append("Cream Soda ");
                    break;
                case SodaFlavor.OrangeSoda:
                    sb.Append("Orange Soda ");
                    break;
                case SodaFlavor.Sarsparilla:
                    sb.Append("Sarsparilla ");
                    break;
                case SodaFlavor.BirchBeer:
                    sb.Append("Birch Beer ");
                    break;
                case SodaFlavor.RootBeer:
                    sb.Append("Root Beer ");
                    break;
            }
            sb.Append("Jerked Soda");

            return sb.ToString();
        }

    }
}
