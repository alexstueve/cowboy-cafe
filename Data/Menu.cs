using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This class will include methods to display the menu
    /// </summary>
    public static class Menu
    {

        /// <summary>
        /// An IEnumerable of all the entrees
        /// </summary>
        /// <returns>IEnumerable of the entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new Trailburger()
            };
            return entrees;
        }

        /// <summary>
        /// An IEnumerable of all the sides
        /// </summary>
        /// <returns>IEnumerable of the sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>()
            {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
            return sides;
        }

        /// <summary>
        /// An IEnumerable of all the drinks
        /// </summary>
        /// <returns>IEnumerable of the drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>()
            {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
            return drinks;
        }

        /// <summary>
        /// An IEnumerable of the complete menu
        /// </summary>
        /// <returns>IEnumerable of the complete menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> complete = new List<IOrderItem>()
            {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new Trailburger(),
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
            return complete;
        }

    }
}
