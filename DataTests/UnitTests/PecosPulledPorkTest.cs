using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal(5.88, pulledPork.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Equal<uint>(528, pulledPork.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var pulledPork = new PecosPulledPork();
            Assert.Empty(pulledPork.SpecialInstructions);
        }

        [Fact]
        public void HoldingBreadShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bread", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddSpecialInstruction()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Pickle = false;
            Assert.Collection(pulledPork.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingBothBreadAndPickleShouldAddTwoSpecialInstructions()
        {
            var pulledPork = new PecosPulledPork();
            pulledPork.Bread = false;
            pulledPork.Pickle = false;
            Assert.Contains("hold pickle", pulledPork.SpecialInstructions);
            Assert.Contains("hold bread", pulledPork.SpecialInstructions);
        }

        [Fact]
        public void PecosPulledPorkImplementsINotifyPropertyChanged()
        {
            var item = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForBread()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "Bread", () => {
                item.Bread = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForPickle()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "Pickle", () => {
                item.Pickle = false;
            });
        }

        [Fact]
        public void ChangingPicklePropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Pickle = false;
            });
        }

        [Fact]
        public void ChangingBreadPropertyShouldInvokePropertyChangedForSpecialInstructions()
        {
            var item = new PecosPulledPork();
            Assert.PropertyChanged(item, "SpecialInstructions", () => {
                item.Bread = false;
            });
        }
    }
}
