/* Order.cs
 * Author: Ethan Davis */

using CashRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Static instance of CashDrawer to be used for orders
        /// </summary>
        public static CashDrawer CashDrawer = new CashDrawer();

        /// <summary>
        /// Static instance of ReceiptPrinter to be used for orders
        /// </summary>
        public static ReceiptPrinter ReceiptPrinter = new ReceiptPrinter();

        // Record of last Order number
        private static uint lastOrderNumber = 0;

        // Order's OrderNumber identifier - Autoincrement
        public uint OrderNumber { get; } = ++lastOrderNumber;

        // Items contained within Order
        private List<IOrderItem> items = new List<IOrderItem>();

        // Public accessor for Order items
        public IEnumerable<IOrderItem> Items { get => items.ToArray(); }

        /// <summary>
        /// Cash received for this current order
        /// </summary>
        public CashReceived CashReceived { get; set; }

        /// <summary>
        /// Order subtotal
        /// </summary>
        public double Subtotal { 
            get
            {
                double subtotal = 0;

                foreach (IOrderItem item in items)
                {
                    subtotal += item.Price;
                }

                return subtotal;
            }
        }

        /// <summary>
        /// Order total
        /// </summary>
        public double Total { get => Subtotal * 1.16; }

        // Event handler for a property change on Order
        public event PropertyChangedEventHandler PropertyChanged;

        // When a property is changed, update Items and Subtotal as well
        public void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        // Adds an item to Order
        public void AddItem(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        // Removes specified item from Order
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            item.PropertyChanged -= OnPropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
