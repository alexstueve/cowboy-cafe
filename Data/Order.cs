using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        /// <summary>
        /// The order number, will increment with each initialization
        /// </summary>
        private static uint LastOrderNumber = 0;

        /// <summary>
        /// constructor for the order, increments the order number
        /// </summary>
        public Order()
        {
            LastOrderNumber++;
        }

        

        /// <summary>
        /// a list of all the items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// gets all of the items currently in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items 
        { 
            get
            { 
                return items.ToArray();
            }
        }

        private double subtotal = 0;
        /// <summary>
        /// gets the subtotal of all the items in the order and invokes the event handler
        /// </summary>
        public double Subtotal
        {
            get
            {
                subtotal = 0;
                foreach (var item in Items)
                {
                    subtotal += item.Price;
                }

                return subtotal;
            }
        }

        /// <summary>
        /// gets the order number for this order
        /// </summary>
        public uint OrderNumber { get => LastOrderNumber; }

        /// <summary>
        /// event handler to notify when a property in this class has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// adds an item to the order and invokes the event handler
        /// </summary>
        /// <param name="item">the item to be added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// removes an item to the order and invokes the event handler
        /// </summary>
        /// <param name="item">the order to remove</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

    }
}
