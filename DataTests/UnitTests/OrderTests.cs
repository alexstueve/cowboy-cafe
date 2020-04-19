using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{

    class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> SpecialInstructions { get; set; }
        public Size Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class OrderTests
    {

        // adding something to the order should
        // have it appear in the Items propery
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemovedOrderITemDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] {})]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        [InlineData(new double[] { 0 })]
        public void SubtotalShouldBeTheSumOfOrderItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem() { Price = price });
            }
            Assert.Equal(total, order.Subtotal);
        }

        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem()  {Price = 3 },
                new MockOrderItem() { Price = 4 },
                new MockOrderItem() { Price = 7 },
            };
            var order = new Order();
            foreach(var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }

        [Fact]
        public void OrderImplementsINotifyPropertyChanged()
        {
            var item = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void AddingItemsShouldInvokePropertyChangedForItems()
        {
            var item = new Order();
            Assert.PropertyChanged(item, "Items", () => {
                item.Add(new AngryChicken());
            });
        }

        [Fact]
        public void RemovingItemsShouldInvokePropertyChangedForItems()
        {
            var item = new Order();
            var ac = new AngryChicken();
            item.Add(ac);
            Assert.PropertyChanged(item, "Items", () => {
                item.Remove(ac);
            });
        }

        [Fact]
        public void AddingItemsShouldInvokePropertyChangedForSubtotal()
        {
            var item = new Order();
            Assert.PropertyChanged(item, "Subtotal", () => {
                item.Add(new AngryChicken());
            });
        }

        [Fact]
        public void RemovingItemsShouldInvokePropertyChangedForSubtotal()
        {
            var item = new Order();
            var ac = new AngryChicken();
            item.Add(ac);
            Assert.PropertyChanged(item, "Subtotal", () => {
                item.Remove(ac);
            });
        }
    }
}
