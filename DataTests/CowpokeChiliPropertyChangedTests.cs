using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var obj = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Cheese property should invoke PropertyChanged for Cheese
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "Cheese", () =>
            {
                obj.Cheese = false;
            });
        }

        // Changing Cheese property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }

        // Changing SourCream property should invoke PropertyChanged for SourCream
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SourCream", () =>
            {
                obj.SourCream = false;
            });
        }

        // Changing the SourCream property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.SourCream = false;
            });
        }

        // Changing GreenOnions property should invoke PropertyChanged for GreenOnions
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "GreenOnions", () =>
            {
                obj.GreenOnions = false;
            });
        }

        // Changing the GreenOnions property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.GreenOnions = false;
            });
        }

        // Changing TortillaStrips property should invoke PropertyChanged for TortillaStrips
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "TortillaStrips", () =>
            {
                obj.TortillaStrips = false;
            });
        }

        // Changing the TortillaStrips property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.TortillaStrips = false;
            });
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new CowpokeChili();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Cheese = false;
            });
        }
    }
}
