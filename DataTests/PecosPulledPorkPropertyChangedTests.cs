using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class PecosPulledPorkPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {
            var obj = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Bread property should invoke PropertyChanged for Bread
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var obj = new PecosPulledPork();
            Assert.PropertyChanged(obj, "Bread", () =>
            {
                obj.Bread = false;
            });
        }

        // Changing Bread property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new PecosPulledPork();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Bread = false;
            });
        }

        // Changing the Pickle property should invoke PropertyChanged for Pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var obj = new PecosPulledPork();
            Assert.PropertyChanged(obj, "Pickle", () =>
            {
                obj.Pickle = false;
            });
        }

        // Changing Pickle property should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new PecosPulledPork();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Pickle = false;
            });
        }
        
        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new PecosPulledPork();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                obj.Pickle = false;
            });
        }
    }
}
