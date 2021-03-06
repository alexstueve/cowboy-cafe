﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class defines the Baked Beans Side
    /// </summary>
    public class BakedBeans : Side
    {
        /// <summary>
        /// Gets the price of the Baked Beans
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
        /// Gets the calories of the Baked Beans
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the string representation of this side
        /// </summary>
        /// <returns>The string decribing the Baked Beans</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{Size} ");
            sb.Append("Baked Beans");

            return sb.ToString();
        }
    }
}
