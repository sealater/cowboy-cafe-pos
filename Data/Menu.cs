using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Menu
    {
        /// <summary>
        ///  Returns list of entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            return new List<IOrderItem>() {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger()
            };
        }

        /// <summary>
        ///  Returns list of sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            return new List<IOrderItem>() {
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo()
            };
        }

        /// <summary>
        ///  Returns list of drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            return new List<IOrderItem>() {
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
        }

        /// <summary>
        ///  Returns list of complete menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            return new List<IOrderItem>() {
                new AngryChicken(),
                new CowpokeChili(),
                new DakotaDoubleBurger(),
                new PecosPulledPork(),
                new RustlersRibs(),
                new TexasTripleBurger(),
                new TrailBurger(),
                new BakedBeans(),
                new ChiliCheeseFries(),
                new CornDodgers(),
                new PanDeCampo(),
                new CowboyCoffee(),
                new JerkedSoda(),
                new TexasTea(),
                new Water()
            };
        }
    }
}
