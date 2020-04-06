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

        private static CashDrawer cashDrawer = new CashDrawer();

        public TransactionControl()
        {
            InitializeComponent();
        }

        public void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            if (DataContext is Order order)
            {
                ResultCode rc = ct.ProcessTransaction(order.Total);
                if (rc == ResultCode.Success)
                {
                    ReceiptPrinter rp = new ReceiptPrinter();
                    rp.Print(order.Total.ToString());
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

        public void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {

        }

        public void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {

        }

    }
}
