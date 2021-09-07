using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class CowboyCoffeePropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowboyCoffeeShouldImplementINotifyPropertyChanged()
        {
            var obj = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Size property should invoke PropertyChanged for Size, Price, and Calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizePriceCalories()
        {
            var obj = new CowboyCoffee();
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
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "Ice", () =>
            {
                obj.Ice = true;
            });
        }

        // Changing Ice property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ice = true;
            });
        }

        // Changing the Decaf property should invoke PropertyChanged for Decaf
        [Fact]
        public void ChangingDecafShouldInvokePropertyChangedForDecaf()
        {
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "Decaf", () =>
            {
                obj.Decaf = true;
            });
        }

        // Changing the RoomForCream property should invoke PropertyChanged for RoomForCream
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForRoomForCream()
        {
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "RoomForCream", () =>
            {
                obj.RoomForCream = true;
            });
        }

        // Changing RoomForCream property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingRoomForCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.RoomForCream = true;
            });
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowboyCoffee();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.RoomForCream = true;
            });
        }
    }
}
