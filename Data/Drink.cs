using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets and sets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }
        
        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Whether or not the drink has ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Gets a list of special instructions of the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Helper method to notify of boolean customization property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
