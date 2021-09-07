/* OrderCustomizeControl.xaml.cs
 * Author: Ethan Davis */

using CowboyCafe.Data;
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
    /// Interaction logic for OrderCustomizeControlControl.xaml
    /// </summary>
    public partial class OrderCustomizeControl : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public OrderCustomizeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Collapse a field if it's binding expression does not exist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollapseIfNull(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox checkBox = (CheckBox)sender;

                if (checkBox.GetBindingExpression(CheckBox.IsCheckedProperty).ResolvedSourcePropertyName == null)
                {
                    checkBox.Visibility = Visibility.Collapsed;
                }
            }
            else if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;

                if (radioButton.GetBindingExpression(RadioButton.IsCheckedProperty).ResolvedSourcePropertyName == null)
                {
                    radioButton.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
