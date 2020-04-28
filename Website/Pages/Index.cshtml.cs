using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The menu to display
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }

        /// <summary>
        /// The search terms for the menu
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The types to filter by
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Types { get; set; }

        /// <summary>
        /// The min calories to filter by
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// The max calories to filter by
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// The min price to filter by
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The max price to filter by
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Method is called when a get request is made, when the search button is pressed
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByType(MenuItems, Types);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
        }
    }
}
