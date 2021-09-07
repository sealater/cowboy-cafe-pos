/* OrderSummaryControl.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remove item when associated remove button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRemoveButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    order.Remove((IOrderItem)button.DataContext);
                }
            }

        }

        /// <summary>
        /// Event handler for order selection changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0 || e.AddedItems[0] == null) return;

            if (e.AddedItems[0] is IOrderItem item)
            {
                OrderControl orderControl = this.FindAncestor<OrderControl>();

                if (DataContext is Order order)
                {
                    OrderCustomizeControl screen = new OrderCustomizeControl();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen); // Switch screen
                }
            }
        }
    }
}
