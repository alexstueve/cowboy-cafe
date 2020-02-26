using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {

        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        List<string> SpecialInstructions { get; }

    }
}
