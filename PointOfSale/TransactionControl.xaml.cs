using CashRegister;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        /// <summary>
        /// Card terminal for handling credit card transactions
        /// </summary>
        private CardTerminal CardTerminal;

        public TransactionControl()
        {
            InitializeComponent();

            CardTerminal = new CardTerminal();
        }

        /// <summary>
        /// Helper method to print a receipt
        /// </summary>
        /// <param name="order"></param>
        /// <param name="paidInCash"></param>
        /// <param name="totalPaid"></param>
        /// <param name="returnedAmount"></param>
        private void PrintReceipt(Order order, bool paidInCash, double totalPaid, double returnedAmount)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Order: {order.OrderNumber}\t{DateTime.Now.ToString()}\n");

            foreach (IOrderItem item in order.Items)
            {
                sb.Append($"{item.ToString()}\t{item.Price}\n");

                foreach (string instruction in item.SpecialInstructions)
                {
                    sb.Append($"\t{instruction}\n");
                }
            }

            sb.Append($"Subtotal: {order.Subtotal:c}\tTotal: {order.Total:c}\n");
            
            if (paidInCash)
            {
                sb.Append("Payment Method: Cash\n");
                sb.Append($"Paid: {totalPaid}\n");
                sb.Append($"Change: {returnedAmount}");
            }
            else
            {
                sb.Append("Payment Method: Credit");
            }

            sb.Append("\n\n\n");

            Order.ReceiptPrinter.Print(sb.ToString());
        }

        /// <summary>
        /// Handler for incrementing CashReceived properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpButtonPressed(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Pennies":
                            order.CashReceived.Pennies++;
                            break;
                        case "Nickels":
                            order.CashReceived.Nickels++;
                            break;
                        case "Dimes":
                            order.CashReceived.Dimes++;
                            break;
                        case "Quarters":
                            order.CashReceived.Quarters++;
                            break;
                        case "HalfDollars":
                            order.CashReceived.HalfDollars++;
                            break;
                        case "Dollars":
                            order.CashReceived.Dollars++;
                            break;
                        case "Ones":
                            order.CashReceived.Ones++;
                            break;
                        case "Twos":
                            order.CashReceived.Twos++;
                            break;
                        case "Fives":
                            order.CashReceived.Fives++;
                            break;
                        case "Tens":
                            order.CashReceived.Tens++;
                            break;
                        case "Twenties":
                            order.CashReceived.Twenties++;
                            break;
                        case "Fifties":
                            order.CashReceived.Fifties++;
                            break;
                        case "Hundreds":
                            order.CashReceived.Hundreds++;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

        }

        /// <summary>
        /// Handler for decrementing CashReceived properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericDownButtonPressed(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "Pennies":
                            order.CashReceived.Pennies--;
                            break;
                        case "Nickels":
                            order.CashReceived.Nickels--;
                            break;
                        case "Dimes":
                            order.CashReceived.Dimes--;
                            break;
                        case "Quarters":
                            order.CashReceived.Quarters--;
                            break;
                        case "HalfDollars":
                            order.CashReceived.HalfDollars--;
                            break;
                        case "Dollars":
                            order.CashReceived.Dollars--;
                            break;
                        case "Ones":
                            order.CashReceived.Ones--;
                            break;
                        case "Twos":
                            order.CashReceived.Twos--;
                            break;
                        case "Fives":
                            order.CashReceived.Fives--;
                            break;
                        case "Tens":
                            order.CashReceived.Tens--;
                            break;
                        case "Twenties":
                            order.CashReceived.Twenties--;
                            break;
                        case "Fifties":
                            order.CashReceived.Fifties--;
                            break;
                        case "Hundreds":
                            order.CashReceived.Hundreds--;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }

        }

        /// <summary>
        /// Event handler for credit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                ResultCode result = CardTerminal.ProcessTransaction(order.Total);

                if (result != ResultCode.Success)
                {
                    OrderStatusLabel.Text = $"Order Status: {result.ToString()}";
                }
                else
                {
                    OrderControl orderControl = this.FindAncestor<OrderControl>();

                    if (orderControl != null)
                    {
                        MenuItemSelectionControl screen = new MenuItemSelectionControl();
                        orderControl.DataContext = new Order();
                        orderControl.SwapScreen(screen); // Switch screen
                        PrintReceipt(order, false, 0, 0);
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
            }
        }

        /// <summary>
        /// Helper method for detailing the amount of a bill returned
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="billValue"></param>
        /// <param name="billQuantity"></param>
        /// <param name="billType"></param>
        /// <returns></returns>
        private int CalcNumOfReturnedBillType(ref double balance, double billValue, int billQuantity, Bills billType)
        {
            if (balance == 0) return 0;

            int returned = 0;

            while (balance - billValue > 0 && billQuantity > 0)
            {
                balance -= billValue;
                billQuantity--;
                Order.CashDrawer.RemoveBill(billType, 1);
                returned++;
            }

            return returned;
        }

        /// <summary>
        /// Helper method for detailing the amount of a coin returned
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="coinValue"></param>
        /// <param name="coinQuantity"></param>
        /// <param name="coinType"></param>
        /// <returns></returns>
        private int CalcNumOfReturnedCoinType(ref double balance, double coinValue, int coinQuantity, Coins coinType)
        {
            if (balance == 0) return 0;

            int returned = 0;

            while (balance - coinValue > 0 && coinQuantity > 0)
            {
                balance -= coinValue;
                coinQuantity--;
                Order.CashDrawer.RemoveCoin(coinType, 1);
                returned++;
            }

            return returned;
        }

        /// <summary>
        /// Event handler for when cash button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CashButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (order.CashReceived.CashTotal >= order.Total)
                {
                    double amountPaid = order.CashReceived.CashTotal;
                    double amountReturned = order.CashReceived.CashTotal - (Math.Truncate(order.Total * 100) / 100);

                    // Add cash to drawer
                    Order.CashDrawer.AddBill(Bills.Hundred, order.CashReceived.Hundreds);
                    Order.CashDrawer.AddBill(Bills.Fifty, order.CashReceived.Fifties);
                    Order.CashDrawer.AddBill(Bills.Twenty, order.CashReceived.Twenties);
                    Order.CashDrawer.AddBill(Bills.Ten, order.CashReceived.Tens);
                    Order.CashDrawer.AddBill(Bills.Five, order.CashReceived.Fives);
                    Order.CashDrawer.AddBill(Bills.Two, order.CashReceived.Twos);
                    Order.CashDrawer.AddBill(Bills.One, order.CashReceived.Ones);
                    Order.CashDrawer.AddCoin(Coins.Dollar, order.CashReceived.Dollars);
                    Order.CashDrawer.AddCoin(Coins.HalfDollar, order.CashReceived.HalfDollars);
                    Order.CashDrawer.AddCoin(Coins.Quarter, order.CashReceived.Quarters);
                    Order.CashDrawer.AddCoin(Coins.Dime, order.CashReceived.Dimes);
                    Order.CashDrawer.AddCoin(Coins.Nickel, order.CashReceived.Nickels);
                    Order.CashDrawer.AddCoin(Coins.Penny, order.CashReceived.Pennies);

                    // Return cash to customer
                    double balance = amountReturned;
                    //
                    int hundredsReturned = CalcNumOfReturnedBillType(ref balance, 100, Order.CashDrawer.Hundreds, Bills.Hundred);
                    int fiftiesReturned = CalcNumOfReturnedBillType(ref balance, 50, Order.CashDrawer.Fifties, Bills.Fifty);
                    int twentiesReturned = CalcNumOfReturnedBillType(ref balance, 20, Order.CashDrawer.Twenties, Bills.Twenty);
                    int tensReturned = CalcNumOfReturnedBillType(ref balance, 10, Order.CashDrawer.Tens, Bills.Ten);
                    int fivesReturned = CalcNumOfReturnedBillType(ref balance, 5, Order.CashDrawer.Fives, Bills.Five);
                    int twosReturned = CalcNumOfReturnedBillType(ref balance, 2, Order.CashDrawer.Twos, Bills.Two);
                    int onesReturned = CalcNumOfReturnedBillType(ref balance, 1, Order.CashDrawer.Ones, Bills.One);
                    //
                    int dollarsReturned = CalcNumOfReturnedCoinType(ref balance, 1, Order.CashDrawer.Dollars, Coins.Dollar);
                    int halfDollarsReturned = CalcNumOfReturnedCoinType(ref balance, 0.50, Order.CashDrawer.HalfDollars, Coins.HalfDollar);
                    int quartersReturned = CalcNumOfReturnedCoinType(ref balance, 0.25, Order.CashDrawer.Quarters, Coins.Quarter);
                    int dimesReturned = CalcNumOfReturnedCoinType(ref balance, 0.10, Order.CashDrawer.Dimes, Coins.Dime);
                    int nickelsReturned = CalcNumOfReturnedCoinType(ref balance, 0.05, Order.CashDrawer.Nickels, Coins.Nickel);
                    int penniesReturned = CalcNumOfReturnedCoinType(ref balance, 0.01, Order.CashDrawer.Pennies, Coins.Penny);

                    OrderStatusLabel.Text = "Order Status: Return change to customer";
                    ReturnToCustomer.Text = $"Order Status: Return to customer -> (100's)={hundredsReturned}, (50's)={fiftiesReturned}, (20's)={twentiesReturned}, (10's)={tensReturned}, " +
                        $"(5's)={fivesReturned}, (2's)={twosReturned}, (1's)={onesReturned}, (1's [coin])={dollarsReturned}, (0.5's)={halfDollarsReturned}, " +
                        $"(0.25)={quartersReturned}, (0.10)={tensReturned}, (0.05)={nickelsReturned}, (0.01)={penniesReturned}";

                    PrintReceipt(order, true, amountPaid, amountReturned);
                }
            }
        }
    }
}
