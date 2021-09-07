using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var obj = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Bun property should invoke PropertyChanged for Bun
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "Bun", () =>
            {
                obj.Bun = false;
            });
        }

        // Changing Bun property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Bun = false;
            });
        }

        // Changing the Ketchup property should invoke PropertyChanged for Ketchup
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "Ketchup", () =>
            {
                obj.Ketchup = false;
            });
        }

        // Changing Ketchup property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ketchup = false;
            });
        }

        // Changing the Mustard property should invoke PropertyChanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "Mustard", () =>
            {
                obj.Mustard = false;
            });
        }

        // Changing Mustard property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Mustard = false;
            });
        }

        // Changing the Pickle property should invoke PropertyChanged for Pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "Pickle", () =>
            {
                obj.Pickle = false;
            });
        }

        // Changing Pickle property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Pickle = false;
            });
        }

        // Changing the Cheese property should invoke PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "Cheese", () =>
            {
                obj.Cheese = false;
            });
        }

        // Changing Cheese property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }
        
        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new TrailBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }
    }
}
