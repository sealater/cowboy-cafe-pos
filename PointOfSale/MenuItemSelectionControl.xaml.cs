/* MenuItemSelectionControl.cs
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        /// <summary>
        /// Attached OrderControl
        /// </summary>
        private OrderControl orderControl;

        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        // Generic handler for ItemAddButton clicked event
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    IOrderItem item = null;
                    OrderCustomizeControl screen = new OrderCustomizeControl();

                    switch(button.Tag)
                    {
                        case "Angry Chicken":
                            item = new AngryChicken();
                            break;
                        case "Cowpoke Chili":
                            item = new CowpokeChili();
                            break;
                        case "Dakota Double Burger":
                            item = new DakotaDoubleBurger();
                            break;
                        case "Pecos Pulled Pork":
                            item = new PecosPulledPork();
                            break;
                        case "Rustlers Ribs":
                            item = new RustlersRibs();
                            break;
                        case "Texas Triple Burger":
                            item = new TexasTripleBurger();
                            break;
                        case "Trail Burger":
                            item = new TrailBurger();
                            break;
                        case "Baked Beans":
                            item = new BakedBeans();
                            break;
                        case "Chili Cheese Fries":
                            item = new ChiliCheeseFries();
                            break;
                        case "Corn Dodgers":
                            item = new CornDodgers();
                            break;
                        case "Pan de Campo":
                            item = new PanDeCampo();
                            break;
                        case "Cowboy Coffee":
                            item = new CowboyCoffee();
                            break;
                        case "Jerked Soda":
                            item = new JerkedSoda();
                            break;
                        case "Texas Tea":
                            item = new TexasTea();
                            break;
                        case "Water":
                            item = new Water();
                            break;
                        default:
                            throw new NotImplementedException();
                    }

                    screen.DataContext = item;
                    order.AddItem(item);
                    orderControl.SwapScreen(screen); // Switch screen
                }
            }
        }
    }
}
