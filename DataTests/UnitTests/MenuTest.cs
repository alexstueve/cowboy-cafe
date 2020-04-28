using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTest
    {

        [Fact]
        public void MenuEntreesShouldIncludeAllEntrees()
        {
            Assert.Collection(Menu.Entrees(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<Trailburger>(tb); });
        }

        [Fact]
        public void MenuSidesShouldIncludeAllSides()
        {
            Assert.Collection(Menu.Sides(),
                bb => { Assert.IsType<BakedBeans>(bb); },
                ccf => { Assert.IsType<ChiliCheeseFries>(ccf); },
                cd => { Assert.IsType<CornDodgers>(cd); },
                pdc => { Assert.IsType<PanDeCampo>(pdc); });
        }

        [Fact]
        public void MenuDrinksShouldIncludeAllDrinks()
        {
            Assert.Collection(Menu.Drinks(),
                cc => { Assert.IsType<CowboyCoffee>(cc); },
                js => { Assert.IsType<JerkedSoda>(js); },
                tt => { Assert.IsType<TexasTea>(tt); },
                w => { Assert.IsType<Water>(w); });
        }

        [Fact]
        public void SearchStringShouldIncludeAppropriateResults()
        {
            IEnumerable<IOrderItem> results = Menu.Search("Cow");
            Assert.Collection(results,
                cc => { Assert.IsType<CowpokeChili>(cc); },
                cc => { Assert.IsType<CowboyCoffee>(cc); });
        }

        [Fact]
        public void SearchEmptyStringShouldIncludeAllItems()
        {
            IEnumerable<IOrderItem> results = Menu.Search("");
            Assert.Collection(results,
                item => { Assert.IsType<AngryChicken>(item); },
                item => { Assert.IsType<CowpokeChili>(item); },
                item => { Assert.IsType<DakotaDoubleBurger>(item); },
                item => { Assert.IsType<PecosPulledPork>(item); },
                item => { Assert.IsType<RustlersRibs>(item); },
                item => { Assert.IsType<TexasTripleBurger>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<CowboyCoffee>(item); },
                item => { Assert.IsType<JerkedSoda>(item); },
                item => { Assert.IsType<TexasTea>(item); },
                item => { Assert.IsType<Water>(item); });
        }

        [Fact]
        public void FilterByTypeShouldIncludeAppropriateResults()
        {
            List<string> types = new List<string> { "Side", "Drink" };
            IEnumerable<IOrderItem> results = Menu.FilterByType(Menu.CompleteMenu(), types);
            Assert.Collection(results,
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<CowboyCoffee>(item); },
                item => { Assert.IsType<JerkedSoda>(item); },
                item => { Assert.IsType<TexasTea>(item); },
                item => { Assert.IsType<Water>(item); });
        }

        [Fact]
        public void FilterByTypeEmptyShouldIncludeAllItems()
        {
            IEnumerable<IOrderItem> results = Menu.FilterByType(Menu.CompleteMenu(), new List<string>());
            Assert.Collection(results,
                item => { Assert.IsType<AngryChicken>(item); },
                item => { Assert.IsType<CowpokeChili>(item); },
                item => { Assert.IsType<DakotaDoubleBurger>(item); },
                item => { Assert.IsType<PecosPulledPork>(item); },
                item => { Assert.IsType<RustlersRibs>(item); },
                item => { Assert.IsType<TexasTripleBurger>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<CowboyCoffee>(item); },
                item => { Assert.IsType<JerkedSoda>(item); },
                item => { Assert.IsType<TexasTea>(item); },
                item => { Assert.IsType<Water>(item); });
        }

        [Fact]
        public void FilterByCaloriesShouldIncludeAppropriateResults()
        {
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(Menu.CompleteMenu(), 100, 300);
            Assert.Collection(results,
                item => { Assert.IsType<AngryChicken>(item); },
                item => { Assert.IsType<CowpokeChili>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<JerkedSoda>(item); });
        }

        [Fact]
        public void FilterByCaloriesEmptyShouldIncludeAllItems()
        {
            IEnumerable<IOrderItem> results = Menu.FilterByCalories(Menu.CompleteMenu(), null, null);
            Assert.Collection(results,
                item => { Assert.IsType<AngryChicken>(item); },
                item => { Assert.IsType<CowpokeChili>(item); },
                item => { Assert.IsType<DakotaDoubleBurger>(item); },
                item => { Assert.IsType<PecosPulledPork>(item); },
                item => { Assert.IsType<RustlersRibs>(item); },
                item => { Assert.IsType<TexasTripleBurger>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<CowboyCoffee>(item); },
                item => { Assert.IsType<JerkedSoda>(item); },
                item => { Assert.IsType<TexasTea>(item); },
                item => { Assert.IsType<Water>(item); });
        }

        [Fact]
        public void FilterByPriceShouldIncludeAppropriateResults()
        {
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(Menu.CompleteMenu(), 1.5, 5.5);
            Assert.Collection(results,
                item => { Assert.IsType<DakotaDoubleBurger>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<JerkedSoda>(item); });
        }

        [Fact]
        public void FilterByPriceEmptyShouldIncludeAllItems()
        {
            IEnumerable<IOrderItem> results = Menu.FilterByPrice(Menu.CompleteMenu(), null, null);
            Assert.Collection(results,
                item => { Assert.IsType<AngryChicken>(item); },
                item => { Assert.IsType<CowpokeChili>(item); },
                item => { Assert.IsType<DakotaDoubleBurger>(item); },
                item => { Assert.IsType<PecosPulledPork>(item); },
                item => { Assert.IsType<RustlersRibs>(item); },
                item => { Assert.IsType<TexasTripleBurger>(item); },
                item => { Assert.IsType<Trailburger>(item); },
                item => { Assert.IsType<BakedBeans>(item); },
                item => { Assert.IsType<ChiliCheeseFries>(item); },
                item => { Assert.IsType<CornDodgers>(item); },
                item => { Assert.IsType<PanDeCampo>(item); },
                item => { Assert.IsType<CowboyCoffee>(item); },
                item => { Assert.IsType<JerkedSoda>(item); },
                item => { Assert.IsType<TexasTea>(item); },
                item => { Assert.IsType<Water>(item); });
        }

    }
}
