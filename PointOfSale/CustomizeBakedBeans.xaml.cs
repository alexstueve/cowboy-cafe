﻿using System;
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
    /// Interaction logic for CustomizeBakedBeans.xaml
    /// </summary>
    public partial class CustomizeBakedBeans : UserControl
    {
        public CustomizeBakedBeans()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When an enum property for this item changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ChangeItemEnums(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if (ancestor is OrderControl)
            {
                ancestor.ItemChange();
            }
        }
    }
}
