using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class defines the Corn Dodgers Side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// Gets the price of the Corn Dodgers
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories of the Corn Dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets and sets the size of the Corn Dodgers
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// Returns the string representation of this side
        /// </summary>
        /// <returns>The string decribing the Corn Dodgers</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            sb.Append("Corn Dodgers");

            return sb.ToString();
        }
    }
}
