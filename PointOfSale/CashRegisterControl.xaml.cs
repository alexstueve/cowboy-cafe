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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the page loads, sets the text box to a static value for change purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnLoad(object sender, RoutedEventArgs e)
        {
            CashRegisterModelView cr = DataContext as CashRegisterModelView;
            DrawerTotalTextBox.Text = $"{cr.TotalValue}";
        }

        /// <summary>
        /// When the take payment button is clicked, determines if enough cash has been given
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTakePaymentButtonClicked(object sender, RoutedEventArgs e)
        {
            CashRegisterModelView cr = DataContext as CashRegisterModelView;
            double moneyGiven = cr.TotalValue - Convert.ToDouble(DrawerTotalTextBox.Text);
            if (moneyGiven >= cr.OrderValue)
            {
                DrawerTotalTextBox.Text = cr.TotalValue.ToString();
                cr.AmountPaid = moneyGiven;
                GiveChangeButton.IsEnabled = true;
            }
            else
            {
                MessageBox.Show($"Need ${cr.OrderValue - moneyGiven}");
            }
        }

        /// <summary>
        /// When the give change button is clicked, calculates the change needed and prints the receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnGiveChangeButtonClicked(object sender, RoutedEventArgs e)
        {
            CashRegisterModelView cr = DataContext as CashRegisterModelView;
            double change = cr.AmountPaid - cr.OrderValue;
            MessageBox.Show($"Change: ${change}");
            var orderControl = this.FindAncestor<OrderControl>();
            Order order = (Order)orderControl.DataContext;
            ReceiptPrinter rp = new ReceiptPrinter();
            rp.Print(order.OrderNumber.ToString());
            rp.Print(DateTime.Now.ToString());
            foreach (IOrderItem item in order.Items)
            {
                rp.Print($"{item.ToString()} ${item.Price}");
                rp.Print(item.SpecialInstructions.ToString());
            }
            rp.Print(order.Subtotal.ToString());
            rp.Print(order.Total.ToString());
            rp.Print(cr.AmountPaid.ToString());
            rp.Print(change.ToString());
            orderControl.SwapScreen(new MenuItemSelectionControl());
            orderControl.DataContext = new Order();
        }

    }
}
