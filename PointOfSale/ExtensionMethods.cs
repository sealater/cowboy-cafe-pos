/* ExtensionMethods.cs
 * Author: Ethan Davis */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    /// <summary>
    /// Methods to extend functionality
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Find the first ancestor in the Visual Tree that has the specified type or null if no ancestor is found
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T FindAncestor<T>(this DependencyObject obj) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(obj);

            if (parent is null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent);
        }
    }
}
