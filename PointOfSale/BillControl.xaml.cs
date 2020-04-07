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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register("Denomination", typeof(Bills), typeof(BillControl), new PropertyMetadata(Bills.One));
        /// <summary>
        /// The denomination of this bill control
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register("Quantity", typeof(int), typeof(BillControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        /// <summary>
        /// The quantity of this bill control
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }

        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the increase button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// When the decrease button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            if (Quantity > 0) Quantity--;
        }

    }
}
