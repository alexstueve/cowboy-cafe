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
        /// Starts the MenuItemSelectionControl
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }

        // POTENTIAL WAY TO INCLUDE ALL BUTTONS IN ONE HANDLER, USE TAGS ON THE BUTTONS THEMSELVES

        
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    UserControl screen;
                    IOrderItem item;
                    switch (button.Tag)
                    {
                        case "AngryChicken":
                            item = new AngryChicken();
                            screen = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "CowpokeChili":
                            item = new CowpokeChili();
                            screen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "DakotaDoubleBurger":
                            item = new DakotaDoubleBurger();
                            screen = new CustomizeDakotaDoubleBurger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "PecosPulledPork":
                            item = new PecosPulledPork();
                            screen = new CustomizePecosPulledPork();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "RustlersRibs":
                            item = new RustlersRibs();
                            screen = null;
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "TexasTripleBurger":
                            item = new TexasTripleBurger();
                            screen = new CustomizeTexasTripleBurger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "Trailburger":
                            item = new Trailburger();
                            screen = new CustomizeTrailburger();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "BakedBeans":
                            item = new BakedBeans();
                            screen = new CustomizeBakedBeans();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "ChiliCheeseFries":
                            item = new ChiliCheeseFries();
                            screen = new CustomizeChiliCheeseFries();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "CornDodgers":
                            item = new CornDodgers();
                            screen = new CustomizeCornDodgers();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "PanDeCampo":
                            item = new PanDeCampo();
                            screen = new CustomizePanDeCampo();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                    }
                }
            }
        }

        private void AddItemAndOpenCustomizationScreen(IOrderItem item, UserControl screen)
        {
            if (DataContext is Order data)
            {
                data.Add(item);
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
        /// Click event for the Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans bb = new BakedBeans();
            if (DataContext is Order data)
            {
                data.Add(bb);
            }
        }

        /// <summary>
        /// Click event for the Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            ChiliCheeseFries ccf = new ChiliCheeseFries();
            if (DataContext is Order data)
            {
                data.Add(ccf);
            }
        }

        /// <summary>
        /// Click event for the Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            CornDodgers cd = new CornDodgers();
            if (DataContext is Order data)
            {
                data.Add(cd);
            }
        }

        /// <summary>
        /// Click event for the Pan de Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            PanDeCampo pdc = new PanDeCampo();
            if (DataContext is Order data)
            {
                data.Add(pdc);
            }
        }

        /// <summary>
        /// Click event for the Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            CowboyCoffee cc = new CowboyCoffee();
            if (DataContext is Order data)
            {
                data.Add(cc);
            }
        }

        /// <summary>
        /// Click event for the Jerked Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            JerkedSoda js = new JerkedSoda();
            if (DataContext is Order data)
            {
                data.Add(js);
            }
        }

        /// <summary>
        /// Click event for the Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTea tt = new TexasTea();
            if (DataContext is Order data)
            {
                data.Add(tt);
            }
        }

        /// <summary>
        /// Click event for the Water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            Water w = new Water();
            if (DataContext is Order data)
            {
                data.Add(w);
            }
        }
    }
}
