using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class WaterPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplementINotifyPropertyChanged()
        {
            var obj = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Size property should invoke PropertyChanged for Size, Price, and Calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizePriceCalories()
        {
            var obj = new Water();
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
            var obj = new Water();
            Assert.PropertyChanged(obj, "Ice", () =>
            {
                obj.Ice = false;
            });
        }

        // Changing Ice property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new Water();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ice = false;
            });
        }

        // Changing the Lemon property should invoke PropertyChanged for Lemon
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForLemon()
        {
            var obj = new Water();
            Assert.PropertyChanged(obj, "Lemon", () =>
            {
                obj.Lemon = false;
            });
        }

        // Changing Lemon property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingLemonShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new Water();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Lemon = false;
            });
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new Water();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ice = true;
            });
        }
    }
}
