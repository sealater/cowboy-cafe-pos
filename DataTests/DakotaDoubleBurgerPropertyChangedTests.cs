﻿using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var obj = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Bun property should invoke PropertyChanged for Bun
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Bun", () =>
            {
                obj.Bun = false;
            });
        }

        // Changing Bun property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Bun = false;
            });
        }

        // Changing the Ketchup property should invoke PropertyChanged for Ketchup
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Ketchup", () =>
            {
                obj.Ketchup = false;
            });
        }

        // Changing Ketchup property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Ketchup = false;
            });
        }

        // Changing the Mustard property should invoke PropertyChanged for Mustard
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Mustard", () =>
            {
                obj.Mustard = false;
            });
        }

        // Changing Mustard property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Mustard = false;
            });
        }

        // Changing the Pickle property should invoke PropertyChanged for Pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Pickle", () =>
            {
                obj.Pickle = false;
            });
        }

        // Changing Pickle property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Pickle = false;
            });
        }

        // Changing the Cheese property should invoke PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Cheese", () =>
            {
                obj.Cheese = false;
            });
        }

        // Changing Cheese property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }

        // Changing the Tomato property should invoke PropertyChanged for Tomato
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Tomato", () =>
            {
                obj.Tomato = false;
            });
        }

        // Changing Tomato property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Tomato = false;
            });
        }

        // Changing the Lettuce property should invoke PropertyChanged for Lettuce
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Lettuce", () =>
            {
                obj.Lettuce = false;
            });
        }

        // Changing Lettuce property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Lettuce = false;
            });
        }

        // Changing the Mayo property should invoke PropertyChanged for Mayo
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "Mayo", () =>
            {
                obj.Mayo = false;
            });
        }

        // Changing Mayo property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Mayo = false;
            });
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new DakotaDoubleBurger();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }
    }
}
