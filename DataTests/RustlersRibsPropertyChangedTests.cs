using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class RustlersRibsPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var obj = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the SpecialInstructions property should invoke PropertyChanged for SpecialInsutrctions
        /*
        [Fact]
        public void ChangingSpecialInstructionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var obj = new RustlersRibs();
            Assert.PropertyChanged(obj, "SpecialInstructions", () =>
            {
                // N/A
            });
        }
        */
    }
}
