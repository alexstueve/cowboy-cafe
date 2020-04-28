using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Searches the menu based on string terms
        /// </summary>
        /// <param name="terms">the terms to search by</param>
        /// <returns>a list of items containing the terms</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return CompleteMenu();

            foreach (IOrderItem item in CompleteMenu())
            {
                if (item.GetType().Name != null && item.GetType().Name.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                    results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Filters by the type of the items
        /// </summary>
        /// <param name="menuList">list of items to filter</param>
        /// <param name="types">the types to filter by</param>
        /// <returns>a list of all items of the types given</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> menuList, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0) return menuList;

            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menuList)
            {
                var itemType = item.GetType();
                if (types.Contains(itemType.BaseType.Name))
                    results.Add(item);
            }
            return results;
        }

        /// <summary>
        /// Filters by the calories of items
        /// </summary>
        /// <param name="menuList"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuList, uint? min, uint? max)
        {
            if (min == null && max == null) return menuList;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in menuList)
                {
                    if (item.Calories <= max)
                        results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in menuList)
                {
                    if (item.Calories >= min)
                        results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in menuList)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by the price of items
        /// </summary>
        /// <param name="menuList"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuList, double? min, double? max)
        {
            if (min == null && max == null) return menuList;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in menuList)
                {
                    if (item.Price <= max)
                        results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in menuList)
                {
                    if (item.Price >= min)
                        results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in menuList)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

    }
}
