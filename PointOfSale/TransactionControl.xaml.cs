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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        private static CashRegisterModelView cashDrawer = new CashRegisterModelView();

        public TransactionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the pay by credit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            if (DataContext is Order order)
            {
                ResultCode rc = ct.ProcessTransaction(order.Total);
                if (rc == ResultCode.Success)
                {
                    ReceiptPrinter rp = new ReceiptPrinter();
                    rp.Print(order.OrderNumber.ToString());
                    rp.Print(DateTime.Now.ToString());
                    foreach(IOrderItem item in order.Items)
                    {
                        rp.Print($"{item.ToString()} ${item.Price}");
                        rp.Print(item.SpecialInstructions.ToString());
                    }
                    rp.Print(order.Subtotal.ToString());
                    rp.Print(order.Total.ToString());
                    rp.Print("Credit");
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl.SwapScreen(new MenuItemSelectionControl());
                    orderControl.DataContext = new Order();
                }
                else
                {
                    MessageBox.Show($"{rc}");
                }
            }
        }

        /// <summary>
        /// When the pay by cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CashRegisterControl crc = new CashRegisterControl();
            crc.DataContext = cashDrawer;
            orderControl.SwapScreen(crc);
            if (DataContext is Order order)
            {
                cashDrawer.OrderValue = order.Total;
            }
        }

        /// <summary>
        /// When the cancel transaction button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Container.Child = new MenuItemSelectionControl();
        }

    }
}
