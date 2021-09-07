using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class OrderPropertyChangedTests
    {
        // Should implement the INotifyPropertyChanged Interface
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var obj = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(obj);
        }

        // Adding item should invoke PropertyChanged for Items
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForItems()
        {
            var obj = new Order();
            Assert.PropertyChanged(obj, "Items", () =>
            {
                obj.AddItem(new AngryChicken());
            });
        }

        // Removing item should invoke PropertyChanged for Items
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForItems()
        {
            var obj = new Order();
            var obj2 = new AngryChicken();
            obj.AddItem(obj2);
            Assert.PropertyChanged(obj, "Items", () =>
            {
                obj.Remove(obj2);
            });
        }

        // Adding item should invoke PropertyChanged for Subtotal
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForSubtotal()
        {
            var obj = new Order();
            Assert.PropertyChanged(obj, "Subtotal", () =>
            {
                obj.AddItem(new AngryChicken());
            });
        }

        // Removing item should invoke PropertyChanged for Subtotal
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForSubtotal()
        {
            var obj = new Order();
            var obj2 = new AngryChicken();
            obj.AddItem(obj2);
            Assert.PropertyChanged(obj, "Subtotal", () =>
            {
                obj.Remove(obj2);
            });
        }
    }
}
