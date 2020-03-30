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
        /// Event handler for when an item is selected to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnEditItemSelected(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order order)
            {
                if (sender is ListBox lb)
                {
                    IOrderItem item = lb.SelectedItem as IOrderItem;
                    UserControl screen = null;
                    switch(item.GetType().Name)
                    {
                        case "AngryChicken":
                            screen = new CustomizeAngryChicken();
                            break;
                        case "CowpokeChili":
                            screen = new CustomizeCowpokeChili();
                            break;
                        case "DakotaDoubleBurger":
                            screen = new CustomizeDakotaDoubleBurger();
                            break;
                        case "PecosPulledPork":
                            screen = new CustomizePecosPulledPork();
                            break;
                        case "RustlersRibs":
                            screen = null;
                            break;
                        case "TexasTripleBurger":
                            screen = new CustomizeTexasTripleBurger();
                            break;
                        case "Trailburger":
                            break;
                        case "BakedBeans":
                            screen = new CustomizeBakedBeans();
                            break;
                        case "ChiliCheeseFries":
                            screen = new CustomizeChiliCheeseFries();
                            break;
                        case "CornDodgers":
                            screen = new CustomizeCornDodgers();
                            break;
                        case "PanDeCampo":
                            screen = new CustomizePanDeCampo();
                            break;
                        case "CowboyCoffee":
                            screen = new CustomizeCowboyCoffee();
                            break;
                        case "JerkedSoda":
                            screen = new CustomizeJerkedSoda();
                            break;
                        case "TexasTea":
                            screen = new CustomizeTexasTea();
                            break;
                        case "Water":
                            screen = new CustomizeWater();
                            break;
                    }
                    OpenCustomizationScreen(item, screen);
                }
            }

        }

        /// <summary>
        /// Opens a customization screen for the item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="screen"></param>
        private void OpenCustomizationScreen(IOrderItem item, UserControl screen)
        {
            if (DataContext is Order data)
            {
                if (screen != null)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if (orderControl != null)
                    {
                        screen.DataContext = item;
                        orderControl.SwapScreen(screen);
                    }
                }

            }
        }

        /// <summary>
        /// Event handler for the remove item button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItemClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button b)
                {
                    IOrderItem item = b.DataContext as IOrderItem;
                    order.Remove(item);
                }
            }
        }

    }
}
