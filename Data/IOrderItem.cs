using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {

        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of this order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
