using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class BakedBeansPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void BakedBeansShouldImplementINotifyPropertyChanged()
        {
            var obj = new BakedBeans();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Changing the Size property should invoke PropertyChanged for Size, Price, and Calories
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSizePriceCalories()
        {
            var obj = new BakedBeans();
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
    }
}
