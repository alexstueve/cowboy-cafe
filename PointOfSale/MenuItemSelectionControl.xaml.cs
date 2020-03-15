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
                        case "CowboyCoffee":
                            item = new CowboyCoffee();
                            screen = new CustomizeCowboyCoffee();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "JerkedSoda":
                            item = new JerkedSoda();
                            screen = new CustomizeJerkedSoda();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "TexasTea":
                            item = new TexasTea();
                            screen = new CustomizeTexasTea();
                            AddItemAndOpenCustomizationScreen(item, screen);
                            break;
                        case "Water":
                            item = new Water();
                            screen = new CustomizeWater();
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

    }
}
