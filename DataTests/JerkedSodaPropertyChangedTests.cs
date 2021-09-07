using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var obj = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Size property should invoke PropertyChanged for Size, Price, and Calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizePriceCalories()
        {
            var obj = new JerkedSoda();
            Assert.PropertyChanged(obj, "Size", () =>
            {
                obj.Size = Size.Large;
            });

            Assert.PropertyChanged(obj, "Price", () =>
            {
                obj.Size = Size.Medium;
            });

            Assert.PropertyChanged(obj, "Calories", () =>
            {
                obj.Size = Size.Small;
            });
        }

        // Changing the Ice property should invoke PropertyChanged for Ice
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var obj = new JerkedSoda();
            Assert.PropertyChanged(obj, "Ice", () =>
            {
                obj.Ice = false;
            });
        }

        // Changing Ice property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new JerkedSoda();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ice = false;
            });
        }

        // Changing the Flavor property should invoke PropertyChanged for Flavor
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForFlavor()
        {
            var obj = new JerkedSoda();
            Assert.PropertyChanged(obj, "Flavor", () =>
            {
                obj.Flavor = SodaFlavor.OrangeSoda;
            });
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new JerkedSoda();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ice = true;
            });
        }
    }
}
