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
                    switch (button.Tag)
                    {
                        case "AngryChicken":
                            var ac = new AngryChicken();
                            screen = new CustomizeAngryChicken();
                            AddItemAndOpenCustomizationScreen(ac, screen);
                            break;
                        case "CowpokeChili":
                            var cc = new CowpokeChili();
                            screen = new CustomizeCowpokeChili();
                            AddItemAndOpenCustomizationScreen(cc, screen);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Click event for the Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            AngryChicken ac = new AngryChicken();
            if (DataContext is Order data)
            {
                data.Add(ac);
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
        /// Click event for the Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            DakotaDoubleBurger ddb = new DakotaDoubleBurger();
            if (DataContext is Order data)
            {
                data.Add(ddb);
            }
        }

        /// <summary>
        /// Click event for the Pecos Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            PecosPulledPork ppp = new PecosPulledPork();
            if (DataContext is Order data)
            {
                data.Add(ppp);
            }
        }

        /// <summary>
        /// Click event for the Rustler's Ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            RustlersRibs rr = new RustlersRibs();
            if (DataContext is Order data)
            {
                data.Add(rr);
            }
        }

        /// <summary>
        /// Click event for the Texas Triple Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            TexasTripleBurger ttb = new TexasTripleBurger();
            if (DataContext is Order data)
            {
                data.Add(ttb);
            }
        }

        /// <summary>
        /// Click event for the Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailburgerButton_Click(object sender, RoutedEventArgs e)
        {
            TrailBurger tb = new TrailBurger();
            if (DataContext is Order data)
            {
                data.Add(tb);
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
